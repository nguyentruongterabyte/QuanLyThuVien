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
    public partial class frmSaoLuu : DevExpress.XtraEditors.XtraForm
    {
        public frmSaoLuu()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = dlg.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string database = Program.conn.Database.ToString();
            if (Validator.isEmptyText(txtPath.Text))
            {
                MessageBox.Show("Vui lòng chọn thư mục!");
                return;
            }

            string cmd = $"BACKUP DATABASE [{database}] TO DISK = '{txtPath.Text}\\database-{DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss")}.bak'";
            try
            {
                Program.KetNoi();
                Program.ExecSqlNonQuery(cmd);
                MessageBox.Show("Sao lưu database thành công!");
            } catch (Exception ex)
            {
                MessageBox.Show("Sao lưu thất bại!\n" + ex.Message);
            }
        }
    }
}
