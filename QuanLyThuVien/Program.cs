using DevExpress.Skins;
using DevExpress.UserSkins;
using QLDSV_TC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    internal static class Program
    {

        public static SqlConnection conn = new SqlConnection();
        public static string connstr;
        public static string mlogin = "";
        public static string password = "";

        public static string mloginDN = "";
        public static string passwordDN = "";
        public static SqlDataReader myReader;

        public static string mGroup = "";
        public static string username = "";
        public static string mHoTen = "";

        public static frmMain frmChinh;

        // sửa kết nối ở đây
        public static string servername = "DELLLATITUDEE65";
        public static string database = "THUVIEN";
        
        //
        public static int KetNoi()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                connstr = $"Data Source={servername}; Initial Catalog={database}; User ID={mlogin}; " +
                    $"; password={password}";
                conn.ConnectionString = connstr;
                conn.Open();
                return 1;
            } catch (Exception ex) 
            {
                MessageBox.Show($"Lỗi kết nối cơ sở dữ liệu.\n Bạn xem lại tài khoản và mật khẩu\n{ex.Message}");
                return 0;
            }
        }

        public static void DangXuat()
        {
            // Set các ribbon về trạng thái Visible = false
            frmChinh.ribDanhMuc.Visible = frmChinh.ribBaoCaoTK.Visible = frmChinh.ribMuonTraSach.Visible = false;

            // Xóa các login, password, ... của người dùng trước và trả về giá trị ban đầu 
            //Program.servername = Program.username = Program.mlogin = Program.password 
            //= Program.mloginDN = Program.passwordDN = Program.mGroup = Program.mHoTen = "";

           

            // Set button đăng nhập ở trạng thái enable = true
            frmChinh.btnDangNhap.Enabled = true;

            // Set button đăng xuất ở trạng thái enable = false vì tài khoản đã bị
            // đăng xuất không thể bị đăng xuất lần nữa
            frmChinh.btnDangXuat.Enabled = false;

          

            // Disable nut đổi mật
            frmChinh.btnDoiMK.Enabled = false;

            // Đóng tất cả các form trong form chính (Mdi)
            frmChinh.closeAllFormInFormMain();

            // Set các label của statusStrip về trạng thái default
            frmChinh.lbHoTen.Text = "Họ tên: ";
            frmChinh.lbNhom.Text = "Nhóm: ";
            frmChinh.lbMa.Text = "Mã: ";


            frmDangNhap f = new frmDangNhap();
            f.MdiParent = frmChinh;
            f.Show();


        }

        // Cho phép xem, xóa, sửa, thêm.
        // Nhược điểm: tải dữ liệu chậm hơn so với datareader
        public static DataTable ExecSqlDataTable(string cmd)
        {
            DataTable dt = new DataTable();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        // Tải dữ liệu chỉ cho phép đọc, không cho hiệu chỉnh.
        // Ưu điểm tải dữ về rất nhanh
        public static SqlDataReader ExecSqlDataReader(string cmd)
        {
            SqlDataReader myReader;
            SqlCommand sqlCommand = new SqlCommand(cmd, conn);
            SqlCommand sqlcmd = sqlCommand;
            sqlcmd.CommandType = CommandType.Text;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            try
            {
                myReader = sqlcmd.ExecuteReader();
                return myReader;
            }
            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show(e.Message);
                return null;
            }
        }

        // Thực thi câu lệnh cập nhật trên sp đó không trả về Số liệu
        public static int ExecSqlNonQuery(string cmd)
        {
            SqlCommand sqlCommand = new SqlCommand(cmd, conn);
            SqlCommand sqlcmd = sqlCommand;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            try
            {
                sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            } catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return e.State;
            }
            
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }
    }
}
