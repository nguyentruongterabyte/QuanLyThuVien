using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmTapChi : DevExpress.XtraEditors.XtraForm
    {

        int vitri = 0;
        string maTapChi = "";
        public frmTapChi()
        {
            InitializeComponent();
        }

        private void tAPCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTapChi.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmTapChi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.KYXB' table. You can move, or remove it, as needed.
            this.kYXBTableAdapter.Fill(this.dS.KYXB);
            dS.EnforceConstraints = false;

            
            // TODO: This line of code loads data into the 'dS.TAPCHI' table. You can move, or remove it, as needed.
            this.tAPCHITableAdapter.Fill(this.dS.TAPCHI);
            groupControl1.Enabled = false;
            if (bdsTapChi.Count == 0)
            {
                btnSua.Enabled = btnXoa.Enabled = false;
            }
            cmbDinhKy.DataSource = new Dictionary<int, string>
            {
                {1, "Hàng ngày"},
                {2, "Hàng tuần"},
                {3, "Hàng tháng"}
            }.ToList();

            cmbDinhKy.ValueMember = "Key";
            cmbDinhKy.DisplayMember = "Value";
            cmbDinhKy.SelectedIndex = 1;
            cmbDinhKy.SelectedIndex = 0;

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            vitri = bdsTapChi.Position;
            cmbDinhKy.SelectedIndex = 1;
            cmbDinhKy.SelectedIndex = 0;

            bdsTapChi.AddNew();
            gcTapChi.Enabled = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;

            groupControl1.Enabled = btnHuy.Enabled = btnGhi.Enabled = true;
            txtMaTL.Text = "TAPCHI";
            txtDinhKy.Text = "1";
            
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsKyXB.Count > 0)
            {
                MessageBox.Show("Không thể xóa tạp chí này do đã xuất bản!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xoá tạp chí này?", "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    maTapChi = ((DataRowView)bdsTapChi[bdsTapChi.Position])["MATAPCHI"].ToString();
                    bdsTapChi.RemoveCurrent();
                    this.tAPCHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.tAPCHITableAdapter.Update(this.dS.TAPCHI);
                    btnLamMoi.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá tạp chí!\n" + ex.Message);
                    this.tAPCHITableAdapter.Fill(this.dS.TAPCHI);
                    bdsTapChi.Position = bdsTapChi.Find("MATAPCHI", maTapChi);
                    return;
                }
            }
            if (bdsTapChi.Count == 0)
            {
                btnXoa.Enabled = btnSua.Enabled = false;
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsTapChi.Position;

            gcTapChi.Enabled = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;

            groupControl1.Enabled = btnHuy.Enabled = btnGhi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Validator.isEmptyText(txtMaTC.Text))
            {
                MessageBox.Show("Không được để trống mã tạp chí!");
                return;
            }
            if (Validator.isEmptyText(txtNXB.Text))
            {
                MessageBox.Show("Không được để trống nhà xuất bản!");
                return;
            }

            if (Validator.isEmptyText(txtTenTC.Text))
            {
                MessageBox.Show("Không được để trống tên tạp chí!");
                return;
            }

            try
            {
                bdsTapChi.EndEdit();
                bdsTapChi.ResetCurrentItem();
                this.tAPCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.tAPCHITableAdapter.Update(this.dS.TAPCHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi tạp chí\n" + ex.Message);
                return;
            }
            gcTapChi.Enabled = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
            groupControl1.Enabled = btnHuy.Enabled = btnGhi.Enabled = false;

        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTapChi.CancelEdit();
            bdsTapChi.Position = vitri;
            gcTapChi.Enabled = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
            groupControl1.Enabled = btnHuy.Enabled = btnGhi.Enabled = false;

        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.tAPCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.tAPCHITableAdapter.Fill(this.dS.TAPCHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload\n" + ex.Message);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đóng cửa sổ tạp chí?",
                 "Xác nhận",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1)
              == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cmbDinhKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDinhKy.Text = cmbDinhKy.SelectedValue.ToString() ;
        }

        private void txtDinhKy_TextChanged(object sender, EventArgs e)
        {
            cmbDinhKy.SelectedIndex = int.Parse(txtDinhKy.Text) - 1;
        }
    }
}
