using DevExpress.CodeParser;
using DevExpress.XtraReports.Design.GroupSort;
using DevExpress.XtraReports.UI;
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
                    ribBaoCaoTK.Visible = ribDanhMuc.Visible = ribSaoLuuPhucHoi.Visible = true;
                    btnTaoTaiKhoan.Enabled = true;
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

        private void btnTraSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmTraSach));
            if (frm != null)
            {
                frm.Activate();

            } else
            {
                frmTraSach f = new frmTraSach();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmSaoLuu));
            if (frm != null)
            {
                frm.Activate();
            } else
            {
                frmSaoLuu f = new frmSaoLuu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmPhucHoi));
            if (frm != null)
            {
                frm.Activate();
            } else
            {
                frmPhucHoi f = new frmPhucHoi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKyXuatBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmKyXB));
            if (frm != null)
            {
                frm.Activate();
            } else
            {
                frmKyXB f = new frmKyXB();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmMuonTapChi));
            if (frm != null)
            {
                frm.Activate();

            } else
            {
                frmMuonTapChi f = new frmMuonTapChi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpTopSach rp = new rpTopSach();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpTopDocGia_Sach rp = new rpTopDocGia_Sach();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpTopTapChi rp = new rpTopTapChi();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpTopDocGia_TapChi rp = new rpTopDocGia_TapChi();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();

        }

        private void btnTraTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmTraTapChi));
            if (frm != null)
            {
                frm.Activate();
            } else
            {
                frmTraTapChi f = new frmTraTapChi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDoiMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmDoiMK));
            if (frm != null)
            {
                frm.Activate();
            } else
            {
                frmDoiMK f = new frmDoiMK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmTaoLogin));
            if (frm != null)
            {
                frm.Activate();

            } else
            {
                frmTaoLogin f = new frmTaoLogin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpSachChuaTra rp = new rpSachChuaTra();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpTapChiChuaTra rp = new rpTapChiChuaTra();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void btnTroGiup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckExist(typeof(frmTroGiup));
            if (frm != null)
            {
                frm.Activate();
                
            } else
            {
                frmTroGiup f = new frmTroGiup();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
