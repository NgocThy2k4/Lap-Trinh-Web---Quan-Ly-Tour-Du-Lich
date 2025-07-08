using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class FrmMainBLL
    {
        TourismManageAppBLLDataContext db = new TourismManageAppBLLDataContext();


        public bool checkAdmin(string loggedInTaiKhoan)
        {
            var user = db.NguoiDungs.FirstOrDefault(u => u.TenND == loggedInTaiKhoan && u.PhanQuyen.TenPQ == "Admin");

            // Nếu user không null, tức là tên đăng nhập đã tồn tại
            return user != null;

            // Nếu có tài khoản, đăng nhập thành công
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
        public void CapNhapTrangThaiChung()
        {

            var toursInRange = db.Tours
             .ToList();

            foreach (var tour in toursInRange)
            {
               

                // Cập nhật tình trạng của tour trong bảng TinhTrangTour
                var tinhTrangTour = db.Tours.FirstOrDefault(tt => tt.MaTour == tour.MaTour);
                if (tinhTrangTour != null)
                {
                    if (tour.NgayVe < DateTime.Now)
                    {
                        tinhTrangTour.TinhTrang = "Đã diễn ra";
                    }
                    else if (tour.NgayDi <= DateTime.Now && DateTime.Now <= tour.NgayVe)
                    {
                        tinhTrangTour.TinhTrang = "Đang diễn ra";
                    }
                    else
                    {
                        tinhTrangTour.TinhTrang = "Chưa diễn ra";
                    }
                }
            }

            // Lưu thay đổi vào cơ sở dữ liệu

            db.SubmitChanges();
        }

    }
}
