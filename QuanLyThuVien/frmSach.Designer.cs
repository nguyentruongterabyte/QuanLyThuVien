namespace QuanLyThuVien
{
    partial class frmSach
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
            System.Windows.Forms.Label mASACHLabel;
            System.Windows.Forms.Label mATLLabel;
            System.Windows.Forms.Label tENSACHLabel;
            System.Windows.Forms.Label nAMPHATHANHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSach));
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
            this.bdsSach = new System.Windows.Forms.BindingSource(this.components);
            this.sACHTableAdapter = new QuanLyThuVien.DSTableAdapters.SACHTableAdapter();
            this.tableAdapterManager = new QuanLyThuVien.DSTableAdapters.TableAdapterManager();
            this.tAILIEUTableAdapter = new QuanLyThuVien.DSTableAdapters.TAILIEUTableAdapter();
            this.gcSach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAMPHATHANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENSACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaTL = new DevExpress.XtraEditors.TextEdit();
            this.dgvCT_Sach = new System.Windows.Forms.DataGridView();
            this.mASACHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsViewTacGia = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCTSach = new System.Windows.Forms.BindingSource(this.components);
            this.dateNamPH = new DevExpress.XtraEditors.DateEdit();
            this.txtTenSach = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSach = new DevExpress.XtraEditors.TextEdit();
            this.bdsTaiLieu = new System.Windows.Forms.BindingSource(this.components);
            this.v_Tac_GiaTableAdapter = new QuanLyThuVien.DSTableAdapters.V_Tac_GiaTableAdapter();
            this.cT_SACHTableAdapter = new QuanLyThuVien.DSTableAdapters.CT_SACHTableAdapter();
            this.bdsXuatBan = new System.Windows.Forms.BindingSource(this.components);
            this.xUATBANTableAdapter = new QuanLyThuVien.DSTableAdapters.XUATBANTableAdapter();
            mASACHLabel = new System.Windows.Forms.Label();
            mATLLabel = new System.Windows.Forms.Label();
            tENSACHLabel = new System.Windows.Forms.Label();
            nAMPHATHANHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_Sach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsViewTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamPH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamPH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXuatBan)).BeginInit();
            this.SuspendLayout();
            // 
            // mASACHLabel
            // 
            mASACHLabel.AutoSize = true;
            mASACHLabel.Location = new System.Drawing.Point(18, 69);
            mASACHLabel.Name = "mASACHLabel";
            mASACHLabel.Size = new System.Drawing.Size(46, 13);
            mASACHLabel.TabIndex = 0;
            mASACHLabel.Text = "Mã sách";
            // 
            // mATLLabel
            // 
            mATLLabel.AutoSize = true;
            mATLLabel.Location = new System.Drawing.Point(18, 124);
            mATLLabel.Name = "mATLLabel";
            mATLLabel.Size = new System.Drawing.Size(60, 13);
            mATLLabel.TabIndex = 2;
            mATLLabel.Text = "Loại tài liệu";
            // 
            // tENSACHLabel
            // 
            tENSACHLabel.AutoSize = true;
            tENSACHLabel.Location = new System.Drawing.Point(18, 186);
            tENSACHLabel.Name = "tENSACHLabel";
            tENSACHLabel.Size = new System.Drawing.Size(50, 13);
            tENSACHLabel.TabIndex = 4;
            tENSACHLabel.Text = "Tên sách";
            // 
            // nAMPHATHANHLabel
            // 
            nAMPHATHANHLabel.AutoSize = true;
            nAMPHATHANHLabel.Location = new System.Drawing.Point(18, 241);
            nAMPHATHANHLabel.Name = "nAMPHATHANHLabel";
            nAMPHATHANHLabel.Size = new System.Drawing.Size(80, 13);
            nAMPHATHANHLabel.TabIndex = 6;
            nAMPHATHANHLabel.Text = "Năm phát hành";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1384, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 477);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1384, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 438);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1384, 39);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 438);
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
            // bdsSach
            // 
            this.bdsSach.DataMember = "SACH";
            this.bdsSach.DataSource = this.dS;
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SACHTableAdapter = this.sACHTableAdapter;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.TAILIEUTableAdapter = this.tAILIEUTableAdapter;
            this.tableAdapterManager.TAPCHITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyThuVien.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XUATBANTableAdapter = null;
            // 
            // tAILIEUTableAdapter
            // 
            this.tAILIEUTableAdapter.ClearBeforeFill = true;
            // 
            // gcSach
            // 
            this.gcSach.DataSource = this.bdsSach;
            this.gcSach.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcSach.Location = new System.Drawing.Point(0, 39);
            this.gcSach.MainView = this.gridView1;
            this.gcSach.MenuManager = this.barManager1;
            this.gcSach.Name = "gcSach";
            this.gcSach.Size = new System.Drawing.Size(667, 438);
            this.gcSach.TabIndex = 5;
            this.gcSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASACH,
            this.colNAMPHATHANH,
            this.colTENSACH,
            this.colMATL});
            this.gridView1.GridControl = this.gcSach;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMASACH
            // 
            this.colMASACH.Caption = "Mã sách";
            this.colMASACH.FieldName = "MASACH";
            this.colMASACH.Name = "colMASACH";
            this.colMASACH.Visible = true;
            this.colMASACH.VisibleIndex = 0;
            // 
            // colNAMPHATHANH
            // 
            this.colNAMPHATHANH.Caption = "Năm phát hành";
            this.colNAMPHATHANH.FieldName = "NAMPHATHANH";
            this.colNAMPHATHANH.Name = "colNAMPHATHANH";
            this.colNAMPHATHANH.Visible = true;
            this.colNAMPHATHANH.VisibleIndex = 2;
            // 
            // colTENSACH
            // 
            this.colTENSACH.Caption = "Tên sách";
            this.colTENSACH.FieldName = "TENSACH";
            this.colTENSACH.Name = "colTENSACH";
            this.colTENSACH.Visible = true;
            this.colTENSACH.VisibleIndex = 1;
            this.colTENSACH.Width = 219;
            // 
            // colMATL
            // 
            this.colMATL.Caption = "Mã tài liệu";
            this.colMATL.FieldName = "MATL";
            this.colMATL.Name = "colMATL";
            this.colMATL.Visible = true;
            this.colMATL.VisibleIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(667, 39);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(717, 438);
            this.panelControl1.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtMaTL);
            this.groupControl1.Controls.Add(this.dgvCT_Sach);
            this.groupControl1.Controls.Add(nAMPHATHANHLabel);
            this.groupControl1.Controls.Add(this.dateNamPH);
            this.groupControl1.Controls.Add(tENSACHLabel);
            this.groupControl1.Controls.Add(this.txtTenSach);
            this.groupControl1.Controls.Add(mATLLabel);
            this.groupControl1.Controls.Add(mASACHLabel);
            this.groupControl1.Controls.Add(this.txtMaSach);
            this.groupControl1.Enabled = false;
            this.groupControl1.Location = new System.Drawing.Point(59, 78);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(607, 332);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin sách";
            // 
            // txtMaTL
            // 
            this.txtMaTL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSach, "MATL", true));
            this.txtMaTL.EditValue = "SACH";
            this.txtMaTL.Enabled = false;
            this.txtMaTL.Location = new System.Drawing.Point(114, 117);
            this.txtMaTL.MenuManager = this.barManager1;
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(140, 28);
            this.txtMaTL.TabIndex = 12;
            // 
            // dgvCT_Sach
            // 
            this.dgvCT_Sach.AutoGenerateColumns = false;
            this.dgvCT_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_Sach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mASACHDataGridViewTextBoxColumn,
            this.mATGDataGridViewTextBoxColumn});
            this.dgvCT_Sach.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvCT_Sach.DataSource = this.bdsCTSach;
            this.dgvCT_Sach.Location = new System.Drawing.Point(338, 69);
            this.dgvCT_Sach.Name = "dgvCT_Sach";
            this.dgvCT_Sach.Size = new System.Drawing.Size(244, 220);
            this.dgvCT_Sach.TabIndex = 11;
            // 
            // mASACHDataGridViewTextBoxColumn
            // 
            this.mASACHDataGridViewTextBoxColumn.DataPropertyName = "MASACH";
            this.mASACHDataGridViewTextBoxColumn.HeaderText = "MASACH";
            this.mASACHDataGridViewTextBoxColumn.Name = "mASACHDataGridViewTextBoxColumn";
            this.mASACHDataGridViewTextBoxColumn.Visible = false;
            this.mASACHDataGridViewTextBoxColumn.Width = 200;
            // 
            // mATGDataGridViewTextBoxColumn
            // 
            this.mATGDataGridViewTextBoxColumn.DataPropertyName = "MATG";
            this.mATGDataGridViewTextBoxColumn.DataSource = this.bdsViewTacGia;
            this.mATGDataGridViewTextBoxColumn.DisplayMember = "TENTG";
            this.mATGDataGridViewTextBoxColumn.HeaderText = "Sáng tác";
            this.mATGDataGridViewTextBoxColumn.Name = "mATGDataGridViewTextBoxColumn";
            this.mATGDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mATGDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.mATGDataGridViewTextBoxColumn.ValueMember = "MATG";
            this.mATGDataGridViewTextBoxColumn.Width = 200;
            // 
            // bdsViewTacGia
            // 
            this.bdsViewTacGia.DataMember = "V_Tac_Gia";
            this.bdsViewTacGia.DataSource = this.dS;
            // 
            // bdsCTSach
            // 
            this.bdsCTSach.DataMember = "FK_CT_SACH_SACH";
            this.bdsCTSach.DataSource = this.bdsSach;
            // 
            // dateNamPH
            // 
            this.dateNamPH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSach, "NAMPHATHANH", true));
            this.dateNamPH.EditValue = null;
            this.dateNamPH.Location = new System.Drawing.Point(114, 234);
            this.dateNamPH.MenuManager = this.barManager1;
            this.dateNamPH.Name = "dateNamPH";
            this.dateNamPH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNamPH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNamPH.Size = new System.Drawing.Size(100, 28);
            this.dateNamPH.TabIndex = 4;
            // 
            // txtTenSach
            // 
            this.txtTenSach.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSach, "TENSACH", true));
            this.txtTenSach.Location = new System.Drawing.Point(114, 179);
            this.txtTenSach.MenuManager = this.barManager1;
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(218, 28);
            this.txtTenSach.TabIndex = 3;
            // 
            // txtMaSach
            // 
            this.txtMaSach.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSach, "MASACH", true));
            this.txtMaSach.Location = new System.Drawing.Point(114, 62);
            this.txtMaSach.MenuManager = this.barManager1;
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(140, 28);
            this.txtMaSach.TabIndex = 1;
            // 
            // bdsTaiLieu
            // 
            this.bdsTaiLieu.DataMember = "TAILIEU";
            this.bdsTaiLieu.DataSource = this.dS;
            // 
            // v_Tac_GiaTableAdapter
            // 
            this.v_Tac_GiaTableAdapter.ClearBeforeFill = true;
            // 
            // cT_SACHTableAdapter
            // 
            this.cT_SACHTableAdapter.ClearBeforeFill = true;
            // 
            // bdsXuatBan
            // 
            this.bdsXuatBan.DataMember = "FK_XUATBAN_SACH";
            this.bdsXuatBan.DataSource = this.bdsSach;
            // 
            // xUATBANTableAdapter
            // 
            this.xUATBANTableAdapter.ClearBeforeFill = true;
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 477);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcSach);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmSach";
            this.Text = "Sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_Sach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsViewTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamPH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNamPH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXuatBan)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsSach;
        private DS dS;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DSTableAdapters.SACHTableAdapter sACHTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit dateNamPH;
        private DevExpress.XtraEditors.TextEdit txtTenSach;
        private DevExpress.XtraEditors.TextEdit txtMaSach;
        private DevExpress.XtraGrid.Columns.GridColumn colMASACH;
        private DevExpress.XtraGrid.Columns.GridColumn colNAMPHATHANH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENSACH;
        private DevExpress.XtraGrid.Columns.GridColumn colMATL;
        private DSTableAdapters.TAILIEUTableAdapter tAILIEUTableAdapter;
        private System.Windows.Forms.BindingSource bdsTaiLieu;
        private System.Windows.Forms.BindingSource bdsViewTacGia;
        private DSTableAdapters.V_Tac_GiaTableAdapter v_Tac_GiaTableAdapter;
        private System.Windows.Forms.DataGridView dgvCT_Sach;
        private System.Windows.Forms.BindingSource bdsCTSach;
        private DSTableAdapters.CT_SACHTableAdapter cT_SACHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASACHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn mATGDataGridViewTextBoxColumn;
        private DevExpress.XtraEditors.TextEdit txtMaTL;
        private System.Windows.Forms.BindingSource bdsXuatBan;
        private DSTableAdapters.XUATBANTableAdapter xUATBANTableAdapter;
    }
}