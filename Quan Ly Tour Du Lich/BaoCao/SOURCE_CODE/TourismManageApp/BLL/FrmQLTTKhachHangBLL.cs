using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FrmQLTTKhachHangBLL
    {
        TourismManageAppBLLDataContext db = new TourismManageAppBLLDataContext();
        public FrmQLTTKhachHangBLL()
        {

        }
        public List<dynamic> layDSKH()
        {
            var ddkh = from kh in db.DaiDienKHs
                       select new
                       {
                           kh.MaKH,
                           kh.TenKH,
                           kh.GioiTinh,
                           kh.NgaySinh,
                           kh.DiaChi,
                           kh.Sdt,
                           kh.MaND
                       };
            return ddkh.Cast<dynamic>().ToList();
        }
        public DaiDienKH LayThongTinKhachHang(int maKhachHang)
        {
            return db.DaiDienKHs.FirstOrDefault(kh => kh.MaKH == maKhachHang);
        }
        public void CapNhatKhachHang(int maKhachHang, DaiDienKH khachHang)
        {
            DaiDienKH khachHangToUpdate = db.DaiDienKHs.FirstOrDefault(kh => kh.MaKH == maKhachHang);
            if (khachHangToUpdate != null)
            {
                khachHangToUpdate.TenKH = khachHang.TenKH;
                khachHangToUpdate.DiaChi = khachHang.DiaChi;
                khachHangToUpdate.Sdt = khachHang.Sdt;
                khachHangToUpdate.NgaySinh = khachHang.NgaySinh;
                khachHangToUpdate.GioiTinh = khachHang.GioiTinh;


                // Cập nhật các thông tin khác nếu cần
                db.SubmitChanges();
            }
        }
        public void ThemKH(DaiDienKH khachhang)
        {
            DaiDienKH newKhach = new DaiDienKH()
            {
                MaKH = khachhang.MaKH,
                TenKH = khachhang.TenKH,
                GioiTinh = khachhang.GioiTinh,
                NgaySinh = khachhang.NgaySinh,
                DiaChi = khachhang.DiaChi,
                Sdt = khachhang.Sdt,
                MaND = khachhang.MaND
            };

            db.DaiDienKHs.InsertOnSubmit(newKhach);
            db.SubmitChanges();
        }



    }
}
