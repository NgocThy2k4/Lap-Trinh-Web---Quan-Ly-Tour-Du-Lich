using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FrmQLTaiKhoanBLL
    {
        TourismManageAppBLLDataContext ql = new TourismManageAppBLLDataContext();
        public FrmQLTaiKhoanBLL() { }   

        public List<dynamic> LayDSTKKhachHang()
        {
            var query = from khachHang in ql.DaiDienKHs
                        join nguoiDung in ql.NguoiDungs on khachHang.MaND equals nguoiDung.MaND
                        select new
                        {
                            MaND = nguoiDung.MaND,
                            TenKH = khachHang.TenKH,
                            TenND = nguoiDung.TenND,
                            MatKhau = nguoiDung.MatKhau,
                            Sdt = khachHang.Sdt
                        };

            return query.Cast<dynamic>().ToList();

        }
        public List<dynamic> LayDSTKNhanVien()
        {
            var query = from nhanvien in ql.NhanViens
                        join nguoiDung in ql.NguoiDungs on nhanvien.MaND equals nguoiDung.MaND
                        select new
                        {
                            MaND = nguoiDung.MaND,
                            TenNV = nhanvien.TenNV,
                            TenND = nguoiDung.TenND,
                            MatKhau = nguoiDung.MatKhau,
                            Sdt = nhanvien.Sdt
                        };

            return query.Cast<dynamic>().ToList();

        }
    }
}
