using DevExpress.Drawing.Internal.Fonts;
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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();



        
        public frmDangNhap()
        {
            InitializeComponent();
        }

       

        

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

            
            cmbVaiTro.DataSource = new Dictionary<String, String>
            {
                {"DOC_GIA", "Độc giả"},
                {"THU_THU", "Thủ thư"}
            }.ToList();

            cmbVaiTro.ValueMember = "Key";
            cmbVaiTro.DisplayMember = "Value";

            cmbVaiTro.SelectedIndex = 1;
            cmbVaiTro.SelectedIndex = 0;

            txtPass.PasswordChar = '*';
            btnDangNhap.Enabled = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (Validator.isEmptyText(txtLogin.Text))
            {
                MessageBox.Show("Tên tài khoản không được bỏ trống!", "Thông báo", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }

            if (Validator.isEmptyText(txtPass.Text))
            {
                MessageBox.Show("Mật khẩu không được bỏ trống!", "Thông báo", MessageBoxButtons.OK);
                txtPass.Focus();
                return;
            }

       
            Program.mlogin = txtLogin.Text;
            Program.password = txtPass.Text;


            if (Program.KetNoi() == 0)
            {
                return;
            };

        
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;


            string vaiTro = cmbVaiTro.SelectedValue.ToString();
            string strLenh = $"EXEC SP_LAY_THONG_TIN_{vaiTro}_TU_LOGIN '{Program.mlogin}'";
            
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                MessageBox.Show("Không thể lấy thông tin từ đăng nhập!", "", MessageBoxButtons.OK);
                return;
            }

            Program.myReader.Read();
            Program.username = Program.myReader.GetString(0);
            
            if (Program.myReader.IsDBNull(1))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\nBạn xem lại username, password",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            
            

            if (Program.myReader.IsDBNull(1))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\nBạn xem lại username, password",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Program.mHoTen = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();

            Program.myReader.Close();
            Program.conn.Close();


            Program.frmChinh.btnDangNhap.Enabled = false;
            Program.frmChinh.btnDangXuat.Enabled = true;

            MessageBox.Show($"Đăng nhập thành công vào tài khoản {Program.mloginDN}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            Program.frmChinh.HienThiMenu();

            btnDangNhap.Enabled = false;
            this.Close();
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            Program.frmChinh.Close();
        }

       
    }
}