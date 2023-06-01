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
    public partial class frmDocGia : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string maDocGia = "";

        public frmDocGia()
        {
            InitializeComponent();
        }

        private void dOCGIABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDocGia.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;  
            // TODO: This line of code loads data into the 'dS.DOCGIA' table. You can move, or remove it, as needed.
            this.dOCGIATableAdapter.Fill(this.dS.DOCGIA);
            // TODO: This line of code loads data into the 'dS.CT_MUONSACH' table. You can move, or remove it, as needed.
            this.cT_MUONSACHTableAdapter.Fill(this.dS.CT_MUONSACH);
            // TODO: This line of code loads data into the 'dS.CT_MUONBAO' table. You can move, or remove it, as needed.
            this.cT_MUONBAOTableAdapter.Fill(this.dS.CT_MUONBAO);

            if (bdsDocGia.Count == 0)
            {
                btnXoa.Enabled = false;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsDocGia.Position;
            
            bdsDocGia.AddNew();
            
            gcDocGia.Visible = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;

            groupControl1.Enabled = btnHuy.Enabled = btnGhi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Validator.isEmptyText(txtMaDocGia.Text))
            {
                MessageBox.Show("Không được để trống mã độc giả!");
                return;
            }
            if (Validator.isEmptyText(txtTen.Text))
            {
                MessageBox.Show("Không được để trống tên độc giả!");
                return;
            }

            if (Validator.isEmptyText(txtNgheNghiep.Text))
            {
                MessageBox.Show("Không được để trống nghề nghiệp!");
                return;
            }

            if (Validator.isEmptyText(DateNgayCap.Text))
            {
                MessageBox.Show("Không được để trống ngày cấp!");
                return;
            }

            try
            {
                bdsDocGia.EndEdit();
                bdsDocGia.ResetCurrentItem();
                this.dOCGIATableAdapter.Connection.ConnectionString = Program.connstr;
                this.dOCGIATableAdapter.Update(this.dS.DOCGIA);
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi độc giả!\n" + ex.Message);
                
                return;
            }

            gcDocGia.Visible = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
            groupControl1.Enabled = btnHuy.Enabled = btnGhi.Enabled = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsDocGia.CancelEdit();
            bdsDocGia.Position = vitri;
            gcDocGia.Visible = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;            
            groupControl1.Enabled = btnHuy.Enabled = btnGhi.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTMuonSach.Count > 0)
            {
                MessageBox.Show("Không thể xóa độc giả vì đã có phiếu mượn sách!");
                return;
            }
            if (bdsCTMuonBao.Count > 0)
            {
                MessageBox.Show("Không thể xóa độc giả vì đã có phiếu mượn báo!");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa độc giả này?", "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1)
                == System.Windows.Forms.DialogResult.Yes)
            { 
                try
                {
                    maDocGia = ((DataRowView)bdsDocGia[bdsDocGia.Position])["MADOCGIA"].ToString();
                    bdsDocGia.RemoveCurrent();

                    this.dOCGIATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dOCGIATableAdapter.Update(this.dS.DOCGIA);
                    btnLamMoi.PerformClick();
                } catch (Exception ex) {
                    MessageBox.Show("Lỗi xóa độc giả!\n" + ex.Message);
                    this.dOCGIATableAdapter.Fill(this.dS.DOCGIA);
                    bdsDocGia.Position = bdsDocGia.Find("MADOCGIA", maDocGia);
                    return;
                }
            }
            if (bdsDocGia.Count == 0)
            {
                btnXoa.Enabled = false;
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsDocGia.Position;

            gcDocGia.Visible = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;

            groupControl1.Enabled = btnHuy.Enabled = btnGhi.Enabled = true;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.dOCGIATableAdapter.Connection.ConnectionString = Program.connstr;
                this.dOCGIATableAdapter.Fill(this.dS.DOCGIA);
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload\n" + ex.Message);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đóng cửa sổ độc giả?",
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
