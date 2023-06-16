using DevExpress.XtraEditors;
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
    public partial class frmXuatBan : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string maXuatBan = "";
        Boolean chucnang = true;
        public frmXuatBan()
        {
            InitializeComponent();
        }

        private void frmXuatBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.V_Sach' table. You can move, or remove it, as needed.
            this.v_SachTableAdapter.Fill(this.dS.V_Sach);
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.XUATBAN' table. You can move, or remove it, as needed.
            this.xUATBANTableAdapter.Connection.ConnectionString = Program.connstr;
            this.xUATBANTableAdapter.Fill(this.dS.XUATBAN);
            // TODO: This line of code loads data into the 'dS.CUONSACH' table. You can move, or remove it, as needed.
            this.cUONSACHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cUONSACHTableAdapter.Fill(this.dS.CUONSACH);
            txtGia.ReadOnly = txtKhoGiay.ReadOnly = txtMaSach.Enabled = txtNamXB.ReadOnly = txtNhaXB.ReadOnly = txtSoTrang.ReadOnly = true;
            lblSoLuong.Visible = txtSoLuong.Visible =chkDiaCD.Enabled=  false;
            gcXuatBan.Enabled = true;
            if (bdsXuatBan.Count == 0)
            {
                btnSua.Enabled = false;
            }
            panelControl1.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chucnang = true;
           
            vitri = bdsXuatBan.Position;

            bdsXuatBan.AddNew();
            chkDiaCD.Checked = false;
            gcXuatBan.Enabled = btnSua.Enabled = btnThem.Enabled = btnLamMoi.Enabled = txtGia.ReadOnly = txtKhoGiay.ReadOnly  = txtNamXB.ReadOnly = txtNhaXB.ReadOnly = txtSoTrang.ReadOnly = false;
            lblSoLuong.Visible = txtSoLuong.Visible = txtMaSach.Enabled = btnGhi.Enabled = btnHuy.Enabled = chkDiaCD.Enabled= true ;
            panelControl1.Enabled = true;
        }

        
       

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chucnang = false;
            vitri = bdsXuatBan.Position;

            gcXuatBan.Enabled = btnSua.Enabled = btnThem.Enabled = btnLamMoi.Enabled = lblSoLuong.Visible = txtSoLuong.Visible = txtGia.ReadOnly = txtKhoGiay.ReadOnly = txtNamXB.ReadOnly = txtNhaXB.ReadOnly = txtSoTrang.ReadOnly = false;
            btnGhi.Enabled = btnHuy.Enabled = txtMaSach.Enabled =chkDiaCD.Enabled =  true;
            panelControl1.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int soLuong;
            if (Validator.isEmptyText(txtGia.Text))
            {
                MessageBox.Show("Không được để trống giá!");
                return;
            }
            if (Validator.isEmptyText(txtKhoGiay.Text))
            {
                MessageBox.Show("Không được để trống khổ giẩy!");
                return;
            }
            if (Validator.isEmptyText(txtMaSach.Text))
            {
                MessageBox.Show("Không được để trống mã sách!");
                return;
            }
            if (Validator.isEmptyText(txtNamXB.Text))
            {
                MessageBox.Show("Không được để trống năm xuất bản!");
                return;
            }
            if (Validator.isEmptyText(txtNhaXB.Text))
            {
                MessageBox.Show("Không được để trống nhà xuất bản!");
                return;
            }
            if (Validator.isEmptyText(txtSoLuong.Text) && chucnang)
            {
                MessageBox.Show("Không được để trống số lượng!");
                return;
              
               
            }

            soLuong = int.Parse(txtSoLuong.Text);

            if (soLuong == 0 || soLuong < 0)
            {
                MessageBox.Show("Số lượng không được nhỏ hơn 1!");
                return;
            }

            if (Validator.isEmptyText(txtSoTrang.Text))
            {
                MessageBox.Show("Không được để trống số trang!");
                return;
            }

            if (Validator.isEmptyText(txtLanXB.Text))
            {
                MessageBox.Show("Không được để trống lần xuất bản!");
                return;
            }
            try
            {
                bdsXuatBan.EndEdit();
                bdsXuatBan.ResetCurrentItem();
                this.xUATBANTableAdapter.Connection.ConnectionString = Program.connstr;
                this.xUATBANTableAdapter.Update(this.dS.XUATBAN);
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi xuất bản!\n" + ex.Message);
                return;
            }
            if (chucnang == true)
            {
                if (MessageBox.Show($"Bạn có chắc muốn xuất bản {txtSoLuong.Text} cuốn sách {txtMaSach.SelectedValue},khi xuất bản sẽ không thay đổi số lượng cuốn sách nữa?",
                 "Xác nhận",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1)
              == System.Windows.Forms.DialogResult.Yes)
                {
                    int id = 0;
                    Program.KetNoi();
                    Program.myReader = Program.ExecSqlDataReader("SELECT MAX(IDXB) as IDXB FROM XUATBAN");

                    if (Program.myReader != null)
                    {
                        Program.myReader.Read();
                        id = (int)Program.myReader["IDXB"];

                    }

                    for (int i = 0; i < soLuong; i++)
                    {
                        Program.KetNoi();
                        Program.ExecSqlNonQuery($"EXEC SP_THEM_CUON_SACH '1','{id}'");
                    }


                }
                else return;
            }
            
            gcXuatBan.Enabled = btnSua.Enabled = btnThem.Enabled = btnLamMoi.Enabled = lblSoLuong.Visible = txtSoLuong.Visible = txtGia.ReadOnly = txtKhoGiay.ReadOnly =  txtNamXB.ReadOnly = txtNhaXB.ReadOnly = txtSoTrang.ReadOnly = true;
            lblSoLuong.Visible = txtSoLuong.Visible =btnGhi.Enabled = btnHuy.Enabled = txtMaSach.Enabled =chkDiaCD.Enabled=  false;
            panelControl1.Enabled = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsXuatBan.CancelEdit();
            bdsXuatBan.Position = vitri;
            gcXuatBan.Enabled = btnSua.Enabled = btnThem.Enabled  = btnLamMoi.Enabled = txtGia.ReadOnly = txtKhoGiay.ReadOnly =  txtNamXB.ReadOnly = txtNhaXB.ReadOnly = txtSoTrang.ReadOnly = true;
            btnHuy.Enabled = btnGhi.Enabled = txtMaSach.Enabled =chkDiaCD.Enabled= false;
            panelControl1.Enabled = false;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                this.xUATBANTableAdapter.Connection.ConnectionString = Program.connstr;
                this.xUATBANTableAdapter.Fill(this.dS.XUATBAN);
                this.cUONSACHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cUONSACHTableAdapter.Fill(this.dS.CUONSACH);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload\n" + ex.Message);
            }
            
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc muốn đóng cửa sổ xuất bản?",
                 "Xác nhận",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1)
              == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void gcXuatBan_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtMaSach.SelectedValue != null)
            {
                txtMaSach2.Text = txtMaSach.SelectedValue.ToString().Trim();
            }
        }

        private void txtMaSach2_TextChanged(object sender, EventArgs e)
        {
            txtMaSach.SelectedValue = txtMaSach2.Text;
        }
    }
}