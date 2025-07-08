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
namespace TourismManageApp.AdminGUI
{
    public partial class FrmQLTaiKhoan : Form
    {
        FrmQLTaiKhoanBLL ql = new FrmQLTaiKhoanBLL();
        public FrmQLTaiKhoan()
        {
            InitializeComponent();
            txtTenTK.Enabled = false;
        }

        private void FrmQLTaiKhoan_Load(object sender, EventArgs e)
        {
         
            dtGVNguoiDung.RowTemplate.Height = 40;
            dtGVNguoiDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtGVNguoiDung.ColumnHeadersHeight = 40;
            cmbTK.Items.Add("Khách hàng");
            cmbTK.Items.Add("Nhân viên");
        }
        private void DefineColumnTable_KH()
        {
            dtGVNguoiDung.Columns[0].HeaderText = "Mã Người dùng";
            dtGVNguoiDung.Columns[1].HeaderText = "Tên Khách Hàng";
            dtGVNguoiDung.Columns[2].HeaderText = "Tên Tài Khoản";
            dtGVNguoiDung.Columns[3].HeaderText = "Mật Khẩu";
            dtGVNguoiDung.Columns[4].HeaderText = "Số Điện Thoại";
            dtGVNguoiDung.RowTemplate.Height = 40;
            dtGVNguoiDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtGVNguoiDung.ColumnHeadersHeight = 40;
        }
        private void DefineColumnTable_NV()
        {
            dtGVNguoiDung.Columns[0].HeaderText = "Mã Người dùng";
            dtGVNguoiDung.Columns[1].HeaderText = "Tên Nhân Viên";
            dtGVNguoiDung.Columns[2].HeaderText = "Tên Tài Khoản";
            dtGVNguoiDung.Columns[3].HeaderText = "Mật Khẩu";
            dtGVNguoiDung.Columns[4].HeaderText = "Số Điện Thoại";
            dtGVNguoiDung.RowTemplate.Height = 40;
            dtGVNguoiDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtGVNguoiDung.ColumnHeadersHeight = 40;
        }
        private void cmbTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTK.SelectedItem.ToString() == "Khách hàng")
            {
                dtGVNguoiDung.DataSource = ql.LayDSTKKhachHang();
                DefineColumnTable_KH();
            }
            else if (cmbTK.SelectedItem.ToString() == "Nhân viên")
            {
                dtGVNguoiDung.DataSource = ql.LayDSTKNhanVien();
                DefineColumnTable_NV();
            }

            
        }

        private void dtGVNguoiDung_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dtGVNguoiDung.Columns["MatKhau"].Index && e.Value != null)
            {
                e.Value = new string('*', 6);
            }
        }

        private void dtGVNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGVNguoiDung.Rows[e.RowIndex];

                // Lấy giá trị từ các cột của dòng được chọn
              
                string tenND = row.Cells["TenND"].Value.ToString();
                string matKhau= row.Cells["MatKhau"].Value.ToString();
         

                // Hiển thị giá trị lên các TextBox và ComboBox
                txtTenTK.Text = tenND;
                txtMKHienTai.Text = matKhau;
                txtMKHienTai.Text = new string('*', 6);
            }
        }
    }
}
