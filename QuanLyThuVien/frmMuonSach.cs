using DevExpress.XtraEditors.Popup;
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
    public partial class frmMuonSach : DevExpress.XtraEditors.XtraForm
    {

        int vitri = 0;
        public frmMuonSach()
        {
            InitializeComponent();
        }

        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.CT_MUONSACH' table. You can move, or remove it, as needed.
            this.cT_MUONSACHTableAdapter.Fill(this.dS.CT_MUONSACH);
            // TODO: This line of code loads data into the 'dS.V_SACH_CO_THE_MUON' table. You can move, or remove it, as needed.
            this.v_SACH_CO_THE_MUONTableAdapter.Fill(this.dS.V_SACH_CO_THE_MUON);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            vitri = bdsSachCoTheMuon.Position;
   
            // Lấy vị trí dòng hiện tại được chọn
            DataRowView currentRow = (DataRowView)bdsSachCoTheMuon.Current;
            DataGridViewRow sachMuonMoi = dvGioSach.Rows[dvGioSach.Rows.Add()];
            //sachMuonMoi.Cells["IDSACH"].Value = currentRow["IDSACH"];
            //sachMuonMoi.Cells["MASACH"].Value = currentRow["MASACH"];
            //sachMuonMoi.Cells["TenSach"].Value = currentRow["TENSACH"];
            //sachMuonMoi.Cells["TinhTrang"].Value = currentRow["TINHTRANG"];
            //sachMuonMoi.Cells[""].Value = currentRow["TINHTRANG"];
            //sachMuonMoi.Cells["TinhTrang"].Value = currentRow["TINHTRANG"];
            


        }
    }
}
