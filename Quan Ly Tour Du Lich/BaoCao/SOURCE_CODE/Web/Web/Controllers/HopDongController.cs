using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HopDongController : Controller
    {
        TourismModelDataContext db = new TourismModelDataContext("Data Source=BUIDUYHE;Initial Catalog=TourismManage;Integrated Security=True");
        // GET: HopDong
        public ActionResult Index()
        {

            return View();
        }

        // GET: HopDong/Details/5
        public ActionResult Details(HopDong hopDong, int? id)
        {
            var load = db.HopDongs.FirstOrDefault(l => l.MaHD == id);

            var tour = db.Tours.FirstOrDefault(g => g.MaTour == (int)Session["MaTour"]);
            var datTour = db.DatTours.FirstOrDefault(g => g.MaDatTour == (int)Session["MaDatTour"]);
            var tenHD = db.Tours.FirstOrDefault(t => t.MaTour == (int)Session["MaTour"]);

            DatTour makh = db.DatTours.FirstOrDefault(q => q.MaKH == (int)Session["MaDatTour"]);

            datTour.MaKH = (int)Session["MaKH"];


            load.TongTien = TongTien(datTour.SLNguoiLon.GetValueOrDefault(), datTour.SLTreEm.GetValueOrDefault(), tour.Gia.GetValueOrDefault());
            db.SubmitChanges();

            ViewBag.giaTour = tour.Gia;
            ViewBag.slNguoiLon = datTour.SLNguoiLon;
            ViewBag.slTreEm = datTour.SLTreEm;
            ViewBag.TongTien = load.TongTien;





            return View(load);
        }

        // GET: HopDong/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HopDong/Create
        [HttpPost]
        public ActionResult Create(HopDong hopDong ,int id)
        {

           
            return View();

            //catch
            //{
            //    ViewBag.SuccessMessage = "Bạn đã đặt tour thất bại!";
            //    return View();
            //}
        }
        public decimal TongTien(int SLNguoiLon,int SLTreEm,decimal Gia)
        {
            

            return Gia * SLNguoiLon + Gia * (decimal)(50.0 / 100.0) * SLTreEm;
        }

        // GET: HopDong/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HopDong/Edit/5
        [HttpPost]
        public ActionResult Edit()
        {
            //var tour = db.Tours.FirstOrDefault(g => g.MaTour == (int)Session["MaTour"]);
            //var datTour = db.DatTours.FirstOrDefault(g => g.MaDatTour == (int)Session["MaDatTour"]);

            //var tenHD = db.Tours.FirstOrDefault(t => t.MaTour == (int)Session["MaTour"]);



            //HopDong s = db.HopDongs.FirstOrDefault(w => w.MaHD == (int)Session["MaHopDong"]);
            //if (s != null)
            //{
            //    s.TenHD = tour.TenTour;
            //    s.NgayKyHD = DateTime.Now;
            //    s.MaTT = 2; // thanh toán onl


            //    s.TongTien = TongTien(datTour.SLNguoiLon.GetValueOrDefault(), datTour.SLTreEm.GetValueOrDefault(), tour.Gia.GetValueOrDefault());




            //    db.SubmitChanges();
            //    ViewBag.giaTour = tour.Gia;
            //    ViewBag.slNguoiLon = datTour.SLNguoiLon;
            //    ViewBag.slTreEm = datTour.SLTreEm;
            //    ViewBag.TongTien = s.TongTien;

            //    //return View();
            //}
            return View();
        }

        
    }
}
