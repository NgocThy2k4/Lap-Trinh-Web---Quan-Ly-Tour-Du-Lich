using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class FrmQLDatVeBLL
    {
        TourismManageAppBLLDataContext db = new TourismManageAppBLLDataContext();
        public FrmQLDatVeBLL()
        {

        }
        public List<dynamic> layDSVeDaDat()
        {
            var list = from ve in db.DatTours
                 
                       where ve.TinhTrang =="Đã đặt"
                       select new
                       {
                           MaDatTour = ve.MaDatTour,
                  
                           NgayLap = ve.NgayLap,
                           MaTour = ve.MaTour, 
                           TinhTrang = ve.TinhTrang
                       };
            return list.Cast<dynamic>().ToList();
        }
        public List<dynamic> layDSVeDaHuy()
        {
            var list = from ve in db.DatTours
                  
                       where ve.TinhTrang == "Đã hủy"
                       select new
                       {
                           MaDatTour = ve.MaDatTour,
                  
                           NgayLap = ve.NgayLap,
                           MaTour = ve.MaTour,
                           TinhTrang = ve.TinhTrang
                       };
            return list.Cast<dynamic>().ToList();
        }
        public List<dynamic> layDSVeDangXL()
        {
            var list = from ve in db.DatTours
                       where ve.TinhTrang == "Đang xử lý"
                       select new
                       {
                           MaDatTour = ve.MaDatTour,
                            
                           NgayLap = ve.NgayLap,
                           MaTour = ve.MaTour,
                           TinhTrang = ve.TinhTrang
                       };
            return list.Cast<dynamic>().ToList();
        }
        public List<dynamic> layDSDatVe()
        {
            var list = from ve in db.DatTours
                    
                       select new
                       {
                           MaDatTour = ve.MaDatTour,

                           NgayLap = ve.NgayLap,
                           MaTour = ve.MaTour,
                           TinhTrang = ve.TinhTrang
                       };
            return list.Cast<dynamic>().ToList();
        }
        public List<dynamic> timDSDatVeTheoMaTour(int maDatTour)
        {
            
            string tinhTrang = (from ve in db.DatTours
                                where ve.MaDatTour == maDatTour
                                select ve.TinhTrang).FirstOrDefault();
            List<dynamic> tt = new List<dynamic>();
            if (tinhTrang =="Đang xử lý")
            {
                var list = from ve in db.DatTours
                           where ve.MaDatTour == maDatTour
                           select new
                           {
                               MaDatTour = ve.MaDatTour,

                               NgayLap = ve.NgayLap,
                               MaTour = ve.MaTour,
                               TinhTrang = ve.TinhTrang
                           };
              
                tt = list.Cast<dynamic>().ToList();
            }
            else if(tinhTrang=="Đã đặt"||tinhTrang =="Đã hủy")
            {
                var list = from ve in db.DatTours
                           where ve.MaDatTour == maDatTour
                           select new
                           {
                               MaDatTour = ve.MaDatTour,

                               NgayLap = ve.NgayLap,
                               MaTour = ve.MaTour,
                               TinhTrang = ve.TinhTrang
                           };
               tt = list.Cast<dynamic>().ToList();
            }
            return tt;
        }
        public List<dynamic> timDSDatVeTheoMaVaNgay(int maTour,DateTime ngayLap)
        {

            
            List<dynamic> tt = new List<dynamic>();
            
                var list = from ve in db.DatTours
                           where ve.MaTour == maTour && ve.NgayLap.Value.Date == ngayLap.Date
                           select new
                           {
                               MaDatTour = ve.MaDatTour,
                               NgayLap = ve.NgayLap,
                               MaTour = ve.MaTour,
                               TinhTrang = ve.TinhTrang
                           };

                tt = list.Cast<dynamic>().ToList();
           
            return tt;
        }
        public void capNhatHuyVe(int maDatTour)
        {
            // Tìm đặt tour cần cập nhật
            var datTourToUpdate = db.DatTours.FirstOrDefault(dt => dt.MaDatTour == maDatTour);

            if (datTourToUpdate != null)
            {
                // Cập nhật trạng thái
                datTourToUpdate.TinhTrang = "Đã hủy";

                // Trả lại số ghế
                var maTour = datTourToUpdate.MaTour;
                var soNguoiLon = datTourToUpdate.SLNguoiLon ?? 0;
                var soTreEm = datTourToUpdate.SLTreEm ?? 0;

                // Tìm tour để cập nhật số ghế còn lại
                var tourToUpdate = db.Tours.FirstOrDefault(t => t.MaTour == maTour);

                if (tourToUpdate != null)
                {
                    // Cập nhật số ghế còn lại
                    tourToUpdate.SoNguoiDat -= (soNguoiLon + soTreEm);

                    // Submit các thay đổi
                    db.SubmitChanges();
                }
            }
        }
        public Tour layTourTheoMa(int maTour)
        {
            return db.Tours.FirstOrDefault(t => t.MaTour == maTour);
        }
        public DatTour layDatTourTheoMa(int maDatTour)
        {
            return db.DatTours.FirstOrDefault(t => t.MaDatTour == maDatTour);
        }

    }
}
