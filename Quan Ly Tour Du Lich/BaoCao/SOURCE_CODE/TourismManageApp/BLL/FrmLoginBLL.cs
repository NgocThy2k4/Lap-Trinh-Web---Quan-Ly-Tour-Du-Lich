using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BLL
{
    public class FrmLoginBLL
    {
        TourismManageAppBLLDataContext db = new TourismManageAppBLLDataContext();
        private static string _tenDangNhap;

        public static string TenDangNhap
        {
            get { return _tenDangNhap; }
        }
        public void SetTenDangNhap(string tenDangNhap)
        {
            _tenDangNhap = tenDangNhap;
        }
        public bool checkDangNhap(string username, string password)
        {

            var user = (from u in db.NguoiDungs
                        where u.TenND == username && u.MatKhau == password
                        select u).SingleOrDefault();


            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công!");
                return true;
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công. Tài khoản hoặc mật khẩu không đúng.");
                return false;
            }
        }
        public int LayQuyen(string username)
        {
            var user = (from u in db.NguoiDungs
                        where u.TenND == username
                        select u).SingleOrDefault();

            if (user != null)
            {
                return user.MaPQ ?? 0;
            }

            return 0; // Trả về một giá trị mặc định nếu không tìm thấy người dùng
        }
        public int LayMaNV(string username)
        {
            var nhanVien = (from nd in db.NguoiDungs
                            join nv in db.NhanViens on nd.MaND equals nv.MaND
                            where nd.TenND == username
                            select nv.MaNV).SingleOrDefault();
            return nhanVien;
        }
        public string LayTenNV(string username)
        {
            var nhanVien = (from nd in db.NguoiDungs
                            join nv in db.NhanViens on nd.MaND equals nv.MaND
                            where nd.TenND == username
                            select nv.TenNV).SingleOrDefault();
            return nhanVien;
        }
        public bool BtnDangNhap_Click(string txtTaiKhoan, string txtMatKhau)
        {
            bool loginSuccessful = checkDangNhap(txtTaiKhoan, txtMatKhau);

            if (!loginSuccessful)
            {
                MessageBox.Show("Đăng nhập không thành công. Vui lòng thử lại.");
                return false;


            }
            return true;

        }


    }
}
