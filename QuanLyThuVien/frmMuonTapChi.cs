using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmMuonTapChi : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        public frmMuonTapChi()
        {
            InitializeComponent();
        }

       

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (bdsTapChi.Count == 0)
            {
                MessageBox.Show("Không có gì dể mượn!");
                return;
            }

            vitri = bdsTapChi.Position;
            DataRowView currentRow = (DataRowView)bdsTapChi.Current;
            DataGridViewRow tapChiMuonMoi = dvGioTapChi.Rows[dvGioTapChi.Rows.Add()];

            tapChiMuonMoi.Cells["IDKI"].Value = currentRow["IDKI"];
            tapChiMuonMoi.Cells["TENTAPCHI"].Value = currentRow["TENTAPCHI"];
            tapChiMuonMoi.Cells["NXB"].Value = currentRow["NXB"];
            tapChiMuonMoi.Cells["DINHKI"].Value = currentRow["DINHKI"];

            bdsTapChi.RemoveAt(vitri);
        }

        private void btnLoaiBo_Click(object sender, EventArgs e)
        {
            if (dvGioTapChi.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dvGioTapChi.SelectedRows[0];

                // Lấy giá trị từ dòng được chọn
                object[] values = new object[selectedRow.Cells.Count];
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {

                    values[i] = selectedRow.Cells[i].Value;
                }

                // Thêm dòng mới vào bdsSachCoTheMuon và gán giá trị từ dòng được chọn
                DataRowView newRow = (DataRowView)bdsTapChi.AddNew();
                newRow.Row.ItemArray = values;

                // Xóa dòng từ dvGioSach
                dvGioTapChi.Rows.Remove(selectedRow);
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_DS_BAO_TAP_CHI_CO_THE_MUONTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_DS_BAO_TAP_CHI_CO_THE_MUONTableAdapter.Fill(this.dS.SP_DS_BAO_TAP_CHI_CO_THE_MUON, Program.username);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lại!\n" + ex.Message);
            }
        }

        private void frmMuonTapChi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.CT_MUONBAO' table. You can move, or remove it, as needed.
            sP_DS_BAO_TAP_CHI_CO_THE_MUONTableAdapter.Connection.ConnectionString = Program.connstr;
            sP_DS_BAO_TAP_CHI_CO_THE_MUONTableAdapter.Fill(dS.SP_DS_BAO_TAP_CHI_CO_THE_MUON, Program.username);

        }

        private void txtSoNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {

            if (Validator.isEmptyText(txtSoNgay.Text))
            {
                MessageBox.Show("Vui lòng nhập số ngày mượn!");
                return;
            }
            if (dvGioTapChi.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn gì cả!");
                return;
            }
            if (MessageBox.Show($"Bạn có chắc muốn mượn {dvGioTapChi.Rows.Count} tạp chí này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1)
             == System.Windows.Forms.DialogResult.Yes)
            {
                string result = "";
                int soNgayMuon = int.Parse(txtSoNgay.Text);
                foreach (DataGridViewRow row in dvGioTapChi.Rows)
                {
                    // Lấy giá trị từ dòng được chọn
                    object[] values = new object[5];
                    values[0] = Program.username;
                    values[1] = row.Cells["IDKI"].Value;

                    values[2] = DateTime.Today.ToString("yyyy-MM-dd");
                    values[3] = null;
                    values[4] = soNgayMuon;
                    int state = 0;
                    try
                    {
                        Program.KetNoi();
                        state = Program.ExecSqlNonQuery($"EXEC SP_INSERT_CT_MUON_BAO '{values[0]}', {values[1]}, '{values[2]}', NULL, {values[4]}");

                        Program.KetNoi();
                        state = Program.ExecSqlNonQuery($"EXEC SP_UPDATE_LUONG_TON_KY_XB {values[1]}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ghi tạp chí id = [{values[1]}] vào hệ thống thất bại!\n" + ex.Message);
                    }

                    if (state == 0)
                    {
                        result += ($"Ghi tạp chí id = [{values[1]}] vào hệ thống thành công!\n");

                    }
                    else
                    {
                        result += $"Ghi tạp chí id = [{values[1]}] vào hệ thống thất bại!\n";
                    }
                }
                MessageBox.Show(result);
                dvGioTapChi.Rows.Clear();
            }
        }

        private void dvGioTapChi_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
            if (dvGioTapChi.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dvGioTapChi.SelectedRows[0];

                // Lấy giá trị từ dòng được chọn
                object[] values = new object[selectedRow.Cells.Count];
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {

                    values[i] = selectedRow.Cells[i].Value;
                }

                // Thêm dòng mới vào bdsSachCoTheMuon và gán giá trị từ dòng được chọn
                DataRowView newRow = (DataRowView)bdsTapChi.AddNew();
                newRow.Row.ItemArray = values;

                // Xóa dòng từ dvGioSach
                dvGioTapChi.Rows.Remove(selectedRow);
            }
        }
    }
}
