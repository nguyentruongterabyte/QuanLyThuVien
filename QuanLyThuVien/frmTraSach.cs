using DevExpress.Utils.Html.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmTraSach : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        public frmTraSach()
        {
            InitializeComponent();
        }

        

        private void frmTraSach_Load(object sender, EventArgs e)
        {
            try
            {

                sP_SACH_CHUA_TRATableAdapter.Connection.ConnectionString = Program.connstr;
                sP_SACH_CHUA_TRATableAdapter.Fill(dS.SP_SACH_CHUA_TRA, Program.username);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (bdsSachChuaTra.Count == 0)
            {
                MessageBox.Show("Bạn không có gì để trả!");
                return;
            }
            vitri = bdsSachChuaTra.Position;

            DataRowView currentRow = (DataRowView)bdsSachChuaTra.Current;
            DataGridViewRow sachDatVaoKe = dvKeSach.Rows[dvKeSach.Rows.Add()];
            sachDatVaoKe.Cells["IDSACH"].Value = currentRow["IDSACH"];
            sachDatVaoKe.Cells["TENSACH"].Value = currentRow["TENSACH"];
            sachDatVaoKe.Cells["NGAYMUON"].Value = currentRow["NGAYMUON"];
            sachDatVaoKe.Cells["SONGAY"].Value = currentRow["SONGAY"];
            sachDatVaoKe.Cells["TINHTRANG"].Value = currentRow["TINHTRANG"];
            sachDatVaoKe.Cells["STT"].Value = currentRow["STT"];
            //sachMuonMoi.Cells["TinhTrang"].Value = currentRow["TINHTRANG"];

            bdsSachChuaTra.RemoveAt(vitri);
            if(dvKeSach.Rows.Count > 0)
            {
                btnLoaiBo.Enabled = true;
            }
        }

        private void btnLoaiBo_Click(object sender, EventArgs e)
        {
            if (dvKeSach.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dvKeSach.SelectedRows[0];

                // Lấy giá trị từ dòng được chọn
                object[] values = new object[selectedRow.Cells.Count];
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {

                    values[i] = selectedRow.Cells[i].Value;
                }

                // Thêm dòng mới vào bdsSachCoTheMuon và gán giá trị từ dòng được chọn
                DataRowView newRow = (DataRowView)bdsSachChuaTra.AddNew();
                newRow.Row.ItemArray = values;

                // Xóa dòng từ dvGioSach
                dvKeSach.Rows.Remove(selectedRow);
            }
            if(dvKeSach.Rows.Count == 0)
            {
                btnLoaiBo.Enabled = false;
            }
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {

            if (dvKeSach.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn gì để trả cả!");
                return;
            }
            if (MessageBox.Show($"Bạn có chắc muốn trả {dvKeSach.Rows.Count} quyển sách này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1)
             == System.Windows.Forms.DialogResult.Yes)
            {
                

                try
                {
                    foreach (DataGridViewRow row in dvKeSach.Rows)
                    {
                        // Lấy giá trị từ dòng được chọn
                        object[] values = new object[6];
                        values[0] = Program.username;
                        values[1] = row.Cells["IDSACH"].Value;
                        values[2] = row.Cells["NGAYMUON"].Value;
                        values[3] = DateTime.Today.ToString("yyyy-MM-dd");
                        values[4] = row.Cells["SONGAY"].Value;
                        values[5] = row.Cells["TINHTRANG"].Value;

                        int tinhTrangInt = 1;
                        switch (values[5])
                        {
                            case "Mới":
                                tinhTrangInt = 1;
                                break;
                            case "Cũ":
                                tinhTrangInt = 2;
                                break;
                            case "Hỏng":
                                tinhTrangInt = 3;
                                break;
                            case "Mất trang":
                                tinhTrangInt = 4;
                                break;
                            default: 
                                tinhTrangInt = 404;
                                break;
                        }

                        // Convert chuỗi thành ngày yyyy-MM-dd
                        string ngayChuyenDoi = values[2].ToString().Split(' ')[0].Split('/')[2]
                                                + '-' + values[2].ToString().Split(' ')[0].Split('/')[1]
                                                + '-' +values[2].ToString().Split(' ')[0].Split('/')[0];
                        
                        // Update tình trạng cuốn sách
                        Program.KetNoi();
                        Program.ExecSqlDataReader($"EXEC SP_UPDATE_CUON_SACH {values[1]}, {tinhTrangInt}");
                        
                        // Update ngày trả sách của chi tiết mượn sách 
                        Program.KetNoi();
                        Program.ExecSqlDataReader($"EXEC SP_UPDATE_NGAY_TRA_SACH {values[1]}, '{values[0]}', '{ngayChuyenDoi}', '{values[3]}'");


                    }
                    

                    MessageBox.Show("Đã trả!\n" +
                        "Cảm ơn bạn đã mượn sách của chúng tôi!");
                    dvKeSach.Rows.Clear();
                    //btnTaiLai.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi chi tiết mượn sách!\n" + ex.Message);
                    return;
                }
            }
        }

        private void dvKeSach_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
            if (dvKeSach.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dvKeSach.SelectedRows[0];

                // Lấy giá trị từ dòng được chọn
                object[] values = new object[selectedRow.Cells.Count];
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {

                    values[i] = selectedRow.Cells[i].Value;
                }

                // Thêm dòng mới vào bdsSachCoTheMuon và gán giá trị từ dòng được chọn
                DataRowView newRow = (DataRowView)bdsSachChuaTra.AddNew();
                newRow.Row.ItemArray = values;

                // Xóa dòng từ dvGioSach
                dvKeSach.Rows.Remove(selectedRow);
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn tải lại, toàn bộ kệ sách sẽ trống!!!!!!!!", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dvKeSach.CancelEdit();
                dvKeSach.Rows.Clear();
                bdsSachChuaTra.CancelEdit();
                try
                {
                    this.sP_SACH_CHUA_TRATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_SACH_CHUA_TRATableAdapter.Fill(dS.SP_SACH_CHUA_TRA, Program.username);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải lại trang!\n" + ex.Message);
                }
            }
            
           
        }
    }
}
