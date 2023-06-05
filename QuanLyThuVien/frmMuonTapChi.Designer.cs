namespace QuanLyThuVien
{
    partial class frmMuonTapChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuonTapChi));
            System.Windows.Forms.Label sONGAYLabel;
            this.dS = new QuanLyThuVien.DS();
            this.bdsTapChi = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DS_BAO_TAP_CHI_CO_THE_MUONTableAdapter = new QuanLyThuVien.DSTableAdapters.SP_DS_BAO_TAP_CHI_CO_THE_MUONTableAdapter();
            this.tableAdapterManager = new QuanLyThuVien.DSTableAdapters.TableAdapterManager();
            this.sP_DS_BAO_TAP_CHI_CO_THE_MUONGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDKI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENTAPCHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDINHKI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnTaiLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoaiBo = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnHoanTat = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dvGioTapChi = new System.Windows.Forms.DataGridView();
            this.IDKI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTAPCHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DINHKI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cT_MUONBAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cT_MUONBAOTableAdapter = new QuanLyThuVien.DSTableAdapters.CT_MUONBAOTableAdapter();
            this.txtSoNgay = new DevExpress.XtraEditors.TextEdit();
            sONGAYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTapChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_BAO_TAP_CHI_CO_THE_MUONGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvGioTapChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_MUONBAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNgay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsTapChi
            // 
            this.bdsTapChi.DataMember = "SP_DS_BAO_TAP_CHI_CO_THE_MUON";
            this.bdsTapChi.DataSource = this.dS;
            // 
            // sP_DS_BAO_TAP_CHI_CO_THE_MUONTableAdapter
            // 
            this.sP_DS_BAO_TAP_CHI_CO_THE_MUONTableAdapter.ClearBeforeFill = true;
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
            // sP_DS_BAO_TAP_CHI_CO_THE_MUONGridControl
            // 
            this.sP_DS_BAO_TAP_CHI_CO_THE_MUONGridControl.DataSource = this.bdsTapChi;
            this.sP_DS_BAO_TAP_CHI_CO_THE_MUONGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.sP_DS_BAO_TAP_CHI_CO_THE_MUONGridControl.Location = new System.Drawing.Point(0, 0);
            this.sP_DS_BAO_TAP_CHI_CO_THE_MUONGridControl.MainView = this.gridView1;
            this.sP_DS_BAO_TAP_CHI_CO_THE_MUONGridControl.Name = "sP_DS_BAO_TAP_CHI_CO_THE_MUONGridControl";
            this.sP_DS_BAO_TAP_CHI_CO_THE_MUONGridControl.Size = new System.Drawing.Size(594, 495);
            this.sP_DS_BAO_TAP_CHI_CO_THE_MUONGridControl.TabIndex = 2;
            this.sP_DS_BAO_TAP_CHI_CO_THE_MUONGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.sP_DS_BAO_TAP_CHI_CO_THE_MUONGridControl.Click += new System.EventHandler(this.sP_DS_BAO_TAP_CHI_CO_THE_MUONGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDKI,
            this.colTENTAPCHI,
            this.colNXB,
            this.colDINHKI});
            this.gridView1.GridControl = this.sP_DS_BAO_TAP_CHI_CO_THE_MUONGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colIDKI
            // 
            this.colIDKI.FieldName = "IDKI";
            this.colIDKI.Name = "colIDKI";
            this.colIDKI.Visible = true;
            this.colIDKI.VisibleIndex = 0;
            // 
            // colTENTAPCHI
            // 
            this.colTENTAPCHI.FieldName = "TENTAPCHI";
            this.colTENTAPCHI.Name = "colTENTAPCHI";
            this.colTENTAPCHI.Visible = true;
            this.colTENTAPCHI.VisibleIndex = 1;
            // 
            // colNXB
            // 
            this.colNXB.FieldName = "NXB";
            this.colNXB.Name = "colNXB";
            this.colNXB.Visible = true;
            this.colNXB.VisibleIndex = 2;
            // 
            // colDINHKI
            // 
            this.colDINHKI.FieldName = "DINHKI";
            this.colDINHKI.Name = "colDINHKI";
            this.colDINHKI.Visible = true;
            this.colDINHKI.VisibleIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnTaiLai);
            this.panelControl1.Controls.Add(this.btnLoaiBo);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(594, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(154, 495);
            this.panelControl1.TabIndex = 3;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Appearance.BackColor = System.Drawing.Color.Aqua;
            this.btnTaiLai.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.Appearance.Options.UseBackColor = true;
            this.btnTaiLai.Appearance.Options.UseFont = true;
            this.btnTaiLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaiLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLai.ImageOptions.Image")));
            this.btnTaiLai.Location = new System.Drawing.Point(5, 21);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(142, 52);
            this.btnTaiLai.TabIndex = 2;
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
            this.btnLoaiBo.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_double_left_48;
            this.btnLoaiBo.Location = new System.Drawing.Point(5, 155);
            this.btnLoaiBo.Name = "btnLoaiBo";
            this.btnLoaiBo.Size = new System.Drawing.Size(142, 52);
            this.btnLoaiBo.TabIndex = 1;
            this.btnLoaiBo.Text = "Loại khỏi\r\ngiỏ tạp chí";
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
            this.btnThem.Location = new System.Drawing.Point(5, 88);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(142, 52);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm vào \r\ngiỏ tạp chí";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtSoNgay);
            this.panelControl2.Controls.Add(sONGAYLabel);
            this.panelControl2.Controls.Add(this.btnHoanTat);
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(748, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(636, 495);
            this.panelControl2.TabIndex = 4;
            // 
            // sONGAYLabel
            // 
            sONGAYLabel.AutoSize = true;
            sONGAYLabel.Location = new System.Drawing.Point(75, 320);
            sONGAYLabel.Name = "sONGAYLabel";
            sONGAYLabel.Size = new System.Drawing.Size(76, 13);
            sONGAYLabel.TabIndex = 4;
            sONGAYLabel.Text = "Số ngày mượn";
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
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dvGioTapChi);
            this.groupControl1.Location = new System.Drawing.Point(78, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(449, 260);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Giỏ tạp chí";
            // 
            // dvGioTapChi
            // 
            this.dvGioTapChi.AllowUserToAddRows = false;
            this.dvGioTapChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvGioTapChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDKI,
            this.TENTAPCHI,
            this.NXB,
            this.DINHKI});
            this.dvGioTapChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvGioTapChi.Location = new System.Drawing.Point(2, 29);
            this.dvGioTapChi.Name = "dvGioTapChi";
            this.dvGioTapChi.ReadOnly = true;
            this.dvGioTapChi.Size = new System.Drawing.Size(445, 229);
            this.dvGioTapChi.TabIndex = 0;
            // 
            // IDKI
            // 
            this.IDKI.HeaderText = "ID Kỳ";
            this.IDKI.Name = "IDKI";
            this.IDKI.ReadOnly = true;
            // 
            // TENTAPCHI
            // 
            this.TENTAPCHI.HeaderText = "Tên tạp chí";
            this.TENTAPCHI.Name = "TENTAPCHI";
            this.TENTAPCHI.ReadOnly = true;
            // 
            // NXB
            // 
            this.NXB.HeaderText = "Nhà XB";
            this.NXB.Name = "NXB";
            this.NXB.ReadOnly = true;
            // 
            // DINHKI
            // 
            this.DINHKI.HeaderText = "Định kỳ";
            this.DINHKI.Name = "DINHKI";
            this.DINHKI.ReadOnly = true;
            // 
            // cT_MUONBAOBindingSource
            // 
            this.cT_MUONBAOBindingSource.DataMember = "CT_MUONBAO";
            this.cT_MUONBAOBindingSource.DataSource = this.dS;
            // 
            // cT_MUONBAOTableAdapter
            // 
            this.cT_MUONBAOTableAdapter.ClearBeforeFill = true;
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cT_MUONBAOBindingSource, "SONGAY", true));
            this.txtSoNgay.Location = new System.Drawing.Point(157, 313);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.Size = new System.Drawing.Size(100, 28);
            this.txtSoNgay.TabIndex = 5;
            this.txtSoNgay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoNgay_KeyPress);
            // 
            // frmMuonTapChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 495);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.sP_DS_BAO_TAP_CHI_CO_THE_MUONGridControl);
            this.Name = "frmMuonTapChi";
            this.Text = "Mượn tạp chí";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMuonTapChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTapChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_BAO_TAP_CHI_CO_THE_MUONGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvGioTapChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_MUONBAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNgay.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource bdsTapChi;
        private DSTableAdapters.SP_DS_BAO_TAP_CHI_CO_THE_MUONTableAdapter sP_DS_BAO_TAP_CHI_CO_THE_MUONTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_DS_BAO_TAP_CHI_CO_THE_MUONGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDKI;
        private DevExpress.XtraGrid.Columns.GridColumn colTENTAPCHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNXB;
        private DevExpress.XtraGrid.Columns.GridColumn colDINHKI;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTaiLai;
        private DevExpress.XtraEditors.SimpleButton btnLoaiBo;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnHoanTat;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dvGioTapChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTAPCHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DINHKI;
        private System.Windows.Forms.BindingSource cT_MUONBAOBindingSource;
        private DSTableAdapters.CT_MUONBAOTableAdapter cT_MUONBAOTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtSoNgay;
    }
}