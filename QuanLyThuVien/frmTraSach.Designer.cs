namespace QuanLyThuVien
{
    partial class frmTraSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraSach));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.sP_SACH_CHUA_TRAGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsSachChuaTra = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QuanLyThuVien.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDSACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMUON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSONGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTINHTRANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENSACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_SACH_CHUA_TRATableAdapter = new QuanLyThuVien.DSTableAdapters.SP_SACH_CHUA_TRATableAdapter();
            this.tableAdapterManager = new QuanLyThuVien.DSTableAdapters.TableAdapterManager();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnTaiLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoaiBo = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnHoanTat = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dvKeSach = new System.Windows.Forms.DataGridView();
            this.IDSACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYMUON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SONGAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TINHTRANG = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_SACH_CHUA_TRAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSachChuaTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvKeSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.sP_SACH_CHUA_TRAGridControl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(662, 450);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Sách bạn mượn";
            // 
            // sP_SACH_CHUA_TRAGridControl
            // 
            this.sP_SACH_CHUA_TRAGridControl.DataSource = this.bdsSachChuaTra;
            this.sP_SACH_CHUA_TRAGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_SACH_CHUA_TRAGridControl.Location = new System.Drawing.Point(2, 29);
            this.sP_SACH_CHUA_TRAGridControl.MainView = this.gridView1;
            this.sP_SACH_CHUA_TRAGridControl.Name = "sP_SACH_CHUA_TRAGridControl";
            this.sP_SACH_CHUA_TRAGridControl.Size = new System.Drawing.Size(658, 419);
            this.sP_SACH_CHUA_TRAGridControl.TabIndex = 0;
            this.sP_SACH_CHUA_TRAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsSachChuaTra
            // 
            this.bdsSachChuaTra.DataMember = "SP_SACH_CHUA_TRA";
            this.bdsSachChuaTra.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDSACH,
            this.colNGAYMUON,
            this.colSONGAY,
            this.colTINHTRANG,
            this.colSTT,
            this.colTENSACH});
            this.gridView1.GridControl = this.sP_SACH_CHUA_TRAGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colIDSACH
            // 
            this.colIDSACH.Caption = "ID sách";
            this.colIDSACH.FieldName = "IDSACH";
            this.colIDSACH.Name = "colIDSACH";
            this.colIDSACH.Visible = true;
            this.colIDSACH.VisibleIndex = 0;
            this.colIDSACH.Width = 47;
            // 
            // colNGAYMUON
            // 
            this.colNGAYMUON.Caption = "Ngày mượn";
            this.colNGAYMUON.FieldName = "NGAYMUON";
            this.colNGAYMUON.Name = "colNGAYMUON";
            this.colNGAYMUON.Visible = true;
            this.colNGAYMUON.VisibleIndex = 2;
            this.colNGAYMUON.Width = 130;
            // 
            // colSONGAY
            // 
            this.colSONGAY.Caption = "Số ngày mượn";
            this.colSONGAY.FieldName = "SONGAY";
            this.colSONGAY.Name = "colSONGAY";
            this.colSONGAY.Visible = true;
            this.colSONGAY.VisibleIndex = 3;
            this.colSONGAY.Width = 86;
            // 
            // colTINHTRANG
            // 
            this.colTINHTRANG.Caption = "Tình trạng";
            this.colTINHTRANG.FieldName = "TINHTRANG";
            this.colTINHTRANG.Name = "colTINHTRANG";
            this.colTINHTRANG.Visible = true;
            this.colTINHTRANG.VisibleIndex = 4;
            this.colTINHTRANG.Width = 115;
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 5;
            this.colSTT.Width = 32;
            // 
            // colTENSACH
            // 
            this.colTENSACH.Caption = "Tên sách";
            this.colTENSACH.FieldName = "TENSACH";
            this.colTENSACH.Name = "colTENSACH";
            this.colTENSACH.Visible = true;
            this.colTENSACH.VisibleIndex = 1;
            this.colTENSACH.Width = 220;
            // 
            // sP_SACH_CHUA_TRATableAdapter
            // 
            this.sP_SACH_CHUA_TRATableAdapter.ClearBeforeFill = true;
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnTaiLai);
            this.panelControl1.Controls.Add(this.btnLoaiBo);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(662, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(156, 450);
            this.panelControl1.TabIndex = 1;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Appearance.BackColor = System.Drawing.Color.Aqua;
            this.btnTaiLai.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.Appearance.Options.UseBackColor = true;
            this.btnTaiLai.Appearance.Options.UseFont = true;
            this.btnTaiLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaiLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLai.ImageOptions.Image")));
            this.btnTaiLai.Location = new System.Drawing.Point(5, 12);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(142, 52);
            this.btnTaiLai.TabIndex = 4;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // btnLoaiBo
            // 
            this.btnLoaiBo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLoaiBo.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiBo.Appearance.Options.UseBackColor = true;
            this.btnLoaiBo.Appearance.Options.UseFont = true;
            this.btnLoaiBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoaiBo.Enabled = false;
            this.btnLoaiBo.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_double_left_48;
            this.btnLoaiBo.Location = new System.Drawing.Point(6, 147);
            this.btnLoaiBo.Name = "btnLoaiBo";
            this.btnLoaiBo.Size = new System.Drawing.Size(142, 52);
            this.btnLoaiBo.TabIndex = 3;
            this.btnLoaiBo.Text = "Thêm lại \r\nvào giỏ sách";
            this.btnLoaiBo.Click += new System.EventHandler(this.btnLoaiBo_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.BackColor = System.Drawing.Color.SpringGreen;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseBackColor = true;
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_double_right_48;
            this.btnThem.Location = new System.Drawing.Point(6, 80);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(142, 52);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Đặt vào kệ";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnHoanTat);
            this.panelControl2.Controls.Add(this.groupControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(818, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(566, 450);
            this.panelControl2.TabIndex = 4;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHoanTat.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTat.Appearance.Options.UseBackColor = true;
            this.btnHoanTat.Appearance.Options.UseFont = true;
            this.btnHoanTat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoanTat.Location = new System.Drawing.Point(78, 388);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(447, 51);
            this.btnHoanTat.TabIndex = 3;
            this.btnHoanTat.Text = "HOÀN TẤT";
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dvKeSach);
            this.groupControl2.Location = new System.Drawing.Point(78, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(449, 260);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Kệ sách";
            // 
            // dvKeSach
            // 
            this.dvKeSach.AllowUserToAddRows = false;
            this.dvKeSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvKeSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSACH,
            this.TENSACH,
            this.NGAYMUON,
            this.SONGAY,
            this.TINHTRANG,
            this.STT});
            this.dvKeSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvKeSach.Location = new System.Drawing.Point(2, 29);
            this.dvKeSach.Name = "dvKeSach";
            this.dvKeSach.Size = new System.Drawing.Size(445, 229);
            this.dvKeSach.TabIndex = 0;
            this.dvKeSach.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dvKeSach_UserDeletingRow);
            // 
            // IDSACH
            // 
            this.IDSACH.HeaderText = "ID Cuốn";
            this.IDSACH.Name = "IDSACH";
            this.IDSACH.ReadOnly = true;
            // 
            // TENSACH
            // 
            this.TENSACH.HeaderText = "Tên Sách";
            this.TENSACH.Name = "TENSACH";
            this.TENSACH.ReadOnly = true;
            // 
            // NGAYMUON
            // 
            this.NGAYMUON.HeaderText = "Ngày mượn";
            this.NGAYMUON.Name = "NGAYMUON";
            this.NGAYMUON.ReadOnly = true;
            // 
            // SONGAY
            // 
            this.SONGAY.HeaderText = "Số ngày mượn";
            this.SONGAY.Name = "SONGAY";
            this.SONGAY.ReadOnly = true;
            // 
            // TINHTRANG
            // 
            this.TINHTRANG.DataPropertyName = "TINHTRANG";
            this.TINHTRANG.HeaderText = "Tình trạng";
            this.TINHTRANG.Items.AddRange(new object[] {
            "Mới",
            "Cũ",
            "Hỏng",
            "Mất trang",
            "Unknow"});
            this.TINHTRANG.Name = "TINHTRANG";
            this.TINHTRANG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TINHTRANG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // frmTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 450);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmTraSach";
            this.Text = "Trả sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTraSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_SACH_CHUA_TRAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSachChuaTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvKeSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsSachChuaTra;
        private DSTableAdapters.SP_SACH_CHUA_TRATableAdapter sP_SACH_CHUA_TRATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_SACH_CHUA_TRAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDSACH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMUON;
        private DevExpress.XtraGrid.Columns.GridColumn colSONGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colTINHTRANG;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENSACH;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLoaiBo;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnHoanTat;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dvKeSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYMUON;
        private System.Windows.Forms.DataGridViewTextBoxColumn SONGAY;
        private System.Windows.Forms.DataGridViewComboBoxColumn TINHTRANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private DevExpress.XtraEditors.SimpleButton btnTaiLai;
    }
}