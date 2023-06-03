using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmSach : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string maSach = "";

        public frmSach()
        {
            InitializeComponent();
        }

        private void sACHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSach.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.dS.SACH);
            // TODO: This line of code loads data into the 'dS.TAILIEU' table. You can move, or remove it, as needed.
            this.tAILIEUTableAdapter.Fill(this.dS.TAILIEU);
            // TODO: This line of code loads data into the 'dS.CT_SACH' table. You can move, or remove it, as needed.
            this.cT_SACHTableAdapter.Fill(this.dS.CT_SACH);
            // TODO: This line of code loads data into the 'dS.V_Tac_Gia' table. You can move, or remove it, as needed.
            this.v_Tac_GiaTableAdapter.Fill(this.dS.V_Tac_Gia);
            // TODO: This line of code loads data into the 'dS.V_Tac_Gia' table. You can move, or remove it, as needed.
            this.v_Tac_GiaTableAdapter.Fill(this.dS.V_Tac_Gia);
            // TODO: This line of code loads data into the 'dS.CT_SACH' table. You can move, or remove it, as needed.
            this.cT_SACHTableAdapter.Fill(this.dS.CT_SACH);

          
            if (bdsSach.Count == 0)
            {
                btnSua.Enabled = btnXoa.Enabled = false;
            }
        }

 

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsSach.Position;

            bdsSach.AddNew();
            gcSach.Enabled = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;

            groupControl1.Enabled = btnHuy.Enabled = btnGhi.Enabled = true;
            txtMaTL.Text = "SACH";
            
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSach.CancelEdit();
            
            bdsSach.Position = vitri;
            gcSach.Enabled = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
            groupControl1.Enabled = btnHuy.Enabled = btnGhi.Enabled = false;
        }

        private void dgvCT_Sach_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            
        }

       

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (Validator.isEmptyText(txtMaSach.Text))
            {
                MessageBox.Show("Không được bỏ trống mã sách!");
                return;
            }
            
           

            if (Validator.isEmptyText(txtTenSach.Text))
            {
                MessageBox.Show("Không được bỏ trống tên sách!");
                return;
            }

            if (bdsCTSach.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn tác giả cho sách này!");
                return;
            }

            string maSach = txtMaSach.Text.Trim();
            for (int i = 0; i < bdsCTSach.Count; i++)
            {
                DataRowView rowView = (DataRowView)bdsCTSach[i];
                rowView["MASACH"] = maSach;

            }

            try
            {
                bdsSach.EndEdit();
                bdsSach.ResetCurrentItem();
                this.sACHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sACHTableAdapter.Update(this.dS.SACH);
            } catch(Exception ex)
            {
                MessageBox.Show("Lỗi ghi sách\n" + ex.Message);
                return;
            }

          
            try
                
            {
                bdsCTSach.EndEdit();
                bdsCTSach.ResetCurrentItem();
                this.cT_SACHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cT_SACHTableAdapter.Update(this.dS.CT_SACH);
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi chi tiết sách\n" + ex.Message);
                return;
            }
            gcSach.Enabled = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
            groupControl1.Enabled = btnHuy.Enabled = btnGhi.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa sách này?", "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1)
                == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    maSach = ((DataRowView)bdsSach[bdsSach.Position])["MASACH"].ToString();
                    bdsSach.RemoveCurrent();

                    this.sACHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sACHTableAdapter.Update(this.dS.SACH);
                    btnLamMoi.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sách!\n" + ex.Message);
                    this.sACHTableAdapter.Fill(this.dS.SACH);
                    bdsSach.Position = bdsSach.Find("MASACH", maSach);
                    return;
                }
            }
            if (bdsSach.Count == 0)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsSach.Position;

            gcSach.Enabled = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;

            groupControl1.Enabled = btnHuy.Enabled = btnGhi.Enabled = true;

            
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.sACHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sACHTableAdapter.Fill(this.dS.SACH);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload\n" + ex.Message);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đóng cửa sổ sách?",
                 "Xác nhận",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1)
              == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
