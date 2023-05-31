namespace QuanLyThuVien
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDocGia = new DevExpress.XtraBars.BarButtonItem();
            this.btnSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnTacGia = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMK = new DevExpress.XtraBars.BarButtonItem();
            this.btnTapChi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatBan = new DevExpress.XtraBars.BarButtonItem();
            this.btnKyXuatBan = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribMuonTraSach = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribTimKiem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribBaoCaoTK = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbMa = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbHoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbNhom = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDocGia,
            this.btnSach,
            this.btnTacGia,
            this.barButtonItem1,
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnDoiMK,
            this.btnTapChi,
            this.btnXuatBan,
            this.btnKyXuatBan});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribDanhMuc,
            this.ribMuonTraSach,
            this.ribTimKiem,
            this.ribBaoCaoTK,
            this.ribbonPage6});
            this.ribbonControl1.Size = new System.Drawing.Size(975, 201);
            // 
            // btnDocGia
            // 
            this.btnDocGia.Caption = "Độc giả";
            this.btnDocGia.Id = 1;
            this.btnDocGia.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_read_online_48;
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDocGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDocGia_ItemClick);
            // 
            // btnSach
            // 
            this.btnSach.Caption = "Sách";
            this.btnSach.Id = 2;
            this.btnSach.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_books_48;
            this.btnSach.Name = "btnSach";
            this.btnSach.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnTacGia
            // 
            this.btnTacGia.Caption = "Tác giả";
            this.btnTacGia.Id = 3;
            this.btnTacGia.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_user_typing_using_typewriter_48;
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 6;
            this.btnDangNhap.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_login_48;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Dăng xuất";
            this.btnDangXuat.Enabled = false;
            this.btnDangXuat.Id = 7;
            this.btnDangXuat.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_logout_48;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Caption = "Đổi mật khẩu";
            this.btnDoiMK.Enabled = false;
            this.btnDoiMK.Id = 8;
            this.btnDoiMK.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_password_48;
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnTapChi
            // 
            this.btnTapChi.Caption = "Tạp chí";
            this.btnTapChi.Id = 9;
            this.btnTapChi.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_magazine_48;
            this.btnTapChi.Name = "btnTapChi";
            this.btnTapChi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnXuatBan
            // 
            this.btnXuatBan.Caption = "Xuất bản";
            this.btnXuatBan.Id = 10;
            this.btnXuatBan.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_publish_48;
            this.btnXuatBan.Name = "btnXuatBan";
            this.btnXuatBan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnKyXuatBan
            // 
            this.btnKyXuatBan.Caption = "Kỳ xuất bản";
            this.btnKyXuatBan.Id = 11;
            this.btnKyXuatBan.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_publish_48__1_;
            this.btnKyXuatBan.Name = "btnKyXuatBan";
            this.btnKyXuatBan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDoiMK);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribDanhMuc
            // 
            this.ribDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8});
            this.ribDanhMuc.Name = "ribDanhMuc";
            this.ribDanhMuc.Text = "Danh mục";
            this.ribDanhMuc.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDocGia);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTacGia);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnSach);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnXuatBan);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Quản lý sách";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnTapChi);
            this.ribbonPageGroup8.ItemLinks.Add(this.btnKyXuatBan);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Quản lý tạp chí";
            // 
            // ribMuonTraSach
            // 
            this.ribMuonTraSach.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribMuonTraSach.Name = "ribMuonTraSach";
            this.ribMuonTraSach.Text = "Mượn trả sách";
            this.ribMuonTraSach.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribTimKiem
            // 
            this.ribTimKiem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribTimKiem.Name = "ribTimKiem";
            this.ribTimKiem.Text = "Tìm kiếm";
            this.ribTimKiem.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribBaoCaoTK
            // 
            this.ribBaoCaoTK.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribBaoCaoTK.Name = "ribBaoCaoTK";
            this.ribBaoCaoTK.Text = "Báo cáo thống kê";
            this.ribBaoCaoTK.Visible = false;
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "Trợ giúp";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbMa,
            this.lbHoTen,
            this.lbNhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 467);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(975, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbMa
            // 
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(30, 17);
            this.lbMa.Text = "Mã: ";
            // 
            // lbHoTen
            // 
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(49, 17);
            this.lbHoTen.Text = "Họ tên: ";
            // 
            // lbNhom
            // 
            this.lbNhom.Name = "lbNhom";
            this.lbNhom.Size = new System.Drawing.Size(47, 17);
            this.lbNhom.Text = "Nhóm: ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 489);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản lý mượn sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDocGia;
        private DevExpress.XtraBars.BarButtonItem btnSach;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnTacGia;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        public DevExpress.XtraBars.BarButtonItem btnDangNhap;
        public DevExpress.XtraBars.BarButtonItem btnDangXuat;
        public DevExpress.XtraBars.BarButtonItem btnDoiMK;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribDanhMuc;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribMuonTraSach;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribTimKiem;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribBaoCaoTK;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel lbMa;
        public System.Windows.Forms.ToolStripStatusLabel lbHoTen;
        public System.Windows.Forms.ToolStripStatusLabel lbNhom;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnTapChi;
        private DevExpress.XtraBars.BarButtonItem btnXuatBan;
        private DevExpress.XtraBars.BarButtonItem btnKyXuatBan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
    }
}

