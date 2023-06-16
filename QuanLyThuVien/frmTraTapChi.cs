using DevExpress.Utils.MVVM;
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
    public partial class frmTraTapChi : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        public frmTraTapChi()
        {
            InitializeComponent();
        }

       

        private void frmTraTapChi_Load(object sender, EventArgs e)
        {
            try
            {
                sP_TAP_CHI_CHUA_TRATableAdapter.Connection.ConnectionString = Program.connstr;
                sP_TAP_CHI_CHUA_TRATableAdapter.Fill(dS.SP_TAP_CHI_CHUA_TRA, Program.username);
            } catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn tải lại, toàn bộ kệ sẽ mất!!!", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dvKeTapChi.CancelEdit();
                dvKeTapChi.Rows.Clear();
                bdsTapChiChuaTra.CancelEdit();
                try
                {
                    this.sP_TAP_CHI_CHUA_TRATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_TAP_CHI_CHUA_TRATableAdapter.Fill(dS.SP_TAP_CHI_CHUA_TRA, Program.username);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải lại trang!\n" + ex.Message);
                }
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (bdsTapChiChuaTra.Count == 0)
            {
                MessageBox.Show("Bạn không có gì để trả!");
                return;
            }
            vitri = bdsTapChiChuaTra.Position;

            DataRowView currentRow = (DataRowView)bdsTapChiChuaTra.Current;
            DataGridViewRow sachDatVaoKe = dvKeTapChi.Rows[dvKeTapChi.Rows.Add()];
            sachDatVaoKe.Cells["TENTAPCHI"].Value = currentRow["TENTAPCHI"];
            sachDatVaoKe.Cells["IDKI"].Value = currentRow["IDKI"];
            sachDatVaoKe.Cells["NGAYMUON"].Value = currentRow["NGAYMUON"];
            sachDatVaoKe.Cells["SONGAY"].Value = currentRow["SONGAY"];

            bdsTapChiChuaTra.RemoveAt(vitri);
            if(dvKeTapChi.Rows.Count > 0)
            {
                btnLoaiBo.Enabled = true;
            }
        }

        private void btnLoaiBo_Click(object sender, EventArgs e)
        {
            if (dvKeTapChi.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dvKeTapChi.SelectedRows[0];

                // Lấy giá trị từ dòng được chọn
                object[] values = new object[selectedRow.Cells.Count];
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {

                    values[i] = selectedRow.Cells[i].Value;
                }

                // Thêm dòng mới vào bdsSachCoTheMuon và gán giá trị từ dòng được chọn
                DataRowView newRow = (DataRowView)bdsTapChiChuaTra.AddNew();
                newRow.Row.ItemArray = values;

                // Xóa dòng từ dvGioSach
                dvKeTapChi.Rows.Remove(selectedRow);
            }
            if(dvKeTapChi.Rows.Count == 0)
            {
                btnLoaiBo.Enabled = false;
            }
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            if (dvKeTapChi.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn gì để trả cả!");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn trả {dvKeTapChi.Rows.Count} quyển tạp chí này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1)
             == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dvKeTapChi.Rows)
                {
                    // Lấy giá trị từ dòng được chọn
                    object[] values = new object[5];
                    values[0] = Program.username;
                    values[1] = row.Cells["IDKI"].Value;
                    values[2] = row.Cells["NGAYMUON"].Value;
                    values[3] = DateTime.Today.ToString("yyyy-MM-dd");
                    values[4] = row.Cells["SONGAY"].Value;

                

                    Program.KetNoi();
                    Program.ExecSqlDataReader($"EXEC SP_UPDATE_TRA_TAP_CHI '{values[0]}', {values[1]} , '{values[3]}'");
                }
                MessageBox.Show("Đã trả!\n" +
                    "Cảm ơn bạn đã mượn tạp chí của chúng tôi!");
                dvKeTapChi.Rows.Clear();
                //btnTaiLai.PerformClick();
            }
        }
    }
}
