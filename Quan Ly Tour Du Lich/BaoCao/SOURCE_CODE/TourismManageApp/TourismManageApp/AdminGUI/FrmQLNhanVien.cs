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
    public partial class FrmQLNhanVien : Form
    {
        FrmQLNhanVienBLL bll = new FrmQLNhanVienBLL();
        public FrmQLNhanVien()
        {
            InitializeComponent();
            load();
            DefineColumnTable_KH();
            datagritview.RowTemplate.Height = 40;
            datagritview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            datagritview.ColumnHeadersHeight = 40;
        }
        void load()
        {
            datagritview.DataSource = bll.layDSNV();
            set_enable_false();

        }
        private void DefineColumnTable_KH()
        {
            datagritview.Columns[0].HeaderText = "Mã Nhân Viên";
            datagritview.Columns[1].HeaderText = "Họ Tên";
            datagritview.Columns[2].HeaderText = "Số Điện Thoại";
            datagritview.Columns[3].HeaderText = "Email";
            datagritview.Columns[4].HeaderText = "Địa Chỉ";
            datagritview.Columns[5].HeaderText = "Giới Tính";
            datagritview.Columns[6].HeaderText = "Ngày Sinh";
            datagritview.Columns[7].HeaderText = "CCCD";
            datagritview.Columns[8].HeaderText = "Chức Vụ";
            datagritview.Columns[9].HeaderText = "Tình Trạng";
            datagritview.Columns[10].HeaderText = "Mã Người Dùng";


        }
        void set_enable_false()
        {
            txtmanv.Enabled = false;
            txtmand.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            b.Enabled = true;

        }
        void set_enable_true()
        {
            txtmanv.Enabled = true;
            txtmand.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            b.Enabled = false;

        }

        private void datagritview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maNhanVien = Convert.ToInt32(datagritview.Rows[e.RowIndex].Cells["MaNV"].Value);
                NhanVien nhanVien = bll.LayThongTinNV(maNhanVien);

                if (nhanVien != null)
                {

                    txtmanv.Text = nhanVien.MaNV.ToString();
                    txttennv.Text = nhanVien.TenNV;
                    txtsdt.Text = nhanVien.Sdt;
                    txtemail.Text = nhanVien.Email;
                    txtdiachi.Text = nhanVien.DiaChi;
                    txtgioitinh.Text = nhanVien.GioiTinh;
                    txtngaysinh.Text = nhanVien.NgaySinh.ToString();
                    txtcccd.Text = nhanVien.CCCD;
                    txtchucvu.Text = nhanVien.ChucVu;
                    txttinhtrang.Text = nhanVien.TinhTrang;
                    txtmand.Text = nhanVien.MaND.ToString();

                }
            }
        }
        public bool ktrNgay()
        {
            if (DateTime.TryParse(txtngaysinh.Text, out DateTime enteredDate) && enteredDate > DateTime.Now)
            {
                MessageBox.Show("Lỗi ngày sinh");
                return false;
            }
            return true;
        }
        public bool ktDieuKien()
        {
            // Kiểm tra rỗng cho các TextBox và ComboBox
            if (string.IsNullOrEmpty(txttennv.Text) ||
                string.IsNullOrEmpty(txtdiachi.Text) ||
                string.IsNullOrEmpty(txtngaysinh.Text) ||
                string.IsNullOrEmpty(txtsdt.Text) ||
                string.IsNullOrEmpty(txtgioitinh.Text) ||
                string.IsNullOrEmpty(txtemail.Text) ||
                string.IsNullOrEmpty(txtchucvu.Text) ||
                string.IsNullOrEmpty(txttinhtrang.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ");
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ktDieuKien() || ktrNgay() == true)
            {
                NhanVien nv = new NhanVien()
                {
                    MaNV = int.Parse(txtmanv.Text),
                    TenNV = txttennv.Text,
                    GioiTinh = txtgioitinh.Text,
                    DiaChi = txtdiachi.Text,
                    Sdt = txtsdt.Text,
                    NgaySinh = DateTime.Parse(txtngaysinh.Text),
                    Email = txtemail.Text,
                    MaND = int.Parse(txtmand.Text),
                    ChucVu = txtchucvu.Text,
                    CCCD = txtcccd.Text,
                    TinhTrang = txttinhtrang.Text
                };
                bll.ThemNV(nv);
                MessageBox.Show("Thêm thành công");
                load();
            }
            else
            {

                MessageBox.Show("Thêm thất bại!");
                return;

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maNhanVien = Convert.ToInt32(txtmanv.Text);
            NhanVien nvToUpdate = bll.LayThongTinNV(maNhanVien);

            if (nvToUpdate != null && ktrNgay() == true)
            {

                nvToUpdate.TenNV = txttennv.Text;
                nvToUpdate.Sdt = txtsdt.Text;
                nvToUpdate.Email = txtemail.Text;
                nvToUpdate.DiaChi = txtdiachi.Text;
                nvToUpdate.GioiTinh = txtgioitinh.Text;
                nvToUpdate.NgaySinh = DateTime.Parse(txtngaysinh.Text);
                nvToUpdate.CCCD = txtcccd.Text;
                nvToUpdate.ChucVu = txtchucvu.Text;
                nvToUpdate.TinhTrang = txttinhtrang.Text;
                // Cập nhật các thông tin khác nếu cần
                bll.CapNhatNhanvien(maNhanVien, nvToUpdate);
                MessageBox.Show("Sửa thành công");
                load();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
                return;
            }
        }
        void clear_all()
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            txtsdt.Text = "";
            txtemail.Text = "";
            txtdiachi.Text = "";
            txtgioitinh.Text = "";
            txtngaysinh.Text = "";
            txtcccd.Text = "";
            txtchucvu.Text = "";
            txttinhtrang.Text = "";
            txtmand.Text = "";
            txttennv.Focus();
        }

        private void b_Click(object sender, EventArgs e)
        {
            set_enable_true();
            clear_all();
        }
    }
}
