using DevExpress.XtraEditors.Popup;
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
    public partial class frmMuonSach : DevExpress.XtraEditors.XtraForm
    {

        int vitri = 0;
        public frmMuonSach()
        {
            InitializeComponent();
        }

        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.CT_MUONSACH' table. You can move, or remove it, as needed.
            this.cT_MUONSACHTableAdapter.Fill(this.dS.CT_MUONSACH);
            // TODO: This line of code loads data into the 'dS.V_SACH_CO_THE_MUON' table. You can move, or remove it, as needed.
            this.v_SACH_CO_THE_MUONTableAdapter.Fill(this.dS.V_SACH_CO_THE_MUON);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (bdsSachCoTheMuon.Count == 0)
            {
                MessageBox.Show("Không có gì để mượn!");
                return;
            }
            
            vitri = bdsSachCoTheMuon.Position;

            // Lấy vị trí dòng hiện tại được chọn
            DataRowView currentRow = (DataRowView)bdsSachCoTheMuon.Current;
            DataGridViewRow sachMuonMoi = dvGioSach.Rows[dvGioSach.Rows.Add()];
            sachMuonMoi.Cells["IDSACH"].Value = currentRow["IDSACH"];
            sachMuonMoi.Cells["TENSACH"].Value = currentRow["TENSACH"];
            sachMuonMoi.Cells["LANXB"].Value = currentRow["LANXB"];
            sachMuonMoi.Cells["STT"].Value = currentRow["STT"];
            sachMuonMoi.Cells["MASACH"].Value = currentRow["MASACH"];
            sachMuonMoi.Cells["TINHTRANG"].Value = currentRow["TINHTRANG"];
            //sachMuonMoi.Cells["TinhTrang"].Value = currentRow["TINHTRANG"];

            bdsSachCoTheMuon.RemoveAt(vitri);

        }

        private void btnLoaiBo_Click(object sender, EventArgs e)
        {
            if (dvGioSach.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dvGioSach.SelectedRows[0];

                // Lấy giá trị từ dòng được chọn
                object[] values = new object[selectedRow.Cells.Count];
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    
                    values[i] = selectedRow.Cells[i].Value;
                }

                // Thêm dòng mới vào bdsSachCoTheMuon và gán giá trị từ dòng được chọn
                DataRowView newRow = (DataRowView)bdsSachCoTheMuon.AddNew();
                newRow.Row.ItemArray = values;

                // Xóa dòng từ dvGioSach
                dvGioSach.Rows.Remove(selectedRow);
            }
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
 

            if (Validator.isEmptyText(txtSoNgay.Text))
            {
                MessageBox.Show("Vui lòng chọn số ngày mượn!");
                return;
            }

            if (dvGioSach.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn gì cả!");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn mượn {dvGioSach.Rows.Count} quyển sách này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1)
             == System.Windows.Forms.DialogResult.Yes)
            {
                string result = "";
                int soNgayMuon = int.Parse(txtSoNgay.Text);
                foreach (DataGridViewRow row in dvGioSach.Rows)
                {
                    // Lấy giá trị từ dòng được chọn
                    object[] values = new object[5];
                    values[0] = Program.username;
                    values[1] = row.Cells["IDSACH"].Value;

                    values[2] = DateTime.Today.ToString("yyyy-MM-dd");
                    values[3] = null;
                    values[4] = soNgayMuon;

                    int state = 0;
                    try
                    {
                        Program.KetNoi();
                        state = Program.ExecSqlNonQuery($"EXEC SP_INSERT_CT_MUON_SACH '{values[0]}', {values[1]}, '{values[2]}', NULL, {values[4]}");
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ghi sách id = [{values[1]}] vào hệ thống thất bại!\n" + ex.Message);
                    }

                    if (state == 0)
                    {
                        result += ($"Ghi sách id = [{values[1]}] vào hệ thống thành công!\n");

                    } else
                    {
                        result += $"Ghi sách id = [{values[1]}] vào hệ thống thất bại!\n";
                    }



                }
                MessageBox.Show(result);
                dvGioSach.Rows.Clear();

            }
        }

        private void dvGioSach_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // Ngăn sự kiện mặc định xảy ra
            e.Cancel = true;
            if (dvGioSach.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dvGioSach.SelectedRows[0];

                // Lấy giá trị từ dòng được chọn
                object[] values = new object[selectedRow.Cells.Count];
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {

                    values[i] = selectedRow.Cells[i].Value;
                }

                // Thêm dòng mới vào bdsSachCoTheMuon và gán giá trị từ dòng được chọn
                DataRowView newRow = (DataRowView)bdsSachCoTheMuon.AddNew();
                newRow.Row.ItemArray = values;

                // Xóa dòng từ dvGioSach
                dvGioSach.Rows.Remove(selectedRow);
            }
        }

        private void txtSoNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            try
            {
                this.v_SACH_CO_THE_MUONTableAdapter.Connection.ConnectionString = Program.connstr;
                this.v_SACH_CO_THE_MUONTableAdapter.Fill(this.dS.V_SACH_CO_THE_MUON);
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lại!\n" + ex.Message);
            }
        }
    }
}
