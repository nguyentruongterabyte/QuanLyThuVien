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
    public partial class frmPhucHoi : DevExpress.XtraEditors.XtraForm
    {
        public frmPhucHoi()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL SERVER database backup files|*.bak";
            ofd.Title = "Database restore";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofd.FileName;
                btnRestore.Enabled = true;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (Validator.isEmptyText(txtPath.Text))
            {
                MessageBox.Show("Vui lòng chọn file phục hồi .bak");
                return;
            }
            string database = Program.conn.Database.ToString();

            if (MessageBox.Show("Bạn có chắc muốn phục hồi dữ liệu từ file này?\nLưu ý: Những thao tác của bạn từ thời điểm file này được sao lưu sẽ bị mất!",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1)
             == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    
                    string str1 = string.Format($"ALTER DATABASE [{database}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    Program.KetNoi();
                    Program.ExecSqlNonQuery(str1);


                    string str2 = $"USE MASTER RESTORE DATABASE [{database}] FROM DISK = '{txtPath.Text}' WITH REPLACE;";
                    Program.KetNoi();
                    Program.ExecSqlNonQuery(str2);

                    string str3 = string.Format($"ALTER DATABASE [{database}] SET MULTI_USER");
                    Program.KetNoi();
                    Program.ExecSqlNonQuery(str3);

                    
                    MessageBox.Show("Phục hồi dữ liệu thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Phục hồi dữ liệu thất bại!\n" + ex.Message);
                }
            }

        }
    }
}
