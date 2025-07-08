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
    public partial class FrmQLTTKhachHang : Form
    {
        FrmQLTTKhachHangBLL bll = new FrmQLTTKhachHangBLL();
        public FrmQLTTKhachHang()
        {
            InitializeComponent();
            load();
            DefineColumnTable_KH();
            set_enable_false();
            guna2DataGridView1.RowTemplate.Height = 40;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            guna2DataGridView1.ColumnHeadersHeight = 40;
        }
        void load()
        {
            guna2DataGridView1.DataSource = bll.layDSKH();

        }
        private void DefineColumnTable_KH()
        {
            guna2DataGridView1.Columns[0].HeaderText = "Mã Khách Hàng";
            guna2DataGridView1.Columns[1].HeaderText = "Họ Tên";
            guna2DataGridView1.Columns[2].HeaderText = "Giới tính";
            guna2DataGridView1.Columns[3].HeaderText = "Ngày Sinh";
            guna2DataGridView1.Columns[4].HeaderText = "Địa Chỉ";
            guna2DataGridView1.Columns[5].HeaderText = "Số Điện Thoại";
            guna2DataGridView1.Columns[6].HeaderText = "Mã Người Dùng";


        }
        void set_enable_false()
        {
            txtmakh.Enabled = false;
            txtmand.Enabled = false;

        }
        public bool ktrNgay()
        {
            if (DateTime.TryParse(guna2DateTimePicker1.Text, out DateTime enteredDate) && enteredDate > DateTime.Now)
            {
                MessageBox.Show("Lỗi ngày sinh");
                return false;
            }
            return true;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maKhachHang = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["MaKH"].Value);
                DaiDienKH khachHang = bll.LayThongTinKhachHang(maKhachHang);

                if (khachHang != null)
                {
                    txtmakh.Text = khachHang.MaKH.ToString();
                    txttenkh.Text = khachHang.TenKH;
                    txtdiachi.Text = khachHang.DiaChi;
                    txtsdt.Text = khachHang.Sdt;
                    txtgioitinh.Text = khachHang.GioiTinh;
                    guna2DateTimePicker1.Text = khachHang.NgaySinh.ToString();
                    txtmand.Text = khachHang.MaND.ToString();


                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int maKhachHang = Convert.ToInt32(txtmakh.Text);
            DaiDienKH khachHangToUpdate = bll.LayThongTinKhachHang(maKhachHang);

            if (khachHangToUpdate != null && ktrNgay() == true)
            {
                khachHangToUpdate.TenKH = txttenkh.Text;
                khachHangToUpdate.DiaChi = txtdiachi.Text;
                khachHangToUpdate.Sdt = txtsdt.Text;
                khachHangToUpdate.NgaySinh = DateTime.Parse(guna2DateTimePicker1.Text);
                khachHangToUpdate.GioiTinh = txtgioitinh.Text;
                // Cập nhật các thông tin khác nếu cần
                bll.CapNhatKhachHang(maKhachHang, khachHangToUpdate);
                MessageBox.Show("Sửa thành công");
                load();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
                return;
            }
        }
    }
}
