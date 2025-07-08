using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class DaiDienKHController : Controller
    {
        TourismModelDataContext db = new TourismModelDataContext("Data Source=BUIDUYHE;Initial Catalog=TourismManage;Integrated Security=True");
        // GET: DaiDienKH

        public ActionResult Index()
        {
            return View();
        }

        // GET: DaiDienKH/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DaiDienKH/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DaiDienKH/Create
        [HttpPost]
        public ActionResult Create(DaiDienKH kh)
        {
           
                DaiDienKH daiDienKH = new DaiDienKH();
                daiDienKH.TenKH = kh.TenKH;
                daiDienKH.GioiTinh = kh.GioiTinh;
                daiDienKH.NgaySinh = kh.NgaySinh;
                daiDienKH.DiaChi = kh.DiaChi;
                daiDienKH.Sdt = kh.Sdt;

                NguoiDung nd = new NguoiDung();
                var sdt = db.NguoiDungs.FirstOrDefault(s => s.TenND == (string)kh.Sdt);
                if (sdt !=null )
                {
                    ViewBag.SDT = "Số điện thoại đã được đăng ký! ";
                    return View();
                }
                nd.TenND = kh.Sdt;
                nd.MatKhau = "123";
                nd.MaPQ = 3; // khách hàng

                db.DaiDienKHs.InsertOnSubmit(daiDienKH);
                db.NguoiDungs.InsertOnSubmit(nd);

                db.SubmitChanges();
                Session["MaKH"] = daiDienKH.MaKH;

                return RedirectToAction("Create", "HopDong");
           
        }

        // GET: DaiDienKH/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DaiDienKH/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DaiDienKH/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DaiDienKH/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
