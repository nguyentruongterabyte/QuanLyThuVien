﻿namespace QLDSV_TC
{
    partial class frmDoiMK
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkOldPassHienThi = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkRetypeHienThi = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkHienThi = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.txtOldPass = new DevExpress.XtraEditors.TextEdit();
            this.txtRetype = new DevExpress.XtraEditors.TextEdit();
            this.txtNewPass = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRetype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNewPass);
            this.groupBox1.Controls.Add(this.txtRetype);
            this.groupBox1.Controls.Add(this.txtOldPass);
            this.groupBox1.Controls.Add(this.txtLogin);
            this.groupBox1.Controls.Add(this.chkOldPassHienThi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkRetypeHienThi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkHienThi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(399, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(581, 306);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // chkOldPassHienThi
            // 
            this.chkOldPassHienThi.AutoSize = true;
            this.chkOldPassHienThi.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.chkOldPassHienThi.Location = new System.Drawing.Point(475, 108);
            this.chkOldPassHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.chkOldPassHienThi.Name = "chkOldPassHienThi";
            this.chkOldPassHienThi.Size = new System.Drawing.Size(72, 21);
            this.chkOldPassHienThi.TabIndex = 15;
            this.chkOldPassHienThi.Text = "Hiển thị";
            this.chkOldPassHienThi.UseVisualStyleBackColor = true;
            this.chkOldPassHienThi.CheckedChanged += new System.EventHandler(this.chkOldPassHienThi_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label4.Location = new System.Drawing.Point(95, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mật khẩu cũ";
            // 
            // chkRetypeHienThi
            // 
            this.chkRetypeHienThi.AutoSize = true;
            this.chkRetypeHienThi.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.chkRetypeHienThi.Location = new System.Drawing.Point(475, 214);
            this.chkRetypeHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.chkRetypeHienThi.Name = "chkRetypeHienThi";
            this.chkRetypeHienThi.Size = new System.Drawing.Size(72, 21);
            this.chkRetypeHienThi.TabIndex = 12;
            this.chkRetypeHienThi.Text = "Hiển thị";
            this.chkRetypeHienThi.UseVisualStyleBackColor = true;
            this.chkRetypeHienThi.CheckedChanged += new System.EventHandler(this.chkRetypeHienThi_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label1.Location = new System.Drawing.Point(51, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Xác nhận mật khẩu";
            // 
            // chkHienThi
            // 
            this.chkHienThi.AutoSize = true;
            this.chkHienThi.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.chkHienThi.Location = new System.Drawing.Point(475, 161);
            this.chkHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.chkHienThi.Name = "chkHienThi";
            this.chkHienThi.Size = new System.Drawing.Size(72, 21);
            this.chkHienThi.TabIndex = 9;
            this.chkHienThi.Text = "Hiển thị";
            this.chkHienThi.UseVisualStyleBackColor = true;
            this.chkHienThi.CheckedChanged += new System.EventHandler(this.chkHienThi_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label3.Location = new System.Drawing.Point(88, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label2.Location = new System.Drawing.Point(81, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đăng nhập";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Location = new System.Drawing.Point(399, 383);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(168, 37);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu thay đổi";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Enabled = false;
            this.txtLogin.Location = new System.Drawing.Point(190, 47);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(228, 28);
            this.txtLogin.TabIndex = 16;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(190, 108);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(228, 28);
            this.txtOldPass.TabIndex = 17;
            // 
            // txtRetype
            // 
            this.txtRetype.Location = new System.Drawing.Point(190, 213);
            this.txtRetype.Name = "txtRetype";
            this.txtRetype.Size = new System.Drawing.Size(228, 28);
            this.txtRetype.TabIndex = 18;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(190, 158);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(228, 28);
            this.txtNewPass.TabIndex = 19;
            // 
            // frmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 450);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDoiMK";
            this.Text = "Đổi mật khẩu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDoiMK_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRetype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkRetypeHienThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkHienThi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.CheckBox chkOldPassHienThi;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtNewPass;
        private DevExpress.XtraEditors.TextEdit txtRetype;
        private DevExpress.XtraEditors.TextEdit txtOldPass;
        private DevExpress.XtraEditors.TextEdit txtLogin;
    }
}