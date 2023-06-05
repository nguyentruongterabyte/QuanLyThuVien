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
    public partial class frmMuonTapChi : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        public frmMuonTapChi()
        {
            InitializeComponent();
        }

        private void sP_DS_BAO_TAP_CHI_CO_THE_MUONGridControl_Click(object sender, EventArgs e)
        {
            sP_DS_BAO_TAP_CHI_CO_THE_MUONTableAdapter.Connection.ConnectionString = Program.connstr;
            sP_DS_BAO_TAP_CHI_CO_THE_MUONTableAdapter.Fill(dS.SP_DS_BAO_TAP_CHI_CO_THE_MUON, Program.username);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (bdsTapChi.Count == 0)
            {
                MessageBox.Show("Không có gì dể mượn!");
                return;
            }

            vitri = bdsTapChi.Position;
            DataRowView currentRow = (DataRowView)bdsTapChi.Current;
            DataGridViewRow tapChiMuonMoi = dvGioTapChi.Rows[dvGioTapChi.Rows.Add()];

            tapChiMuonMoi.Cells["IDKI"].Value = currentRow["IDKI"];
            tapChiMuonMoi.Cells["TENTAPCHI"].Value = currentRow["TENTAPCHI"];
            tapChiMuonMoi.Cells["NXB"].Value = currentRow["NXB"];
            tapChiMuonMoi.Cells["DINHKI"].Value = currentRow["DINHKI"];

            bdsTapChi.RemoveAt(vitri);
        }

        private void btnLoaiBo_Click(object sender, EventArgs e)
        {
            if (dvGioTapChi.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dvGioTapChi.SelectedRows[0];

                // Lấy giá trị từ dòng được chọn
                object[] values = new object[selectedRow.Cells.Count];
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {

                    values[i] = selectedRow.Cells[i].Value;
                }

                // Thêm dòng mới vào bdsSachCoTheMuon và gán giá trị từ dòng được chọn
                DataRowView newRow = (DataRowView)bdsTapChi.AddNew();
                newRow.Row.ItemArray = values;

                // Xóa dòng từ dvGioSach
                dvGioTapChi.Rows.Remove(selectedRow);
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_DS_BAO_TAP_CHI_CO_THE_MUONTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_DS_BAO_TAP_CHI_CO_THE_MUONTableAdapter.Fill(this.dS.SP_DS_BAO_TAP_CHI_CO_THE_MUON, Program.username);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lại!\n" + ex.Message);
            }
        }

        private void frmMuonTapChi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.CT_MUONBAO' table. You can move, or remove it, as needed.
            this.cT_MUONBAOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_MUONBAOTableAdapter.Fill(this.dS.CT_MUONBAO);
            sP_DS_BAO_TAP_CHI_CO_THE_MUONTableAdapter.Connection.ConnectionString = Program.connstr;
            sP_DS_BAO_TAP_CHI_CO_THE_MUONTableAdapter.Fill(dS.SP_DS_BAO_TAP_CHI_CO_THE_MUON, Program.username);

        }

        private void txtSoNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
