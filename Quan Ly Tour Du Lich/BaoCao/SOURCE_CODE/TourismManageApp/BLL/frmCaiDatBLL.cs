using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FrmCaiDatBLL
    {
        TourismManageAppBLLDataContext db = new TourismManageAppBLLDataContext();
        // Hàm kiểm tra mật khẩu cũ
        public bool KiemTraMatKhauCu(string tenDangNhap, string matKhauCu)
        {
            var user = db.NguoiDungs.FirstOrDefault(u => u.TenND == tenDangNhap && u.MatKhau == matKhauCu);
            return user != null;
        }

        // Hàm thay đổi mật khẩu mới
        public bool DoiMatKhau(string tenDangNhap, string matKhauMoi, string xacNhanMatKhau)
        {
            // Kiểm tra xác nhận mật khẩu mới
            if (matKhauMoi != xacNhanMatKhau)
            {
                return false; // Xác nhận mật khẩu mới không khớp
            }

            // TODO: Thay đổi 'db' thành đối tượng DataContext của bạn
            var user = db.NguoiDungs.FirstOrDefault(u => u.TenND == tenDangNhap);

            if (user != null)
            {
                // Cập nhật mật khẩu mới
                user.MatKhau = matKhauMoi;
                db.SubmitChanges();
                return true; // Thay đổi mật khẩu thành công
            }

            return false; // Tên đăng nhập không hợp lệ
        }
    }
}
