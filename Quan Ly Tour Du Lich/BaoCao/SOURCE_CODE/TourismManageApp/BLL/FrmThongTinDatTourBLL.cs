using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FrmThongTinDatTourBLL
    {
        TourismManageAppBLLDataContext db = new TourismManageAppBLLDataContext();
        public FrmThongTinDatTourBLL()
        {

        }

        public void taoKH(DaiDienKH kh)
        {
            DaiDienKH newkh = new DaiDienKH()
            {
                TenKH = kh.TenKH,
                DiaChi = kh.DiaChi,
                Sdt = kh.Sdt,
                GioiTinh = null,
                MaND = null,
                NgaySinh = null
            };
            db.DaiDienKHs.InsertOnSubmit(newkh);
            db.SubmitChanges();
        }
        public void taoTKKhachHang(string tenND)
        {
            NguoiDung nguoiDung = new NguoiDung()
            {
                TenND = tenND,
                MatKhau = "1",
            };
            db.NguoiDungs.InsertOnSubmit(nguoiDung);
            db.SubmitChanges();
        }
        //public int layMaNguoiDung(DaiDienKH kh, string tenND)
        //{
        //    int maND = from kh1 in db.NguoiDungs
        //               join nguoiDung in db.NguoiDungs on kh.MaND equals nguoiDung.MaND
        //}


        public List<dynamic> loadKH()
        {
            var khach = from kh in db.DaiDienKHs
                        select new
                        {
                            kh.MaKH,
                            kh.TenKH,
                            kh.Sdt,
                            kh.DiaChi
                        };
            return khach.Cast<dynamic>().ToList();
        }
        public List<dynamic> loadKHTheoSTD(string sdt)
        {
            var khach = from kh in db.DaiDienKHs
                        where kh.Sdt == sdt
                        select new
                        {
                            kh.MaKH,
                            kh.TenKH,
                            kh.Sdt,
                            kh.DiaChi
                        };
            return khach.Cast<dynamic>().ToList();
        }
        public List<ThanhToan> loadThanhToan()
        {
            var thanhtoan = from tt in db.ThanhToans
                            select tt;
            return thanhtoan.ToList();
        }

        public void taoHopDong(HopDong hd)
        {
            HopDong newhd = new HopDong()
            {
                TenHD = hd.TenHD,
                NgayKyHD = hd.NgayKyHD,
                MaNV = hd.MaNV,
                MaDatTour = hd.MaDatTour,   
                MaTT= hd.MaTT,  
                TongTien = hd.TongTien,
            };
            db.HopDongs.InsertOnSubmit(newhd);
            db.SubmitChanges();
        }
        public DataTable laytable()
        {
            var list = from t in db.Tours
                       select t;
            DataTable dt = new DataTable();
            
            foreach( var t in list )
            {
                dt.Rows.Add( t );
            }
            return dt;
        }
    }
}
