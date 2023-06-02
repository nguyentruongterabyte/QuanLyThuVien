namespace QuanLyThuVien
{
    partial class frmTapChi
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
            System.Windows.Forms.Label mATAPCHILabel;
            System.Windows.Forms.Label tENTAPCHILabel;
            System.Windows.Forms.Label nAMPHATHANHLabel;
            System.Windows.Forms.Label dINHKILabel;
            System.Windows.Forms.Label nXBLabel;
            System.Windows.Forms.Label mATLLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTapChi));
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
            this.bdsTapChi = new System.Windows.Forms.BindingSource(this.components);
            this.tAPCHITableAdapter = new QuanLyThuVien.DSTableAdapters.TAPCHITableAdapter();
            this.tableAdapterManager = new QuanLyThuVien.DSTableAdapters.TableAdapterManager();
            this.gcTapChi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMATAPCHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENTAPCHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAMPHATHANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDINHKI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaTL = new DevExpress.XtraEditors.TextEdit();
            this.txtNXB = new DevExpress.XtraEditors.TextEdit();
            this.dateNamPH = new DevExpress.XtraEditors.DateEdit();
            this.txtTenTC = new DevExpress.XtraEditors.TextEdit();
            this.txtMaTC = new DevExpress.XtraEditors.TextEdit();
            this.cmbDinhKy = new System.Windows.Forms.ComboBox();
            mATAPCHILabel = new System.Windows.Forms.Label();
            tENTAPCHILabel = new System.Windows.Forms.Label();
            nAMPHATHANHLabel = new System.Windows.Forms.Label();
            dINHKILabel = new System.Windows.Forms.Label();
            nXBLabel = new System.Windows.Forms.Label();
            mATLLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTapChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTapChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamPH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamPH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mATAPCHILabel
            // 
            mATAPCHILabel.AutoSize = true;
            mATAPCHILabel.Location = new System.Drawing.Point(70, 59);
            mATAPCHILabel.Name = "mATAPCHILabel";
            mATAPCHILabel.Size = new System.Drawing.Size(56, 13);
            mATAPCHILabel.TabIndex = 0;
            mATAPCHILabel.Text = "Mã tạp chí";
            // 
            // tENTAPCHILabel
            // 
            tENTAPCHILabel.AutoSize = true;
            tENTAPCHILabel.Location = new System.Drawing.Point(66, 122);
            tENTAPCHILabel.Name = "tENTAPCHILabel";
            tENTAPCHILabel.Size = new System.Drawing.Size(60, 13);
            tENTAPCHILabel.TabIndex = 2;
            tENTAPCHILabel.Text = "Tên tạp chí";
            // 
            // nAMPHATHANHLabel
            // 
            nAMPHATHANHLabel.AutoSize = true;
            nAMPHATHANHLabel.Location = new System.Drawing.Point(46, 197);
            nAMPHATHANHLabel.Name = "nAMPHATHANHLabel";
            nAMPHATHANHLabel.Size = new System.Drawing.Size(80, 13);
            nAMPHATHANHLabel.TabIndex = 4;
            nAMPHATHANHLabel.Text = "Năm phát hành";
            // 
            // dINHKILabel
            // 
            dINHKILabel.AutoSize = true;
            dINHKILabel.Location = new System.Drawing.Point(74, 251);
            dINHKILabel.Name = "dINHKILabel";
            dINHKILabel.Size = new System.Drawing.Size(43, 13);
            dINHKILabel.TabIndex = 6;
            dINHKILabel.Text = "Định kỳ";
            // 
            // nXBLabel
            // 
            nXBLabel.AutoSize = true;
            nXBLabel.Location = new System.Drawing.Point(54, 295);
            nXBLabel.Name = "nXBLabel";
            nXBLabel.Size = new System.Drawing.Size(72, 13);
            nXBLabel.TabIndex = 8;
            nXBLabel.Text = "Nhà xuất bản";
            // 
            // mATLLabel
            // 
            mATLLabel.AutoSize = true;
            mATLLabel.Location = new System.Drawing.Point(62, 337);
            mATLLabel.Name = "mATLLabel";
            mATLLabel.Size = new System.Drawing.Size(55, 13);
            mATLLabel.TabIndex = 10;
            mATLLabel.Text = "Mã tài liệu";
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
            // bdsTapChi
            // 
            this.bdsTapChi.DataMember = "TAPCHI";
            this.bdsTapChi.DataSource = this.dS;
            // 
            // tAPCHITableAdapter
            // 
            this.tAPCHITableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TAPCHITableAdapter = this.tAPCHITableAdapter;
            this.tableAdapterManager.UpdateOrder = QuanLyThuVien.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XUATBANTableAdapter = null;
            // 
            // gcTapChi
            // 
            this.gcTapChi.DataSource = this.bdsTapChi;
            this.gcTapChi.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcTapChi.Location = new System.Drawing.Point(0, 39);
            this.gcTapChi.MainView = this.gridView1;
            this.gcTapChi.MenuManager = this.barManager1;
            this.gcTapChi.Name = "gcTapChi";
            this.gcTapChi.Size = new System.Drawing.Size(833, 715);
            this.gcTapChi.TabIndex = 5;
            this.gcTapChi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMATAPCHI,
            this.colTENTAPCHI,
            this.colNAMPHATHANH,
            this.colDINHKI,
            this.colNXB,
            this.colMATL});
            this.gridView1.GridControl = this.gcTapChi;
            this.gridView1.Name = "gridView1";
            // 
            // colMATAPCHI
            // 
            this.colMATAPCHI.Caption = "Mã tạp chí";
            this.colMATAPCHI.FieldName = "MATAPCHI";
            this.colMATAPCHI.Name = "colMATAPCHI";
            this.colMATAPCHI.Visible = true;
            this.colMATAPCHI.VisibleIndex = 0;
            // 
            // colTENTAPCHI
            // 
            this.colTENTAPCHI.Caption = "Tên tạp chí";
            this.colTENTAPCHI.FieldName = "TENTAPCHI";
            this.colTENTAPCHI.Name = "colTENTAPCHI";
            this.colTENTAPCHI.Visible = true;
            this.colTENTAPCHI.VisibleIndex = 1;
            // 
            // colNAMPHATHANH
            // 
            this.colNAMPHATHANH.Caption = "Năm phát hành";
            this.colNAMPHATHANH.FieldName = "NAMPHATHANH";
            this.colNAMPHATHANH.Name = "colNAMPHATHANH";
            this.colNAMPHATHANH.Visible = true;
            this.colNAMPHATHANH.VisibleIndex = 2;
            // 
            // colDINHKI
            // 
            this.colDINHKI.Caption = "Định kỳ";
            this.colDINHKI.FieldName = "DINHKI";
            this.colDINHKI.Name = "colDINHKI";
            this.colDINHKI.Visible = true;
            this.colDINHKI.VisibleIndex = 3;
            // 
            // colNXB
            // 
            this.colNXB.Caption = "NXB";
            this.colNXB.FieldName = "NXB";
            this.colNXB.Name = "colNXB";
            this.colNXB.Visible = true;
            this.colNXB.VisibleIndex = 4;
            // 
            // colMATL
            // 
            this.colMATL.Caption = "Mã tài liệu";
            this.colMATL.FieldName = "MATL";
            this.colMATL.Name = "colMATL";
            this.colMATL.Visible = true;
            this.colMATL.VisibleIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(833, 39);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(551, 715);
            this.panelControl1.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbDinhKy);
            this.groupControl1.Controls.Add(mATLLabel);
            this.groupControl1.Controls.Add(this.txtMaTL);
            this.groupControl1.Controls.Add(nXBLabel);
            this.groupControl1.Controls.Add(this.txtNXB);
            this.groupControl1.Controls.Add(dINHKILabel);
            this.groupControl1.Controls.Add(nAMPHATHANHLabel);
            this.groupControl1.Controls.Add(this.dateNamPH);
            this.groupControl1.Controls.Add(tENTAPCHILabel);
            this.groupControl1.Controls.Add(this.txtTenTC);
            this.groupControl1.Controls.Add(mATAPCHILabel);
            this.groupControl1.Controls.Add(this.txtMaTC);
            this.groupControl1.Location = new System.Drawing.Point(54, 35);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(433, 378);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin tạp chí";
            // 
            // txtMaTL
            // 
            this.txtMaTL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTapChi, "MATL", true));
            this.txtMaTL.Location = new System.Drawing.Point(139, 330);
            this.txtMaTL.MenuManager = this.barManager1;
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(100, 28);
            this.txtMaTL.TabIndex = 11;
            // 
            // txtNXB
            // 
            this.txtNXB.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTapChi, "NXB", true));
            this.txtNXB.Location = new System.Drawing.Point(139, 288);
            this.txtNXB.MenuManager = this.barManager1;
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(251, 28);
            this.txtNXB.TabIndex = 9;
            // 
            // dateNamPH
            // 
            this.dateNamPH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTapChi, "NAMPHATHANH", true));
            this.dateNamPH.EditValue = null;
            this.dateNamPH.Location = new System.Drawing.Point(139, 190);
            this.dateNamPH.MenuManager = this.barManager1;
            this.dateNamPH.Name = "dateNamPH";
            this.dateNamPH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNamPH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNamPH.Size = new System.Drawing.Size(100, 28);
            this.dateNamPH.TabIndex = 5;
            // 
            // txtTenTC
            // 
            this.txtTenTC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTapChi, "TENTAPCHI", true));
            this.txtTenTC.Location = new System.Drawing.Point(139, 119);
            this.txtTenTC.MenuManager = this.barManager1;
            this.txtTenTC.Name = "txtTenTC";
            this.txtTenTC.Size = new System.Drawing.Size(251, 28);
            this.txtTenTC.TabIndex = 3;
            // 
            // txtMaTC
            // 
            this.txtMaTC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTapChi, "MATAPCHI", true));
            this.txtMaTC.Location = new System.Drawing.Point(139, 56);
            this.txtMaTC.MenuManager = this.barManager1;
            this.txtMaTC.Name = "txtMaTC";
            this.txtMaTC.Size = new System.Drawing.Size(152, 28);
            this.txtMaTC.TabIndex = 1;
            // 
            // cmbDinhKy
            // 
            this.cmbDinhKy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTapChi, "DINHKI", true));
            this.cmbDinhKy.FormattingEnabled = true;
            this.cmbDinhKy.Items.AddRange(new object[] {
            "1 Hàng ngày",
            "2 Hàng tháng",
            "3 Hàng năm"});
            this.cmbDinhKy.Location = new System.Drawing.Point(139, 248);
            this.cmbDinhKy.Name = "cmbDinhKy";
            this.cmbDinhKy.Size = new System.Drawing.Size(121, 21);
            this.cmbDinhKy.TabIndex = 12;
            // 
            // frmTapChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 754);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcTapChi);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTapChi";
            this.Text = "Tạp chí";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTapChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTapChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTapChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamPH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamPH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTC.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsTapChi;
        private DS dS;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DSTableAdapters.TAPCHITableAdapter tAPCHITableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcTapChi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMATAPCHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTENTAPCHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNAMPHATHANH;
        private DevExpress.XtraGrid.Columns.GridColumn colDINHKI;
        private DevExpress.XtraGrid.Columns.GridColumn colNXB;
        private DevExpress.XtraGrid.Columns.GridColumn colMATL;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtMaTL;
        private DevExpress.XtraEditors.TextEdit txtNXB;
        private DevExpress.XtraEditors.DateEdit dateNamPH;
        private DevExpress.XtraEditors.TextEdit txtTenTC;
        private DevExpress.XtraEditors.TextEdit txtMaTC;
        private System.Windows.Forms.ComboBox cmbDinhKy;
    }
}