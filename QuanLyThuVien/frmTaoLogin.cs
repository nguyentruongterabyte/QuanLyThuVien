using QuanLyThuVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmTaoLogin : DevExpress.XtraEditors.XtraForm
    {

        private void TaoLogin(string lgName, string pass, string username, string role)
        {
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int state = Program.ExecSqlNonQuery($"EXEC SP_TAOLOGIN '{lgName}', N'{pass}', '{username}', '{role}'");

            if (state == 0)
            {
                MessageBox.Show("Tạo login thành công!"
                    + $"\nBạn nên ghi nhớ - tên tài khoản: '{lgName}' - mật khẩu: '{pass}'"
                    , "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        

        private void LayUsernameLogin(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) 
            { 
                Program.conn.Open(); 
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            Program.conn.Close();

            cmbUsername.DataSource = dt;
            cmbUsername.DisplayMember = "TEN";
            cmbUsername.ValueMember = "MADOCGIA";
        }
        

        public frmTaoLogin()
        {
            InitializeComponent();
        }

        private void frmTaoLogin_Load(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0)
            { return; }
            LayUsernameLogin("SELECT * FROM V_DOC_GIA");
            cmbUsername.SelectedIndex = 1;
            cmbUsername.SelectedIndex = 0;

           

            txtPass.PasswordChar = '*';
            txtRetype.PasswordChar = '*';
        }

        private void chkHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThi.Checked)
            {
                txtPass.PasswordChar = default;
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void chkRetypeHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRetypeHienThi.Checked)
            {
                txtRetype.PasswordChar = default;
            }
            else
            {
                txtRetype.PasswordChar = '*';
            }

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            // Validate
            if (Validator.isEmptyText(txtLogin.Text))
            {
                MessageBox.Show("Tên tài khoản không được bỏ trống!", "", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }
            if (Validator.isContainSpecialCharacters(txtLogin.Text))
            {
                MessageBox.Show("Tên tài khoản không được chứa khoảng trắng hoặc ký tự đặc biệt!", "", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }


            if (Validator.isEmptyText(txtPass.Text))
            {
                MessageBox.Show("Mật khẩu không được bỏ trống!", "", MessageBoxButtons.OK);
                txtPass.Focus();
                return;
            }

            if (Validator.minLengthPassword(txtPass.Text, 3))
            {
                MessageBox.Show("Mật khẩu phải ít nhất 3 ký tự", "", MessageBoxButtons.OK);
                txtPass.Focus();
                return;
            }
            if (Validator.isEmptyText(txtRetype.Text)) 
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu!", "", MessageBoxButtons.OK);
                txtRetype.Focus();
                return;
            }
            if (Validator.checkConfirmPassword(txtPass.Text, txtRetype.Text))
            {
                
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "", MessageBoxButtons.OK);
                txtRetype.Focus();
                return;
            }

            if (Validator.isEmptyText(txtPass.Text))
            {
                MessageBox.Show("Mật khẩu không được chứa ký tự trắng", "");
                txtPass.Focus();
                return;
            }

            string lgName = txtLogin.Text.Trim();
            string pass = txtPass.Text.Trim();
            string username = cmbUsername.SelectedValue.ToString();
           
            TaoLogin(lgName, pass, username, "DOCGIA");

            
        }

        private void cmbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
