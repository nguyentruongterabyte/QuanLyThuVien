using QLDSV_TC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form CheckExist(Type ftype)
        {
            foreach(Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

       

       

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmDangNhap));
            if (frm != null)
            {
                frm.Activate();

            } else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }
        public void closeAllFormInFormMain()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }
        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất tài khoản khỏi thiết bị này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1)
                == System.Windows.Forms.DialogResult.Yes)
            {
                Program.DangXuat();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.MdiParent = this;
            f.Show();
        }

        public void HienThiMenu()
        {
            lbMa.Text = $"Mã: {Program.username}";
            lbHoTen.Text = $"Họ tên: {Program.mHoTen}";
            lbNhom.Text = $"Nhóm: {Program.mGroup}";
            btnDoiMK.Enabled = btnDangXuat.Enabled = true;


            // Phân quyền
            switch (Program.mGroup)
            {
                case "THUTHU":
                    ribBaoCaoTK.Visible = ribDanhMuc.Visible = true;
                    break;
                case "DOCGIA":
                    ribMuonTraSach.Visible = true;
                    break;
            }

        }

        private void btnDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmDocGia));
            if (frm != null)
            {
                frm.Activate();
            } else {
                frmDocGia f = new frmDocGia();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmSach));
            if (frm != null)
            {
                frm.Activate();
            } else
            {
                frmSach f = new frmSach();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTacGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmTacGia));
            if (frm != null)
            {
                frm.Activate();
            } else
            {
                frmTacGia f = new frmTacGia();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTapChi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = CheckExist(typeof(frmTapChi));
            if (frm != null)
            {
                frm.Activate();
            } else
            {
                frmTapChi f = new frmTapChi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnXuatBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmXuatBan));
            if (frm != null)
            {
                frm.Activate();
            } else
            {
                frmXuatBan f = new frmXuatBan();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btnMuonSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmMuonSach));
            if (frm != null)
            {
                frm.Activate();
            } else
            {
                frmMuonSach f = new frmMuonSach();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
