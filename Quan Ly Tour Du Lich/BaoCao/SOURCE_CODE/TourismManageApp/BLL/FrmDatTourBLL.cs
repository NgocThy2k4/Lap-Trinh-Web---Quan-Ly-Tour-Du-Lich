using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class FrmDatTourBLL
    {
        public FrmDatTourBLL() { }  
        TourismManageAppBLLDataContext db = new TourismManageAppBLLDataContext();
        public List<dynamic> timTour(string diemKhoiHanh, int maDiaDiem, DateTime ngayDi, int maPhuongTien)
        {
            var tou = from t in db.Tours
                      where (t.DiemKhoiHanh == diemKhoiHanh
                      && t.MaDiaDiem== maDiaDiem
                      && t.NgayDi== ngayDi
                      && t.MaPT == maPhuongTien)

                       select new
                       {
                           t.MaTour,
                           t.TenTour,
                           t.SoGhe,
                           t.NgayDi,
                           t.NgayVe,
                           t.Gia
                       };

            return tou.Cast<dynamic>().ToList();
        }
        public void datTour(DatTour dt)
        {
            DatTour datTour = new DatTour
            {
                NgayLap = dt.NgayLap,
                MaKH = null,
                SLNguoiLon = null,
                SLTreEm = null,
                MaTour = dt.MaTour,
                
                TinhTrang = "Đang xử lý"
            };
        }
    }
}
