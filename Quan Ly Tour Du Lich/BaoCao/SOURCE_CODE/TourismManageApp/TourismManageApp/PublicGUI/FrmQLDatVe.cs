using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace TourismManageApp.PublicGUI
{
    public partial class FrmQLDatVe : Form
    {
        FrmQLDatVeBLL ql = new FrmQLDatVeBLL();
        public int maNV;
        public FrmQLDatVe(int ma)
        {
            maNV = ma;  
            InitializeComponent();
            dtGVDatVe.RowTemplate.Height = 40;

            dtGVDatVe.ColumnHeadersHeight = 40;
            btnHuyDat.Enabled = false;
            btnThanhToan.Enabled = false;
        }

        private void FrmQLDatVe_Load(object sender, EventArgs e)
        {
            cmbTinhTrangVe.Items.Add("Tất cả");
            cmbTinhTrangVe.Items.Add("Đã đặt");
            cmbTinhTrangVe.Items.Add("Đã hủy");
            cmbTinhTrangVe.Items.Add("Đang xử lý");

        }
        private void DefineColumnTable_DatVe()
        {
            dtGVDatVe.Columns[0].HeaderText = "Mã đặt tour";
    
            dtGVDatVe.Columns[1].HeaderText = "Ngày lập";
            dtGVDatVe.Columns[2].HeaderText = "Mã tour";
            dtGVDatVe.Columns[3].HeaderText = "Tình trạng";

        }
        private void DefineColumnTable_VeXL()
        {
            dtGVDatVe.Columns[0].HeaderText = "Mã đặt tour";
        
            dtGVDatVe.Columns[1].HeaderText = "Ngày lập";
            dtGVDatVe.Columns[2].HeaderText = "Mã tour";
            dtGVDatVe.Columns[3].HeaderText = "Tình trạng";
           
        }
        public void reloadData()
        {
            dtGVDatVe.DataSource = ql.layDSDatVe();
            cmbTinhTrangVe.SelectedIndex = 0;
        }
        private void cmbTinhTrangVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTinhTrangVe.SelectedItem.ToString() == "Tất cả")
            {
                dtGVDatVe.DataSource = ql.layDSDatVe();
                DefineColumnTable_DatVe();
                dtGVDatVe.Enabled = true;
            }
            else if (cmbTinhTrangVe.SelectedItem.ToString() == "Đã đặt")
            {
                dtGVDatVe.DataSource = ql.layDSVeDaDat();
                DefineColumnTable_DatVe();
                dtGVDatVe.Enabled = true;
            }
            else if (cmbTinhTrangVe.SelectedItem.ToString() == "Đã hủy")
            {
                dtGVDatVe.DataSource = ql.layDSVeDaHuy();
                DefineColumnTable_DatVe();
                dtGVDatVe.Enabled = true;
            }
            else if (cmbTinhTrangVe.SelectedItem.ToString() == "Đang xử lý")
            {
                dtGVDatVe.DataSource = ql.layDSVeDangXL();
                DefineColumnTable_VeXL();
                dtGVDatVe.Enabled = false;
            }
        }

        private void dtGVDatVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGVDatVe.Rows[e.RowIndex];

          
                string maVe = row.Cells["MaDatTour"].Value.ToString();
                string maTour = row.Cells["MaTour"].Value.ToString();
                DateTime ngayLap = (DateTime)row.Cells["NgayLap"].Value;

                // Lấy giá trị tình trạng từ ô Cell
                string tinhTrang = row.Cells["TinhTrang"].Value.ToString();

   
                txtMaDatTour.Text = maVe;
                txtMaTour.Text = maTour;
                dtpNgayLap.Value = ngayLap;

        
                if (tinhTrang == "Đã hủy")
                {
                    btnHuyDat.Enabled = false;
                    btnThanhToan.Enabled = false;
                }
                else if(tinhTrang == "Đã đặt")
                {
                    btnThanhToan.Enabled = false;
                }
                else
                {
                    btnHuyDat.Enabled = true;
                    btnThanhToan.Enabled = true;
                }
            }
        }

        private void btnTimMaHD_Click(object sender, EventArgs e)
        {
            try
            {
                int maDatTour = int.Parse(txtMaDatTour.Text);
                dtGVDatVe.DataSource = ql.timDSDatVeTheoMaTour(maDatTour);
                DefineColumnTable_DatVe();
            }
           catch
            {
                MessageBox.Show("Vui lòng nhập mã đặt tour!");
                return;
            }
        }

        private void btlLocKQ_Click(object sender, EventArgs e)
        {
            try
            {
                int maTour = int.Parse(txtMaTour.Text);
                DateTime ngayLap = dtpNgayLap.Value;
                dtGVDatVe.DataSource = ql.timDSDatVeTheoMaVaNgay(maTour, ngayLap);
                DefineColumnTable_DatVe();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập mã tour");
                return;
            }
               
            
           
        }

        private void btnHuyDat_Click(object sender, EventArgs e)
        {
            try
            {
                int maDatTour = int.Parse(txtMaDatTour.Text);
                ql.capNhatHuyVe(maDatTour);
                MessageBox.Show("Hủy vé thành công");
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập mã đặt tour");
                return;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                int maTour = int.Parse(txtMaTour.Text);
                int maDatTour = int.Parse(txtMaDatTour.Text);

                Tour tour = ql.layTourTheoMa(maTour);
                DatTour datTour = ql.layDatTourTheoMa(maDatTour);

                FrmThongTinDatTour fr = new FrmThongTinDatTour(tour, datTour, maNV);
                FrmAdmin trangChu = (FrmAdmin)this.ParentForm;
                trangChu.OpenChildForm(fr);
            }
            catch
            {
                MessageBox.Show("Vui lòng điền đủ thông tin mã đặt tour và mã tour");
            }
            
        }
    }
}
