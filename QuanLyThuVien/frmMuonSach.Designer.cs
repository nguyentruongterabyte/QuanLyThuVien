namespace QuanLyThuVien
{
    partial class frmMuonSach
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
            this.dS = new QuanLyThuVien.DS();
            this.bdsSachCoTheMuon = new System.Windows.Forms.BindingSource(this.components);
            this.v_SACH_CO_THE_MUONTableAdapter = new QuanLyThuVien.DSTableAdapters.V_SACH_CO_THE_MUONTableAdapter();
            this.tableAdapterManager = new QuanLyThuVien.DSTableAdapters.TableAdapterManager();
            this.v_SACH_CO_THE_MUONGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDSACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENSACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLANXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTINHTRANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLoaiBo = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnHoanTat = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dvGioSach = new System.Windows.Forms.DataGridView();
            this.iDSACHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mADOCGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYTRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYMUONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsCTMuonSach = new System.Windows.Forms.BindingSource(this.components);
            this.cT_MUONSACHTableAdapter = new QuanLyThuVien.DSTableAdapters.CT_MUONSACHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSachCoTheMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_SACH_CO_THE_MUONGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvGioSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTMuonSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsSachCoTheMuon
            // 
            this.bdsSachCoTheMuon.DataMember = "V_SACH_CO_THE_MUON";
            this.bdsSachCoTheMuon.DataSource = this.dS;
            // 
            // v_SACH_CO_THE_MUONTableAdapter
            // 
            this.v_SACH_CO_THE_MUONTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
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
            this.tableAdapterManager.XUATBANTableAdapter = null;
            // 
            // v_SACH_CO_THE_MUONGridControl
            // 
            this.v_SACH_CO_THE_MUONGridControl.DataSource = this.bdsSachCoTheMuon;
            this.v_SACH_CO_THE_MUONGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.v_SACH_CO_THE_MUONGridControl.Location = new System.Drawing.Point(0, 0);
            this.v_SACH_CO_THE_MUONGridControl.MainView = this.gridView1;
            this.v_SACH_CO_THE_MUONGridControl.Name = "v_SACH_CO_THE_MUONGridControl";
            this.v_SACH_CO_THE_MUONGridControl.Size = new System.Drawing.Size(645, 754);
            this.v_SACH_CO_THE_MUONGridControl.TabIndex = 1;
            this.v_SACH_CO_THE_MUONGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDSACH,
            this.colMASACH,
            this.colTENSACH,
            this.colLANXB,
            this.colSTT,
            this.colTINHTRANG});
            this.gridView1.GridControl = this.v_SACH_CO_THE_MUONGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colIDSACH
            // 
            this.colIDSACH.Caption = "ID cuốn";
            this.colIDSACH.FieldName = "IDSACH";
            this.colIDSACH.Name = "colIDSACH";
            this.colIDSACH.Visible = true;
            this.colIDSACH.VisibleIndex = 0;
            // 
            // colMASACH
            // 
            this.colMASACH.Caption = "Mã sách";
            this.colMASACH.FieldName = "MASACH";
            this.colMASACH.Name = "colMASACH";
            this.colMASACH.Visible = true;
            this.colMASACH.VisibleIndex = 1;
            // 
            // colTENSACH
            // 
            this.colTENSACH.Caption = "Tên sách";
            this.colTENSACH.FieldName = "TENSACH";
            this.colTENSACH.Name = "colTENSACH";
            this.colTENSACH.Visible = true;
            this.colTENSACH.VisibleIndex = 2;
            // 
            // colLANXB
            // 
            this.colLANXB.Caption = "Lần XB";
            this.colLANXB.FieldName = "LANXB";
            this.colLANXB.Name = "colLANXB";
            this.colLANXB.Visible = true;
            this.colLANXB.VisibleIndex = 3;
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 4;
            // 
            // colTINHTRANG
            // 
            this.colTINHTRANG.Caption = "Tình trạng";
            this.colTINHTRANG.FieldName = "TINHTRANG";
            this.colTINHTRANG.Name = "colTINHTRANG";
            this.colTINHTRANG.Visible = true;
            this.colTINHTRANG.VisibleIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnLoaiBo);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(645, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(154, 754);
            this.panelControl1.TabIndex = 2;
            // 
            // btnLoaiBo
            // 
            this.btnLoaiBo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLoaiBo.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiBo.Appearance.Options.UseBackColor = true;
            this.btnLoaiBo.Appearance.Options.UseFont = true;
            this.btnLoaiBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoaiBo.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_double_left_48;
            this.btnLoaiBo.Location = new System.Drawing.Point(5, 302);
            this.btnLoaiBo.Name = "btnLoaiBo";
            this.btnLoaiBo.Size = new System.Drawing.Size(142, 52);
            this.btnLoaiBo.TabIndex = 1;
            this.btnLoaiBo.Text = "Loại khỏi\r\ngiỏ sách";
            // 
            // btnThem
            // 
            this.btnThem.Appearance.BackColor = System.Drawing.Color.SpringGreen;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseBackColor = true;
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_double_right_48;
            this.btnThem.Location = new System.Drawing.Point(6, 234);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(142, 52);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm vào \r\ngiỏ sách";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnHoanTat);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.dateEdit1);
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(799, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(585, 754);
            this.panelControl2.TabIndex = 3;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHoanTat.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTat.Appearance.Options.UseBackColor = true;
            this.btnHoanTat.Appearance.Options.UseFont = true;
            this.btnHoanTat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoanTat.Location = new System.Drawing.Point(80, 643);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(447, 51);
            this.btnHoanTat.TabIndex = 3;
            this.btnHoanTat.Text = "HOÀN TẤT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 575);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày mượn";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(147, 568);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(153, 28);
            this.dateEdit1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dvGioSach);
            this.groupControl1.Location = new System.Drawing.Point(80, 64);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(449, 463);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Giỏ sách";
            // 
            // dvGioSach
            // 
            this.dvGioSach.AllowUserToAddRows = false;
            this.dvGioSach.AutoGenerateColumns = false;
            this.dvGioSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvGioSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSACHDataGridViewTextBoxColumn,
            this.MaSach,
            this.TenSach,
            this.TinhTrang,
            this.mADOCGIADataGridViewTextBoxColumn,
            this.nGAYTRADataGridViewTextBoxColumn,
            this.nGAYMUONDataGridViewTextBoxColumn});
            this.dvGioSach.DataSource = this.bdsCTMuonSach;
            this.dvGioSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvGioSach.Location = new System.Drawing.Point(2, 29);
            this.dvGioSach.Name = "dvGioSach";
            this.dvGioSach.ReadOnly = true;
            this.dvGioSach.Size = new System.Drawing.Size(445, 432);
            this.dvGioSach.TabIndex = 0;
            // 
            // iDSACHDataGridViewTextBoxColumn
            // 
            this.iDSACHDataGridViewTextBoxColumn.DataPropertyName = "IDSACH";
            this.iDSACHDataGridViewTextBoxColumn.HeaderText = "ID Cuốn";
            this.iDSACHDataGridViewTextBoxColumn.Name = "iDSACHDataGridViewTextBoxColumn";
            this.iDSACHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // mADOCGIADataGridViewTextBoxColumn
            // 
            this.mADOCGIADataGridViewTextBoxColumn.DataPropertyName = "MADOCGIA";
            this.mADOCGIADataGridViewTextBoxColumn.HeaderText = "MADOCGIA";
            this.mADOCGIADataGridViewTextBoxColumn.Name = "mADOCGIADataGridViewTextBoxColumn";
            this.mADOCGIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGAYTRADataGridViewTextBoxColumn
            // 
            this.nGAYTRADataGridViewTextBoxColumn.DataPropertyName = "NGAYTRA";
            this.nGAYTRADataGridViewTextBoxColumn.HeaderText = "NGAYTRA";
            this.nGAYTRADataGridViewTextBoxColumn.Name = "nGAYTRADataGridViewTextBoxColumn";
            this.nGAYTRADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGAYMUONDataGridViewTextBoxColumn
            // 
            this.nGAYMUONDataGridViewTextBoxColumn.DataPropertyName = "NGAYMUON";
            this.nGAYMUONDataGridViewTextBoxColumn.HeaderText = "NGAYMUON";
            this.nGAYMUONDataGridViewTextBoxColumn.Name = "nGAYMUONDataGridViewTextBoxColumn";
            this.nGAYMUONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bdsCTMuonSach
            // 
            this.bdsCTMuonSach.DataMember = "CT_MUONSACH";
            this.bdsCTMuonSach.DataSource = this.dS;
            // 
            // cT_MUONSACHTableAdapter
            // 
            this.cT_MUONSACHTableAdapter.ClearBeforeFill = true;
            // 
            // frmMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 754);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.v_SACH_CO_THE_MUONGridControl);
            this.Name = "frmMuonSach";
            this.Text = "Mượn sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSachCoTheMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_SACH_CO_THE_MUONGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvGioSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTMuonSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource bdsSachCoTheMuon;
        private DSTableAdapters.V_SACH_CO_THE_MUONTableAdapter v_SACH_CO_THE_MUONTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl v_SACH_CO_THE_MUONGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDSACH;
        private DevExpress.XtraGrid.Columns.GridColumn colMASACH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENSACH;
        private DevExpress.XtraGrid.Columns.GridColumn colLANXB;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colTINHTRANG;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dvGioSach;
        private DevExpress.XtraEditors.SimpleButton btnLoaiBo;
        private System.Windows.Forms.BindingSource bdsCTMuonSach;
        private DSTableAdapters.CT_MUONSACHTableAdapter cT_MUONSACHTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnHoanTat;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSACHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn mADOCGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYTRADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYMUONDataGridViewTextBoxColumn;
    }
}