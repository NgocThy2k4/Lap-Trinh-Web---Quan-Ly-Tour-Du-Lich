using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class FrmTaoTourBLL
    {
        TourismManageAppBLLDataContext db = new TourismManageAppBLLDataContext();
        public FrmTaoTourBLL() { }

        public void themTour(Tour tour)
        {
            Tour newTour = new Tour()
            {
                TenTour = tour.TenTour,
                NgayDi = tour.NgayDi,
                NgayVe = tour.NgayVe,
                MoTa = tour.MoTa,
                Gia = tour.Gia,
                DiemKhoiHanh = tour.DiemKhoiHanh,
                SoGhe = tour.SoGhe,
                GioKhoiHanh = tour.GioKhoiHanh,
                MaDiaDiem = tour.MaDiaDiem,
                SoNguoiDat = 0, // Số người đặt mặc định là 0
                MaLoaiKS = tour.MaLoaiKS,
                MaPT = tour.MaPT,
                Hinh1 = tour.Hinh1,
                Hinh2 = tour.Hinh2,
                Hinh3 = tour.Hinh3,
                Hinh4 = tour.Hinh4
            };

            db.Tours.InsertOnSubmit(newTour);
            db.SubmitChanges();
        }
        public List<dynamic> layDSTour()
        {
            var tour = from t in db.Tours
                        
                           select new
                           {
                               t.MaTour,
                               t.TenTour,
                               t.SoGhe,
                               t.NgayDi,
                               t.NgayVe,
                               t.Gia
                           };
            return tour.Cast<dynamic>().ToList();
        }

        public List<LoaiKhachSan> layDSKS()
        {
            var load = from l in db.LoaiKhachSans select l;
            return load.ToList();
        }
        public List<DiaDiem> layDiaDiem()
        {
            var load = from l in db.DiaDiems select l;
            return load.ToList();
        }
        public List<PhuongTien> layDSPT()
        {
            var load = from l in db.PhuongTiens select l;
            return load.ToList();
        }
        public void xoaTour(int maTour)
        {
            // Tìm tour cần xóa từ cơ sở dữ liệu
            var tourToRemove = db.Tours.SingleOrDefault(t => t.MaTour == maTour);

            if (tourToRemove != null)
            {
                // Xóa tour khỏi cơ sở dữ liệu
                db.Tours.DeleteOnSubmit(tourToRemove);
                db.SubmitChanges();
            }
          
        }
        public void suaTour(int maTour)
        {

        }
    }
}
