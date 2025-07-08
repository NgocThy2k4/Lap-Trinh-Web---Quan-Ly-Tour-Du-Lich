using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HuongDanVienController : Controller
    {
        TourismModelDataContext db = new TourismModelDataContext("Data Source=BUIDUYHE;Initial Catalog=TourismManage;Integrated Security=True");
        // GET: HuongDanVien
        public ActionResult DsHuongDanVien()
        {
            List<NhanVien> nhanViens = db.NhanViens.ToList();

            return View(nhanViens);
        }
        public ActionResult DetailHDV(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ErrorID", "Error");
            }
            NhanVien nhanVien = db.NhanViens.Where(row => row.MaNV == id).FirstOrDefault();

            return View(nhanVien);
        }
    }
}