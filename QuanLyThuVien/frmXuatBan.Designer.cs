
namespace QuanLyThuVien
{
    partial class frmXuatBan
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
            System.Windows.Forms.Label nAMXBLabel;
            System.Windows.Forms.Label kHOGIAYLabel;
            System.Windows.Forms.Label nHAXBLabel;
            System.Windows.Forms.Label dIACDLabel;
            System.Windows.Forms.Label txt;
            System.Windows.Forms.Label gIALabel;
            System.Windows.Forms.Label mASACHLabel;
            System.Windows.Forms.Label lANXBLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatBan));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
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
            this.bdsXuatBan = new System.Windows.Forms.BindingSource(this.components);
            this.xUATBANTableAdapter = new QuanLyThuVien.DSTableAdapters.XUATBANTableAdapter();
            this.tableAdapterManager = new QuanLyThuVien.DSTableAdapters.TableAdapterManager();
            this.gcXuatBan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLANXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAMXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHOGIAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTRANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHAXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtLanXB = new DevExpress.XtraEditors.TextEdit();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSach = new System.Windows.Forms.ComboBox();
            this.bdsvSach = new System.Windows.Forms.BindingSource(this.components);
            this.txtGia = new DevExpress.XtraEditors.TextEdit();
            this.txtSoTrang = new DevExpress.XtraEditors.TextEdit();
            this.lblSoLuong = new DevExpress.XtraEditors.LabelControl();
            this.chkDiaCD = new DevExpress.XtraEditors.CheckEdit();
            this.txtNhaXB = new DevExpress.XtraEditors.TextEdit();
            this.txtKhoGiay = new DevExpress.XtraEditors.TextEdit();
            this.txtNamXB = new DevExpress.XtraEditors.DateEdit();
            this.txtMaSach2 = new System.Windows.Forms.TextBox();
            this.bdsCuonSach = new System.Windows.Forms.BindingSource(this.components);
            this.cUONSACHTableAdapter = new QuanLyThuVien.DSTableAdapters.CUONSACHTableAdapter();
            this.v_SachTableAdapter = new QuanLyThuVien.DSTableAdapters.V_SachTableAdapter();
            nAMXBLabel = new System.Windows.Forms.Label();
            kHOGIAYLabel = new System.Windows.Forms.Label();
            nHAXBLabel = new System.Windows.Forms.Label();
            dIACDLabel = new System.Windows.Forms.Label();
            txt = new System.Windows.Forms.Label();
            gIALabel = new System.Windows.Forms.Label();
            mASACHLabel = new System.Windows.Forms.Label();
            lANXBLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXuatBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcXuatBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLanXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDiaCD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoGiay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamXB.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCuonSach)).BeginInit();
            this.SuspendLayout();
            // 
            // nAMXBLabel
            // 
            nAMXBLabel.AutoSize = true;
            nAMXBLabel.Location = new System.Drawing.Point(63, 54);
            nAMXBLabel.Name = "nAMXBLabel";
            nAMXBLabel.Size = new System.Drawing.Size(74, 13);
            nAMXBLabel.TabIndex = 0;
            nAMXBLabel.Text = "Năm xuất bản";
            // 
            // kHOGIAYLabel
            // 
            kHOGIAYLabel.AutoSize = true;
            kHOGIAYLabel.Location = new System.Drawing.Point(63, 100);
            kHOGIAYLabel.Name = "kHOGIAYLabel";
            kHOGIAYLabel.Size = new System.Drawing.Size(52, 13);
            kHOGIAYLabel.TabIndex = 2;
            kHOGIAYLabel.Text = "Khổ giấy:";
            // 
            // nHAXBLabel
            // 
            nHAXBLabel.AutoSize = true;
            nHAXBLabel.Location = new System.Drawing.Point(414, 100);
            nHAXBLabel.Name = "nHAXBLabel";
            nHAXBLabel.Size = new System.Drawing.Size(76, 13);
            nHAXBLabel.TabIndex = 6;
            nHAXBLabel.Text = "Nhà Xuất Bản:";
            // 
            // dIACDLabel
            // 
            dIACDLabel.AutoSize = true;
            dIACDLabel.Location = new System.Drawing.Point(63, 195);
            dIACDLabel.Name = "dIACDLabel";
            dIACDLabel.Size = new System.Drawing.Size(0, 13);
            dIACDLabel.TabIndex = 10;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Location = new System.Drawing.Point(414, 54);
            txt.Name = "txt";
            txt.Size = new System.Drawing.Size(55, 13);
            txt.TabIndex = 15;
            txt.Text = "Số trang: ";
            // 
            // gIALabel
            // 
            gIALabel.AutoSize = true;
            gIALabel.Location = new System.Drawing.Point(63, 150);
            gIALabel.Name = "gIALabel";
            gIALabel.Size = new System.Drawing.Size(29, 13);
            gIALabel.TabIndex = 16;
            gIALabel.Text = "Giá :";
            // 
            // mASACHLabel
            // 
            mASACHLabel.AutoSize = true;
            mASACHLabel.Location = new System.Drawing.Point(414, 150);
            mASACHLabel.Name = "mASACHLabel";
            mASACHLabel.Size = new System.Drawing.Size(50, 13);
            mASACHLabel.TabIndex = 12;
            mASACHLabel.Text = "Mã sách:";
            // 
            // lANXBLabel
            // 
            lANXBLabel.AutoSize = true;
            lANXBLabel.Location = new System.Drawing.Point(63, 192);
            lANXBLabel.Name = "lANXBLabel";
            lANXBLabel.Size = new System.Drawing.Size(70, 13);
            lANXBLabel.TabIndex = 23;
            lANXBLabel.Text = "Lần xuất bản";
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
            // bdsXuatBan
            // 
            this.bdsXuatBan.DataMember = "XUATBAN";
            this.bdsXuatBan.DataSource = this.dS;
            // 
            // xUATBANTableAdapter
            // 
            this.xUATBANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_MUONBAOTableAdapter = null;
            this.tableAdapterManager.CT_MUONSACHTableAdapter = null;
            this.tableAdapterManager.CT_SACHTableAdapter = null;
            this.tableAdapterManager.CUONSACHTableAdapter = null;
            this.tableAdapterManager.DOCGIATableAdapter = null;
            this.tableAdapterManager.KYXBTableAdapter = null;
            this.tableAdapterManager.SACHTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.TAILIEUTableAdapter = null;
            this.tableAdapterManager.TAPCHITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyThuVien.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XUATBANTableAdapter = this.xUATBANTableAdapter;
            // 
            // gcXuatBan
            // 
            this.gcXuatBan.DataSource = this.bdsXuatBan;
            this.gcXuatBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcXuatBan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            gridLevelNode2.RelationName = "FK_CT_MUONSACH_CUONSACH";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            gridLevelNode1.RelationName = "FK_CUONSACH_XUATBAN";
            this.gcXuatBan.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcXuatBan.Location = new System.Drawing.Point(0, 39);
            this.gcXuatBan.MainView = this.gridView1;
            this.gcXuatBan.MenuManager = this.barManager1;
            this.gcXuatBan.Name = "gcXuatBan";
            this.gcXuatBan.Size = new System.Drawing.Size(1384, 265);
            this.gcXuatBan.TabIndex = 5;
            this.gcXuatBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcXuatBan.Click += new System.EventHandler(this.gcXuatBan_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDXB,
            this.colLANXB,
            this.colNAMXB,
            this.colKHOGIAY,
            this.colSOTRANG,
            this.colNHAXB,
            this.colGIA,
            this.colDIACD,
            this.colMASACH});
            this.gridView1.GridControl = this.gcXuatBan;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colIDXB
            // 
            this.colIDXB.Caption = "ID xuất bản";
            this.colIDXB.FieldName = "IDXB";
            this.colIDXB.MinWidth = 25;
            this.colIDXB.Name = "colIDXB";
            this.colIDXB.Visible = true;
            this.colIDXB.VisibleIndex = 0;
            this.colIDXB.Width = 157;
            // 
            // colLANXB
            // 
            this.colLANXB.Caption = "Lần xuất bản";
            this.colLANXB.FieldName = "LANXB";
            this.colLANXB.MinWidth = 25;
            this.colLANXB.Name = "colLANXB";
            this.colLANXB.Visible = true;
            this.colLANXB.VisibleIndex = 1;
            this.colLANXB.Width = 209;
            // 
            // colNAMXB
            // 
            this.colNAMXB.Caption = "Năm xuất bản";
            this.colNAMXB.FieldName = "NAMXB";
            this.colNAMXB.MinWidth = 25;
            this.colNAMXB.Name = "colNAMXB";
            this.colNAMXB.Visible = true;
            this.colNAMXB.VisibleIndex = 2;
            this.colNAMXB.Width = 209;
            // 
            // colKHOGIAY
            // 
            this.colKHOGIAY.Caption = "Khổ giấy";
            this.colKHOGIAY.FieldName = "KHOGIAY";
            this.colKHOGIAY.MinWidth = 25;
            this.colKHOGIAY.Name = "colKHOGIAY";
            this.colKHOGIAY.Visible = true;
            this.colKHOGIAY.VisibleIndex = 3;
            this.colKHOGIAY.Width = 209;
            // 
            // colSOTRANG
            // 
            this.colSOTRANG.Caption = "Số trang";
            this.colSOTRANG.FieldName = "SOTRANG";
            this.colSOTRANG.MinWidth = 25;
            this.colSOTRANG.Name = "colSOTRANG";
            this.colSOTRANG.Visible = true;
            this.colSOTRANG.VisibleIndex = 4;
            this.colSOTRANG.Width = 209;
            // 
            // colNHAXB
            // 
            this.colNHAXB.Caption = "Nhà xuất bản";
            this.colNHAXB.FieldName = "NHAXB";
            this.colNHAXB.MinWidth = 25;
            this.colNHAXB.Name = "colNHAXB";
            this.colNHAXB.Visible = true;
            this.colNHAXB.VisibleIndex = 6;
            this.colNHAXB.Width = 209;
            // 
            // colGIA
            // 
            this.colGIA.Caption = "Giá";
            this.colGIA.FieldName = "GIA";
            this.colGIA.MinWidth = 25;
            this.colGIA.Name = "colGIA";
            this.colGIA.Visible = true;
            this.colGIA.VisibleIndex = 5;
            this.colGIA.Width = 209;
            // 
            // colDIACD
            // 
            this.colDIACD.Caption = "Đĩa CD";
            this.colDIACD.FieldName = "DIACD";
            this.colDIACD.MinWidth = 25;
            this.colDIACD.Name = "colDIACD";
            this.colDIACD.Visible = true;
            this.colDIACD.VisibleIndex = 7;
            this.colDIACD.Width = 209;
            // 
            // colMASACH
            // 
            this.colMASACH.Caption = "Mã sách";
            this.colMASACH.FieldName = "MASACH";
            this.colMASACH.MinWidth = 25;
            this.colMASACH.Name = "colMASACH";
            this.colMASACH.Visible = true;
            this.colMASACH.VisibleIndex = 8;
            this.colMASACH.Width = 222;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 304);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1384, 450);
            this.panelControl1.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(lANXBLabel);
            this.groupControl1.Controls.Add(this.txtLanXB);
            this.groupControl1.Controls.Add(this.txtSoLuong);
            this.groupControl1.Controls.Add(this.txtMaSach);
            this.groupControl1.Controls.Add(gIALabel);
            this.groupControl1.Controls.Add(this.txtGia);
            this.groupControl1.Controls.Add(txt);
            this.groupControl1.Controls.Add(this.txtSoTrang);
            this.groupControl1.Controls.Add(this.lblSoLuong);
            this.groupControl1.Controls.Add(mASACHLabel);
            this.groupControl1.Controls.Add(dIACDLabel);
            this.groupControl1.Controls.Add(this.chkDiaCD);
            this.groupControl1.Controls.Add(nHAXBLabel);
            this.groupControl1.Controls.Add(this.txtNhaXB);
            this.groupControl1.Controls.Add(kHOGIAYLabel);
            this.groupControl1.Controls.Add(this.txtKhoGiay);
            this.groupControl1.Controls.Add(nAMXBLabel);
            this.groupControl1.Controls.Add(this.txtNamXB);
            this.groupControl1.Controls.Add(this.txtMaSach2);
            this.groupControl1.Location = new System.Drawing.Point(309, 17);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(692, 240);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin xuất bản";
            // 
            // txtLanXB
            // 
            this.txtLanXB.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsXuatBan, "LANXB", true));
            this.txtLanXB.Location = new System.Drawing.Point(173, 185);
            this.txtLanXB.MenuManager = this.barManager1;
            this.txtLanXB.Name = "txtLanXB";
            this.txtLanXB.Size = new System.Drawing.Size(35, 28);
            this.txtLanXB.TabIndex = 24;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(533, 188);
            this.txtSoLuong.MenuManager = this.barManager1;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(125, 28);
            this.txtSoLuong.TabIndex = 22;
            // 
            // txtMaSach
            // 
            this.txtMaSach.DataSource = this.bdsvSach;
            this.txtMaSach.DisplayMember = "TENSACH";
            this.txtMaSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaSach.FormattingEnabled = true;
            this.txtMaSach.Location = new System.Drawing.Point(533, 147);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(121, 21);
            this.txtMaSach.TabIndex = 19;
            this.txtMaSach.ValueMember = "MASACH";
            this.txtMaSach.SelectedIndexChanged += new System.EventHandler(this.txtMaSach_SelectedIndexChanged);
            // 
            // bdsvSach
            // 
            this.bdsvSach.DataMember = "V_Sach";
            this.bdsvSach.DataSource = this.dS;
            // 
            // txtGia
            // 
            this.txtGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsXuatBan, "GIA", true));
            this.txtGia.Location = new System.Drawing.Point(173, 141);
            this.txtGia.MenuManager = this.barManager1;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(135, 28);
            this.txtGia.TabIndex = 17;
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsXuatBan, "SOTRANG", true));
            this.txtSoTrang.Location = new System.Drawing.Point(533, 45);
            this.txtSoTrang.MenuManager = this.barManager1;
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.Size = new System.Drawing.Size(125, 28);
            this.txtSoTrang.TabIndex = 16;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Location = new System.Drawing.Point(417, 197);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(46, 13);
            this.lblSoLuong.TabIndex = 14;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // chkDiaCD
            // 
            this.chkDiaCD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsXuatBan, "DIACD", true));
            this.chkDiaCD.Location = new System.Drawing.Point(233, 188);
            this.chkDiaCD.MenuManager = this.barManager1;
            this.chkDiaCD.Name = "chkDiaCD";
            this.chkDiaCD.Properties.Caption = " Có đĩa CD";
            this.chkDiaCD.Size = new System.Drawing.Size(94, 22);
            this.chkDiaCD.TabIndex = 11;
            // 
            // txtNhaXB
            // 
            this.txtNhaXB.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsXuatBan, "NHAXB", true));
            this.txtNhaXB.Location = new System.Drawing.Point(533, 91);
            this.txtNhaXB.MenuManager = this.barManager1;
            this.txtNhaXB.Name = "txtNhaXB";
            this.txtNhaXB.Size = new System.Drawing.Size(125, 28);
            this.txtNhaXB.TabIndex = 7;
            // 
            // txtKhoGiay
            // 
            this.txtKhoGiay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsXuatBan, "KHOGIAY", true));
            this.txtKhoGiay.Location = new System.Drawing.Point(173, 91);
            this.txtKhoGiay.MenuManager = this.barManager1;
            this.txtKhoGiay.Name = "txtKhoGiay";
            this.txtKhoGiay.Size = new System.Drawing.Size(135, 28);
            this.txtKhoGiay.TabIndex = 3;
            // 
            // txtNamXB
            // 
            this.txtNamXB.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsXuatBan, "NAMXB", true));
            this.txtNamXB.EditValue = null;
            this.txtNamXB.Location = new System.Drawing.Point(173, 45);
            this.txtNamXB.MenuManager = this.barManager1;
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNamXB.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNamXB.Size = new System.Drawing.Size(135, 28);
            this.txtNamXB.TabIndex = 1;
            // 
            // txtMaSach2
            // 
            this.txtMaSach2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsXuatBan, "MASACH", true));
            this.txtMaSach2.Location = new System.Drawing.Point(533, 147);
            this.txtMaSach2.Name = "txtMaSach2";
            this.txtMaSach2.Size = new System.Drawing.Size(100, 21);
            this.txtMaSach2.TabIndex = 23;
            this.txtMaSach2.TextChanged += new System.EventHandler(this.txtMaSach2_TextChanged);
            // 
            // bdsCuonSach
            // 
            this.bdsCuonSach.DataMember = "FK_CUONSACH_XUATBAN";
            this.bdsCuonSach.DataSource = this.bdsXuatBan;
            // 
            // cUONSACHTableAdapter
            // 
            this.cUONSACHTableAdapter.ClearBeforeFill = true;
            // 
            // v_SachTableAdapter
            // 
            this.v_SachTableAdapter.ClearBeforeFill = true;
            // 
            // frmXuatBan
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1384, 754);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcXuatBan);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXuatBan";
            this.Text = "Xuất bản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXuatBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXuatBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcXuatBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLanXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDiaCD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoGiay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamXB.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCuonSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
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
        private System.Windows.Forms.BindingSource bdsXuatBan;
        private DS dS;
        private DSTableAdapters.XUATBANTableAdapter xUATBANTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcXuatBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDXB;
        private DevExpress.XtraGrid.Columns.GridColumn colLANXB;
        private DevExpress.XtraGrid.Columns.GridColumn colNAMXB;
        private DevExpress.XtraGrid.Columns.GridColumn colKHOGIAY;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTRANG;
        private DevExpress.XtraGrid.Columns.GridColumn colNHAXB;
        private DevExpress.XtraGrid.Columns.GridColumn colGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACD;
        private DevExpress.XtraGrid.Columns.GridColumn colMASACH;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chkDiaCD;
        private DevExpress.XtraEditors.TextEdit txtNhaXB;
        private DevExpress.XtraEditors.TextEdit txtKhoGiay;
        private DevExpress.XtraEditors.DateEdit txtNamXB;
        private System.Windows.Forms.BindingSource bdsCuonSach;
        private DSTableAdapters.CUONSACHTableAdapter cUONSACHTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtGia;
        private DevExpress.XtraEditors.TextEdit txtSoTrang;
        public DevExpress.XtraEditors.LabelControl lblSoLuong;
        private System.Windows.Forms.BindingSource bdsvSach;
        private DSTableAdapters.V_SachTableAdapter v_SachTableAdapter;
        private System.Windows.Forms.ComboBox txtMaSach;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private System.Windows.Forms.TextBox txtMaSach2;
        private DevExpress.XtraEditors.TextEdit txtLanXB;
    }
}