namespace QuanLyThuVien
{
    partial class frmKyXB
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
            System.Windows.Forms.Label lUONGNHAPLabel;
            System.Windows.Forms.Label lUONGTONLabel;
            System.Windows.Forms.Label mATAPCHILabel;
            System.Windows.Forms.Label lUONGTONLabel1;
            System.Windows.Forms.Label iDKILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKyXB));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.dS = new QuanLyThuVien.DS();
            this.bdsViewKyXB = new System.Windows.Forms.BindingSource(this.components);
            this.v_DANH_SACH_KY_XB_TAP_CHITableAdapter = new QuanLyThuVien.DSTableAdapters.V_DANH_SACH_KY_XB_TAP_CHITableAdapter();
            this.tableAdapterManager = new QuanLyThuVien.DSTableAdapters.TableAdapterManager();
            this.kYXBTableAdapter = new QuanLyThuVien.DSTableAdapters.KYXBTableAdapter();
            this.gcKyXB = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDKI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONGNHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENTAPCHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDINHKI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtIdKi = new DevExpress.XtraEditors.TextEdit();
            this.txtMaTapChi = new System.Windows.Forms.ComboBox();
            this.bdsTapChi = new System.Windows.Forms.BindingSource(this.components);
            this.txtLuongTon = new DevExpress.XtraEditors.TextEdit();
            this.txtLuongNhap = new DevExpress.XtraEditors.TextEdit();
            this.txtMaTapChi2 = new System.Windows.Forms.TextBox();
            this.bdsKyXB = new System.Windows.Forms.BindingSource(this.components);
            this.v_TAP_CHITableAdapter = new QuanLyThuVien.DSTableAdapters.V_TAP_CHITableAdapter();
            this.bdsCTMuonBao = new System.Windows.Forms.BindingSource(this.components);
            this.cT_MUONBAOTableAdapter = new QuanLyThuVien.DSTableAdapters.CT_MUONBAOTableAdapter();
            lUONGNHAPLabel = new System.Windows.Forms.Label();
            lUONGTONLabel = new System.Windows.Forms.Label();
            mATAPCHILabel = new System.Windows.Forms.Label();
            lUONGTONLabel1 = new System.Windows.Forms.Label();
            iDKILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsViewKyXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKyXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdKi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTapChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuongTon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuongNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKyXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTMuonBao)).BeginInit();
            this.SuspendLayout();
            // 
            // lUONGNHAPLabel
            // 
            lUONGNHAPLabel.AutoSize = true;
            lUONGNHAPLabel.Location = new System.Drawing.Point(33, 134);
            lUONGNHAPLabel.Name = "lUONGNHAPLabel";
            lUONGNHAPLabel.Size = new System.Drawing.Size(64, 13);
            lUONGNHAPLabel.TabIndex = 2;
            lUONGNHAPLabel.Text = "Lượng nhập";
            // 
            // lUONGTONLabel
            // 
            lUONGTONLabel.AutoSize = true;
            lUONGTONLabel.Location = new System.Drawing.Point(33, 195);
            lUONGTONLabel.Name = "lUONGTONLabel";
            lUONGTONLabel.Size = new System.Drawing.Size(56, 13);
            lUONGTONLabel.TabIndex = 4;
            lUONGTONLabel.Text = "Lượng tồn";
            // 
            // mATAPCHILabel
            // 
            mATAPCHILabel.AutoSize = true;
            mATAPCHILabel.Location = new System.Drawing.Point(41, 257);
            mATAPCHILabel.Name = "mATAPCHILabel";
            mATAPCHILabel.Size = new System.Drawing.Size(56, 13);
            mATAPCHILabel.TabIndex = 6;
            mATAPCHILabel.Text = "Mã tạp chí";
            // 
            // lUONGTONLabel1
            // 
            lUONGTONLabel1.AutoSize = true;
            lUONGTONLabel1.Location = new System.Drawing.Point(201, 195);
            lUONGTONLabel1.Name = "lUONGTONLabel1";
            lUONGTONLabel1.Size = new System.Drawing.Size(0, 13);
            lUONGTONLabel1.TabIndex = 8;
            // 
            // iDKILabel
            // 
            iDKILabel.AutoSize = true;
            iDKILabel.Location = new System.Drawing.Point(150, 50);
            iDKILabel.Name = "iDKILabel";
            iDKILabel.Size = new System.Drawing.Size(32, 13);
            iDKILabel.TabIndex = 10;
            iDKILabel.Text = "IDKI:";
            iDKILabel.Visible = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnGhi,
            this.btnPhucHoi,
            this.btnHuy,
            this.btnLamMoi,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(347, 603);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Enabled = false;
            this.btnHuy.Id = 5;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.LargeImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Id = 6;
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.LargeImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1384, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 754);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1384, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 715);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1384, 39);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 715);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsViewKyXB
            // 
            this.bdsViewKyXB.DataMember = "V_DANH_SACH_KY_XB_TAP_CHI";
            this.bdsViewKyXB.DataSource = this.dS;
            // 
            // v_DANH_SACH_KY_XB_TAP_CHITableAdapter
            // 
            this.v_DANH_SACH_KY_XB_TAP_CHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_MUONBAOTableAdapter = null;
            this.tableAdapterManager.CT_MUONSACHTableAdapter = null;
            this.tableAdapterManager.CT_SACHTableAdapter = null;
            this.tableAdapterManager.CUONSACHTableAdapter = null;
            this.tableAdapterManager.DOCGIATableAdapter = null;
            this.tableAdapterManager.KYXBTableAdapter = this.kYXBTableAdapter;
            this.tableAdapterManager.SACHTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.TAILIEUTableAdapter = null;
            this.tableAdapterManager.TAPCHITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyThuVien.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XUATBANTableAdapter = null;
            // 
            // kYXBTableAdapter
            // 
            this.kYXBTableAdapter.ClearBeforeFill = true;
            // 
            // gcKyXB
            // 
            this.gcKyXB.DataSource = this.bdsViewKyXB;
            this.gcKyXB.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcKyXB.Location = new System.Drawing.Point(0, 39);
            this.gcKyXB.MainView = this.gridView1;
            this.gcKyXB.MenuManager = this.barManager1;
            this.gcKyXB.Name = "gcKyXB";
            this.gcKyXB.Size = new System.Drawing.Size(763, 715);
            this.gcKyXB.TabIndex = 5;
            this.gcKyXB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDKI,
            this.colLUONGNHAP,
            this.colLUONGTON,
            this.colTENTAPCHI,
            this.colNXB,
            this.colDINHKI});
            this.gridView1.GridControl = this.gcKyXB;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colIDKI
            // 
            this.colIDKI.Caption = "ID Kỳ";
            this.colIDKI.FieldName = "IDKI";
            this.colIDKI.Name = "colIDKI";
            this.colIDKI.Visible = true;
            this.colIDKI.VisibleIndex = 0;
            // 
            // colLUONGNHAP
            // 
            this.colLUONGNHAP.Caption = "Lượng nhập";
            this.colLUONGNHAP.FieldName = "LUONGNHAP";
            this.colLUONGNHAP.Name = "colLUONGNHAP";
            this.colLUONGNHAP.Visible = true;
            this.colLUONGNHAP.VisibleIndex = 1;
            // 
            // colLUONGTON
            // 
            this.colLUONGTON.Caption = "Lượng tồn";
            this.colLUONGTON.FieldName = "LUONGTON";
            this.colLUONGTON.Name = "colLUONGTON";
            this.colLUONGTON.Visible = true;
            this.colLUONGTON.VisibleIndex = 2;
            // 
            // colTENTAPCHI
            // 
            this.colTENTAPCHI.Caption = "Tên tạp chí";
            this.colTENTAPCHI.FieldName = "TENTAPCHI";
            this.colTENTAPCHI.Name = "colTENTAPCHI";
            this.colTENTAPCHI.Visible = true;
            this.colTENTAPCHI.VisibleIndex = 3;
            // 
            // colNXB
            // 
            this.colNXB.Caption = "NXB";
            this.colNXB.FieldName = "NXB";
            this.colNXB.Name = "colNXB";
            this.colNXB.Visible = true;
            this.colNXB.VisibleIndex = 4;
            // 
            // colDINHKI
            // 
            this.colDINHKI.Caption = "Định kỳ";
            this.colDINHKI.FieldName = "DINHKI";
            this.colDINHKI.Name = "colDINHKI";
            this.colDINHKI.Visible = true;
            this.colDINHKI.VisibleIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(763, 39);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(621, 715);
            this.panelControl1.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(iDKILabel);
            this.groupControl1.Controls.Add(this.txtIdKi);
            this.groupControl1.Controls.Add(this.txtMaTapChi);
            this.groupControl1.Controls.Add(lUONGTONLabel1);
            this.groupControl1.Controls.Add(this.txtLuongTon);
            this.groupControl1.Controls.Add(this.txtLuongNhap);
            this.groupControl1.Controls.Add(mATAPCHILabel);
            this.groupControl1.Controls.Add(lUONGTONLabel);
            this.groupControl1.Controls.Add(lUONGNHAPLabel);
            this.groupControl1.Controls.Add(this.txtMaTapChi2);
            this.groupControl1.Enabled = false;
            this.groupControl1.Location = new System.Drawing.Point(127, 58);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(410, 310);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin kỳ xuất bản";
            // 
            // txtIdKi
            // 
            this.txtIdKi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsViewKyXB, "IDKI", true));
            this.txtIdKi.Location = new System.Drawing.Point(188, 47);
            this.txtIdKi.MenuManager = this.barManager1;
            this.txtIdKi.Name = "txtIdKi";
            this.txtIdKi.Size = new System.Drawing.Size(100, 28);
            this.txtIdKi.TabIndex = 11;
            this.txtIdKi.Visible = false;
            // 
            // txtMaTapChi
            // 
            this.txtMaTapChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsViewKyXB, "TENTAPCHI", true));
            this.txtMaTapChi.DataSource = this.bdsTapChi;
            this.txtMaTapChi.DisplayMember = "TENTAPCHI";
            this.txtMaTapChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaTapChi.FormattingEnabled = true;
            this.txtMaTapChi.Location = new System.Drawing.Point(174, 254);
            this.txtMaTapChi.Name = "txtMaTapChi";
            this.txtMaTapChi.Size = new System.Drawing.Size(216, 21);
            this.txtMaTapChi.TabIndex = 10;
            this.txtMaTapChi.ValueMember = "MATAPCHI";
            this.txtMaTapChi.SelectedIndexChanged += new System.EventHandler(this.txtMaTapChi_SelectedIndexChanged);
            // 
            // bdsTapChi
            // 
            this.bdsTapChi.DataMember = "V_TAP_CHI";
            this.bdsTapChi.DataSource = this.dS;
            // 
            // txtLuongTon
            // 
            this.txtLuongTon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsViewKyXB, "LUONGTON", true));
            this.txtLuongTon.Enabled = false;
            this.txtLuongTon.Location = new System.Drawing.Point(174, 188);
            this.txtLuongTon.MenuManager = this.barManager1;
            this.txtLuongTon.Name = "txtLuongTon";
            this.txtLuongTon.Size = new System.Drawing.Size(216, 28);
            this.txtLuongTon.TabIndex = 9;
            this.txtLuongTon.EditValueChanged += new System.EventHandler(this.txtLuongTon2_EditValueChanged);
            this.txtLuongTon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuongTon2_KeyPress);
            // 
            // txtLuongNhap
            // 
            this.txtLuongNhap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsViewKyXB, "LUONGNHAP", true));
            this.txtLuongNhap.Location = new System.Drawing.Point(174, 128);
            this.txtLuongNhap.MenuManager = this.barManager1;
            this.txtLuongNhap.Name = "txtLuongNhap";
            this.txtLuongNhap.Size = new System.Drawing.Size(216, 28);
            this.txtLuongNhap.TabIndex = 8;
            this.txtLuongNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuongNhap2_KeyPress);
            this.txtLuongNhap.Leave += new System.EventHandler(this.txtLuongNhap2_EditValueChanged);
            // 
            // txtMaTapChi2
            // 
            this.txtMaTapChi2.Location = new System.Drawing.Point(214, 254);
            this.txtMaTapChi2.Name = "txtMaTapChi2";
            this.txtMaTapChi2.Size = new System.Drawing.Size(100, 21);
            this.txtMaTapChi2.TabIndex = 12;
            this.txtMaTapChi2.TextChanged += new System.EventHandler(this.txtMaSach_TextChanged);
            // 
            // bdsKyXB
            // 
            this.bdsKyXB.DataMember = "KYXB";
            this.bdsKyXB.DataSource = this.dS;
            // 
            // v_TAP_CHITableAdapter
            // 
            this.v_TAP_CHITableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTMuonBao
            // 
            this.bdsCTMuonBao.DataMember = "FK_CT_MUONBAO_KYXB";
            this.bdsCTMuonBao.DataSource = this.bdsKyXB;
            // 
            // cT_MUONBAOTableAdapter
            // 
            this.cT_MUONBAOTableAdapter.ClearBeforeFill = true;
            // 
            // frmKyXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 754);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcKyXB);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmKyXB";
            this.Text = "Kỳ xuất bản tạp chí";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKyXB_FormClosing);
            this.Load += new System.EventHandler(this.frmKyXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsViewKyXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKyXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdKi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTapChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuongTon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuongNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKyXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTMuonBao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private System.Windows.Forms.BindingSource bdsViewKyXB;
        private DS dS;
        private DSTableAdapters.V_DANH_SACH_KY_XB_TAP_CHITableAdapter v_DANH_SACH_KY_XB_TAP_CHITableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcKyXB;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDKI;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONGNHAP;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONGTON;
        private DevExpress.XtraGrid.Columns.GridColumn colTENTAPCHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNXB;
        private DevExpress.XtraGrid.Columns.GridColumn colDINHKI;
        private DSTableAdapters.KYXBTableAdapter kYXBTableAdapter;
        private System.Windows.Forms.BindingSource bdsKyXB;
        private System.Windows.Forms.ComboBox txtMaTapChi;
        private DevExpress.XtraEditors.TextEdit txtLuongTon;
        private DevExpress.XtraEditors.TextEdit txtLuongNhap;
        private System.Windows.Forms.BindingSource bdsTapChi;
        private DSTableAdapters.V_TAP_CHITableAdapter v_TAP_CHITableAdapter;
        private System.Windows.Forms.BindingSource bdsCTMuonBao;
        private DSTableAdapters.CT_MUONBAOTableAdapter cT_MUONBAOTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtIdKi;
        private System.Windows.Forms.TextBox txtMaTapChi2;
    }
}