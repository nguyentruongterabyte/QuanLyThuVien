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
    public partial class frmDocGia : DevExpress.XtraEditors.XtraForm
    {
        public frmDocGia()
        {
            InitializeComponent();
        }

        private void dOCGIABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDocGia.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'dS.DOCGIA' table. You can move, or remove it, as needed.
            this.dOCGIATableAdapter.Fill(this.dS.DOCGIA);

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsDocGia.AddNew();
        }
    }
}
