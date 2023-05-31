namespace QuanLyThuVien
{
    partial class frmDocGia
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
            System.Windows.Forms.Label mADOCGIALabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label nGAYCAPLabel;
            System.Windows.Forms.Label nGHENGHIEPLabel;
            System.Windows.Forms.Label pHAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocGia));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dS = new QuanLyThuVien.DS();
            this.bdsDocGia = new System.Windows.Forms.BindingSource(this.components);
            this.dOCGIATableAdapter = new QuanLyThuVien.DSTableAdapters.DOCGIATableAdapter();
            this.tableAdapterManager = new QuanLyThuVien.DSTableAdapters.TableAdapterManager();
            this.dOCGIAGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMADOCGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGHENGHIEP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pHAICheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.nGHENGHIEPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nGAYCAPDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tENTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mADOCGIATextEdit = new DevExpress.XtraEditors.TextEdit();
            mADOCGIALabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            nGAYCAPLabel = new System.Windows.Forms.Label();
            nGHENGHIEPLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHAICheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGHENGHIEPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYCAPDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYCAPDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mADOCGIATextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mADOCGIALabel
            // 
            mADOCGIALabel.AutoSize = true;
            mADOCGIALabel.Location = new System.Drawing.Point(146, 48);
            mADOCGIALabel.Name = "mADOCGIALabel";
            mADOCGIALabel.Size = new System.Drawing.Size(58, 13);
            mADOCGIALabel.TabIndex = 0;
            mADOCGIALabel.Text = "Mã độc giả";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(155, 88);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(39, 13);
            tENLabel.TabIndex = 2;
            tENLabel.Text = "Họ tên";
            // 
            // nGAYCAPLabel
            // 
            nGAYCAPLabel.AutoSize = true;
            nGAYCAPLabel.Location = new System.Drawing.Point(146, 138);
            nGAYCAPLabel.Name = "nGAYCAPLabel";
            nGAYCAPLabel.Size = new System.Drawing.Size(52, 13);
            nGAYCAPLabel.TabIndex = 4;
            nGAYCAPLabel.Text = "Ngày cấp";
            // 
            // nGHENGHIEPLabel
            // 
            nGHENGHIEPLabel.AutoSize = true;
            nGHENGHIEPLabel.Location = new System.Drawing.Point(127, 199);
            nGHENGHIEPLabel.Name = "nGHENGHIEPLabel";
            nGHENGHIEPLabel.Size = new System.Drawing.Size(67, 13);
            nGHENGHIEPLabel.TabIndex = 6;
            nGHENGHIEPLabel.Text = "Nghề nghiệp";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(352, 141);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(45, 13);
            pHAILabel.TabIndex = 8;
            pHAILabel.Text = "Giới tính";
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
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Enabled = false;
            this.btnHuy.Id = 5;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.LargeImage")));
            this.btnHuy.Name = "btnHuy";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Id = 6;
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.LargeImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1384, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 754);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1384, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 715);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1384, 39);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 715);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDocGia
            // 
            this.bdsDocGia.DataMember = "DOCGIA";
            this.bdsDocGia.DataSource = this.dS;
            // 
            // dOCGIATableAdapter
            // 
            this.dOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_MUONBAOTableAdapter = null;
            this.tableAdapterManager.CT_MUONSACHTableAdapter = null;
            this.tableAdapterManager.CT_SACHTableAdapter = null;
            this.tableAdapterManager.CUONSACHTableAdapter = null;
            this.tableAdapterManager.DOCGIATableAdapter = this.dOCGIATableAdapter;
            this.tableAdapterManager.KYXBTableAdapter = null;
            this.tableAdapterManager.SACHTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.TAILIEUTableAdapter = null;
            this.tableAdapterManager.TAPCHITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyThuVien.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XUATBANTableAdapter = null;
            // 
            // dOCGIAGridControl
            // 
            this.dOCGIAGridControl.DataSource = this.bdsDocGia;
            this.dOCGIAGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dOCGIAGridControl.Location = new System.Drawing.Point(0, 39);
            this.dOCGIAGridControl.MainView = this.gridView1;
            this.dOCGIAGridControl.MenuManager = this.barManager1;
            this.dOCGIAGridControl.Name = "dOCGIAGridControl";
            this.dOCGIAGridControl.Size = new System.Drawing.Size(1384, 715);
            this.dOCGIAGridControl.TabIndex = 5;
            this.dOCGIAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMADOCGIA,
            this.colTEN,
            this.colNGAYCAP,
            this.colNGHENGHIEP,
            this.colPHAI});
            this.gridView1.GridControl = this.dOCGIAGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMADOCGIA
            // 
            this.colMADOCGIA.Caption = "Mã độc giả";
            this.colMADOCGIA.FieldName = "MADOCGIA";
            this.colMADOCGIA.Name = "colMADOCGIA";
            this.colMADOCGIA.Visible = true;
            this.colMADOCGIA.VisibleIndex = 0;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Họ tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 1;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.Caption = "Ngày cấp";
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 2;
            // 
            // colNGHENGHIEP
            // 
            this.colNGHENGHIEP.Caption = "Nghề nghiệp";
            this.colNGHENGHIEP.FieldName = "NGHENGHIEP";
            this.colNGHENGHIEP.Name = "colNGHENGHIEP";
            this.colNGHENGHIEP.Visible = true;
            this.colNGHENGHIEP.VisibleIndex = 3;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 754);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1384, 0);
            this.panelControl1.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(pHAILabel);
            this.groupControl1.Controls.Add(this.pHAICheckEdit);
            this.groupControl1.Controls.Add(nGHENGHIEPLabel);
            this.groupControl1.Controls.Add(this.nGHENGHIEPTextEdit);
            this.groupControl1.Controls.Add(nGAYCAPLabel);
            this.groupControl1.Controls.Add(this.nGAYCAPDateEdit);
            this.groupControl1.Controls.Add(tENLabel);
            this.groupControl1.Controls.Add(this.tENTextEdit);
            this.groupControl1.Controls.Add(mADOCGIALabel);
            this.groupControl1.Controls.Add(this.mADOCGIATextEdit);
            this.groupControl1.Location = new System.Drawing.Point(428, 56);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(574, 259);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin độc giả";
            // 
            // pHAICheckEdit
            // 
            this.pHAICheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDocGia, "PHAI", true));
            this.pHAICheckEdit.Location = new System.Drawing.Point(403, 137);
            this.pHAICheckEdit.MenuManager = this.barManager1;
            this.pHAICheckEdit.Name = "pHAICheckEdit";
            this.pHAICheckEdit.Properties.Caption = "Nam";
            this.pHAICheckEdit.Size = new System.Drawing.Size(75, 22);
            this.pHAICheckEdit.TabIndex = 9;
            // 
            // nGHENGHIEPTextEdit
            // 
            this.nGHENGHIEPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDocGia, "NGHENGHIEP", true));
            this.nGHENGHIEPTextEdit.EditValue = "";
            this.nGHENGHIEPTextEdit.Location = new System.Drawing.Point(208, 196);
            this.nGHENGHIEPTextEdit.MenuManager = this.barManager1;
            this.nGHENGHIEPTextEdit.Name = "nGHENGHIEPTextEdit";
            this.nGHENGHIEPTextEdit.Size = new System.Drawing.Size(247, 28);
            this.nGHENGHIEPTextEdit.TabIndex = 7;
            // 
            // nGAYCAPDateEdit
            // 
            this.nGAYCAPDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDocGia, "NGAYCAP", true));
            this.nGAYCAPDateEdit.EditValue = null;
            this.nGAYCAPDateEdit.Location = new System.Drawing.Point(210, 131);
            this.nGAYCAPDateEdit.MenuManager = this.barManager1;
            this.nGAYCAPDateEdit.Name = "nGAYCAPDateEdit";
            this.nGAYCAPDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYCAPDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYCAPDateEdit.Size = new System.Drawing.Size(109, 28);
            this.nGAYCAPDateEdit.TabIndex = 5;
            // 
            // tENTextEdit
            // 
            this.tENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDocGia, "TEN", true));
            this.tENTextEdit.Location = new System.Drawing.Point(210, 81);
            this.tENTextEdit.MenuManager = this.barManager1;
            this.tENTextEdit.Name = "tENTextEdit";
            this.tENTextEdit.Size = new System.Drawing.Size(245, 28);
            this.tENTextEdit.TabIndex = 3;
            // 
            // mADOCGIATextEdit
            // 
            this.mADOCGIATextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDocGia, "MADOCGIA", true));
            this.mADOCGIATextEdit.Location = new System.Drawing.Point(210, 41);
            this.mADOCGIATextEdit.MenuManager = this.barManager1;
            this.mADOCGIATextEdit.Name = "mADOCGIATextEdit";
            this.mADOCGIATextEdit.Size = new System.Drawing.Size(245, 28);
            this.mADOCGIATextEdit.TabIndex = 1;
            // 
            // frmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 754);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.dOCGIAGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDocGia";
            this.Text = "Độc giả";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHAICheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGHENGHIEPTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYCAPDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYCAPDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mADOCGIATextEdit.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsDocGia;
        private DS dS;
        private DSTableAdapters.DOCGIATableAdapter dOCGIATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl dOCGIAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMADOCGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colNGHENGHIEP;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit pHAICheckEdit;
        private DevExpress.XtraEditors.TextEdit nGHENGHIEPTextEdit;
        private DevExpress.XtraEditors.DateEdit nGAYCAPDateEdit;
        private DevExpress.XtraEditors.TextEdit tENTextEdit;
        private DevExpress.XtraEditors.TextEdit mADOCGIATextEdit;
    }
}