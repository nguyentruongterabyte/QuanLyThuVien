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
    public partial class frmKyXB : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string idKi = "";
        bool chucnang = false;
        int soLuongNhap = 0;
        int luongMuon;
        public frmKyXB()
        {
            InitializeComponent();
        }

        private void frmKyXB_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.V_TAP_CHI' table. You can move, or remove it, as needed.
            this.v_TAP_CHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_TAP_CHITableAdapter.Fill(this.dS.V_TAP_CHI);
            // TODO: This line of code loads data into the 'dS.KYXB' table. You can move, or remove it, as needed.
            this.kYXBTableAdapter.Connection.ConnectionString = Program.connstr;
            this.kYXBTableAdapter.Fill(this.dS.KYXB);
            // TODO: This line of code loads data into the 'dS.V_DANH_SACH_KY_XB_TAP_CHI' table. You can move, or remove it, as needed.
            this.v_DANH_SACH_KY_XB_TAP_CHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DANH_SACH_KY_XB_TAP_CHITableAdapter.Fill(this.dS.V_DANH_SACH_KY_XB_TAP_CHI);

            // TODO: This line of code loads data into the 'dS.CT_MUONBAO' table. You can move, or remove it, as needed.
            this.cT_MUONBAOTableAdapter.Connection.ConnectionString = Program.connstr;  
            this.cT_MUONBAOTableAdapter.Fill(this.dS.CT_MUONBAO);

            if (txtMaTapChi.SelectedValue != null)
            {
                txtMaTapChi.Text = txtMaTapChi.SelectedValue.ToString();
            }

        }
        
        private void txtLuongNhap2_EditValueChanged(object sender, EventArgs e)
        {
            if (chucnang)
            {
                txtLuongTon.Text = txtLuongNhap.Text;
            }
            else if(chucnang == false)
            {
                if(Convert.ToInt32(txtLuongNhap.Text) - luongMuon >= 0)
                {
                    txtLuongTon.Text = (Convert.ToInt32(txtLuongNhap.Text) - luongMuon).ToString();
                }
                else
                {
                    MessageBox.Show("Lượng nhập không hợp lệ, tối thiểu là " + luongMuon, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void txtLuongTon2_EditValueChanged(object sender, EventArgs e)
        {
            txtLuongTon.Text = txtLuongTon.Text;
        }

        

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsViewKyXB.Position;
            chucnang = true;
            bdsViewKyXB.AddNew();
            bdsKyXB.AddNew();

            txtLuongTon.Enabled = false;
            gcKyXB.Enabled = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = groupControl1.Enabled = true;
            
            if (txtMaTapChi.SelectedValue != null)
            {
                txtMaTapChi.Text = txtMaTapChi.SelectedValue.ToString();
            }

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTMuonBao.Count > 0)
            {
                MessageBox.Show("Không thể xóa kỳ xuất bản bởi vì đã có người mượn báo trong kỳ này!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xoá nhà xuất bản này?", "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                int state = 1;
                try
                {
                    idKi = ((DataRowView)bdsViewKyXB[bdsViewKyXB.Position])["IDKI"].ToString();
                    Program.KetNoi();
                    state = Program.ExecSqlNonQuery($"EXEC SP_XOA_KYXB_TAP_CHI {idKi}");
                    
                } catch (Exception ex) {
                    MessageBox.Show("Lỗi xóa kỳ xuất bản\n" + ex.Message);
                    this.v_DANH_SACH_KY_XB_TAP_CHITableAdapter.Fill(this.dS.V_DANH_SACH_KY_XB_TAP_CHI);
                    bdsViewKyXB.Position = bdsViewKyXB.Find("IDKI", idKi);
                    return;
                }
                if (state == 0)
                {
                    MessageBox.Show("Xóa thành công!");
                } else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chucnang = false;
            idKi = ((DataRowView)bdsViewKyXB[bdsViewKyXB.Position])["IDKI"].ToString();
            txtLuongTon.Enabled = false;
            luongMuon = Convert.ToInt32(((DataRowView)bdsViewKyXB[bdsViewKyXB.Position])["LUONGNHAP"].ToString()) - Convert.ToInt32(((DataRowView)bdsViewKyXB[bdsViewKyXB.Position])["LUONGTON"].ToString());
            gcKyXB.Enabled = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = txtLuongTon.Enabled = groupControl1.Enabled = true;
            txtLuongTon.Enabled = false;
            soLuongNhap = int.Parse(txtLuongNhap.Text);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

            if (Validator.isEmptyText(txtLuongNhap.Text))
            {
                MessageBox.Show("Không được để trống lượng nhập!");
                return;

            }

            if (Validator.isEmptyText(txtLuongTon.Text))
            {
                MessageBox.Show("Không được để trống lượng tồn!");
                return;
            }
          

            if (chucnang)
            {
                //Add
                bdsViewKyXB.EndEdit();
                bdsKyXB.EndEdit();
                Program.KetNoi();
                int state = Program.ExecSqlNonQuery($"EXEC SP_INSERT_KYXB_TAPCHI {txtLuongNhap.Text}, {txtLuongTon.Text}, '{txtMaTapChi2.Text}'");
                if (state == 0)
                {
                    MessageBox.Show("Thêm mới thành công!");

                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại!");
                    return;
                }

            }
            else
            {
                //Update
                Program.KetNoi();
                int state = Program.ExecSqlNonQuery($"EXEC SP_UPDATE_KYXB_TAPCHI {idKi}, {txtLuongNhap.Text}, {txtLuongTon.Text}, '{txtMaTapChi2.Text}'");
                if (state == 0)
                {
                    MessageBox.Show("Cập nhật thành công!");

                } else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                    return;
                }
            }
            gcKyXB.Enabled = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
            txtLuongTon.Enabled = groupControl1.Enabled = false;
            btnLamMoi.PerformClick();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsViewKyXB.CancelEdit();
            bdsKyXB.CancelEdit();
            gcKyXB.Enabled = btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;

            txtLuongTon.Enabled = btnGhi.Enabled = btnHuy.Enabled = groupControl1.Enabled = false;
        }

        private void frmKyXB_FormClosing(object sender, FormClosingEventArgs e)
        {
       
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                v_DANH_SACH_KY_XB_TAP_CHITableAdapter.Connection.ConnectionString = Program.connstr;
                v_DANH_SACH_KY_XB_TAP_CHITableAdapter.Fill(this.dS.V_DANH_SACH_KY_XB_TAP_CHI);
            } catch(Exception ex)
            {
                MessageBox.Show("Lỗi reload!\n" + ex.Message);
            }

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đóng của sổ kỳ xuất bản?", "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtLuongNhap2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLuongTon2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaTapChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtMaTapChi.SelectedValue != null)
            {
                txtMaTapChi2.Text = txtMaTapChi.SelectedValue.ToString();
            }
        }
    }
}
