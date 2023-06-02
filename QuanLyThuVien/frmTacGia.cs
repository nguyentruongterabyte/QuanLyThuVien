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
    public partial class frmTacGia : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string maTacGia = "";
        public frmTacGia()
        {
            InitializeComponent();
        }

        private void tablePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.TACGIA' table. You can move, or remove it, as needed.
            this.tACGIATableAdapter.Connection.ConnectionString = Program.connstr;
            this.tACGIATableAdapter.Fill(this.dS.TACGIA);
            // TODO: This line of code loads data into the 'dS.CT_SACH' table. You can move, or remove it, as needed.
            this.cT_SACHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_SACHTableAdapter.Fill(this.dS.CT_SACH);

            if(bdsTacGia.Count ==0)
            {
                btnXoa.Enabled = false;
            }
            

        }

        private void thembtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsTacGia.Position;

            bdsTacGia.AddNew();

            gcTacGia.Visible = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;

            panelControl1.Enabled = btnHuy.Enabled = btnGhi.Enabled = true;
        }



        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Validator.isEmptyText(txtMaTacGia.Text))
            {
                MessageBox.Show("Không được để trống mã tác giả!");
                return;
            }
            if(Validator.isEmptyText(txtTenTacGia.Text))
            {
                MessageBox.Show("Không được để trống tên tác giả!");
                return;
            }    
            if (Validator.isEmptyText(txtNamSinh.Text))
            {
                MessageBox.Show("Không được để trống năm sinh!");
                return;
            }
            try
            {
                bdsTacGia.EndEdit();
                bdsTacGia.ResetCurrentItem();
                this.tACGIATableAdapter.Connection.ConnectionString = Program.connstr;
                this.tACGIATableAdapter.Update(this.dS.TACGIA);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ghi tác giả!\n" + ex.Message);
                return;
            }

            gcTacGia.Visible = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
            panelControl1.Visible = btnHuy.Enabled = btnGhi.Enabled = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTacGia.CancelEdit();
            bdsTacGia.Position = vitri;
            gcTacGia.Visible = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
            panelControl1.Visible = btnHuy.Enabled = btnGhi.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsTacGia.Position;

            bdsTacGia.AddNew();

            gcTacGia.Visible = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;

            panelControl1.Visible = btnHuy.Enabled = btnGhi.Enabled = true;

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsTacGia.Position;

            gcTacGia.Visible = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            panelControl1.Visible = btnGhi.Enabled = btnHuy.Enabled = true;

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (bdsCT_Sach.Count > 0)
            {
                MessageBox.Show("Không thể xoá tác giả vì có tác phẩm do tác giả này viết!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xoá tác giả này?", "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    maTacGia = ((DataRowView)bdsTacGia[bdsTacGia.Position])["MATACGIA"].ToString();
                    bdsTacGia.RemoveCurrent();
                    this.tACGIATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.tACGIATableAdapter.Update(this.dS.TACGIA);
                    btnLamMoi.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá tác giả!\n" + ex.Message);
                    this.tACGIATableAdapter.Fill(this.dS.TACGIA);
                    bdsTacGia.Position = bdsTacGia.Find("MATACGIA", maTacGia);
                    return;
                }
            }
            if (bdsTacGia.Count == 0)
            {
                btnXoa.Enabled = false;
            }
        }


        private void gcTacGia_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đóng cửa sổ tác giả?",
                 "Xác nhận",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1)
              == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}