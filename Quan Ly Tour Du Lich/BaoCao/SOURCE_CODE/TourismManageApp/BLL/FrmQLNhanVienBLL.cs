using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FrmQLNhanVienBLL
    {
        TourismManageAppBLLDataContext db = new TourismManageAppBLLDataContext();
        public FrmQLNhanVienBLL()
        {

        }
        public List<dynamic> layDSNV()
        {
            var ddnv = from nv in db.NhanViens
                       select new
                       {
                           nv.MaNV,
                           nv.TenNV,
                           nv.Sdt,
                           nv.Email,
                           nv.DiaChi,
                           nv.GioiTinh,
                           nv.NgaySinh,
                           nv.CCCD,
                           nv.ChucVu,
                           nv.TinhTrang,
                           nv.MaND
                       };
            return ddnv.Cast<dynamic>().ToList();
        }
        public NhanVien LayThongTinNV(int maNhanVien)
        {
            return db.NhanViens.FirstOrDefault(kh => kh.MaNV == maNhanVien);
        }
        public void CapNhatNhanvien(int maNhanVien, NhanVien nhanVien)
        {
            NhanVien nvToUpdate = db.NhanViens.FirstOrDefault(kh => kh.MaNV == maNhanVien);
            if (nvToUpdate != null)
            {

                nvToUpdate.TenNV = nhanVien.TenNV;
                nvToUpdate.Sdt = nhanVien.Sdt;
                nvToUpdate.CCCD = nhanVien.CCCD;
                nvToUpdate.DiaChi = nhanVien.DiaChi;
                nvToUpdate.Email = nhanVien.Email;
                nvToUpdate.ChucVu = nhanVien.ChucVu;
                nvToUpdate.NgaySinh = nhanVien.NgaySinh;
                nvToUpdate.TinhTrang = nhanVien.TinhTrang;
                nvToUpdate.GioiTinh = nhanVien.GioiTinh;

                // Cập nhật các thông tin khác nếu cần
                db.SubmitChanges();
            }
        }
        public void ThemNV(NhanVien nhanVien)
        {
            NhanVien newnv = new NhanVien()
            {
                MaNV = nhanVien.MaNV,
                TenNV = nhanVien.TenNV,
                Sdt = nhanVien.Sdt,
                CCCD = nhanVien.CCCD,
                DiaChi = nhanVien.DiaChi,
                Email = nhanVien.Email,
                ChucVu = nhanVien.ChucVu,
                NgaySinh = nhanVien.NgaySinh,
                TinhTrang = nhanVien.TinhTrang,
                GioiTinh = nhanVien.GioiTinh,
                MaND = nhanVien.MaND
            };

            db.NhanViens.InsertOnSubmit(newnv);
            db.SubmitChanges();
        }
    }
}
