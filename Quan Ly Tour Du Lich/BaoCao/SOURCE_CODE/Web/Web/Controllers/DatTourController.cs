using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;
using System.Data.Entity;

namespace Web.Controllers
{
    public class DatTourController : Controller
    {
        TourismModelDataContext db = new TourismModelDataContext("Data Source=BUIDUYHE;Initial Catalog=TourismManage;Integrated Security=True");
        // GET: DatTour
        public ActionResult Index()
        {
            List<DatTour> datTours = db.DatTours.ToList();
            return View(datTours);
        }

        // GET: DatTour/Details/5
        public ActionResult Details(int? id)
        {
            var load = db.DatTours.FirstOrDefault(s => s.MaDatTour == id);
            return View(load);
        }

        // GET: DatTour/Create
        public ActionResult Create()
        {
            return View();

        }

        // POST: DatTour/Create
        // khách hàng đã đăng nhập và đặt tour
        [HttpPost]
        public ActionResult Create(DatTour datTour, int? id)
        {

            //try
            //{
            var madattour = TempData["MaDatTour"];
            var load = db.DatTours.FirstOrDefault(db => db.MaDatTour == (int)TempData["MaDatTour"]);

            load.SLNguoiLon = datTour.SLNguoiLon;
            load.SLTreEm = datTour.SLTreEm;
            db.SubmitChanges();

            TempData["MaDatTourHD"] = madattour;
            return RedirectToAction("Create", "HopDong");
        }
        //        catch
        //        {
        //            ViewBag.DatTourThatBai = "Bạn đã đặt tour thất bại!";
        //            return View();
        //}

        // GET: DatTour/Create
        public ActionResult XacNhanDatTour(int? id)
        {
            System.Diagnostics.Debug.WriteLine($"Received id: {id}");
            Session["MaTour"] = id;
            return View();

        }



        // POST: DatTour/Create
        [HttpPost]
        public ActionResult XacNhanDatTour(FormCollection form, int id)
        {

            if (Session["MaTour"] != null)
            {

                DatTour datTour = new DatTour();
                datTour.NgayLap = DateTime.Now;
                datTour.MaTour = (int)Session["MaTour"];
                datTour.TinhTrang = "Đang xử lý";
                Session["MaTour"] = datTour.MaTour;
                ViewBag.MaTour = datTour.MaTour;
                // MaKH hợp lệ, tiếp tục thêm vào DatTour
                db.DatTours.InsertOnSubmit(datTour);
                db.SubmitChanges();
                Session["TourVuaChon"] = datTour;
                Session["MaDatTour"] = datTour.MaDatTour;

                return RedirectToAction("BookTour");



            }
            else
            {
                return RedirectToAction("Index", "Home");
            }




        }

        // GET: DatTour/Edit/5
        public ActionResult Edit(int? id)
        {
            var load = db.DatTours.FirstOrDefault(s => s.MaDatTour == id);
            return View(load);
        }

        // POST: DatTour/Edit/5
        [HttpPost]
        public ActionResult Edit(DatTour datTour)
        {
            try
            {

                DatTour s = db.DatTours.FirstOrDefault(sa => sa.MaDatTour == datTour.MaDatTour);
                if (s == null)
                {
                    ViewBag.SuccessMessage = "Không tìm thấy Phiếu Đặt Tour!";
                    return View();
                }


                s.NgayLap = DateTime.Now;
                s.MaKH = datTour.MaKH;
                s.SLNguoiLon = datTour.SLNguoiLon;
                s.SLTreEm = datTour.SLTreEm;
                s.MaTour = datTour.MaTour;
                s.TinhTrang = datTour.TinhTrang;



                db.SubmitChanges();
                ViewBag.SuccessMessage = "Bạn đã cập nhật phiết đặt tour thành công!";
                return RedirectToAction("Index");

            }
            catch
            {
                ViewBag.SuccessMessage = "Bạn đã Cập Nhật phiết đặt tour thất bại!";
                return View();
            }

        }

        // GET: DatTour/Delete/5
        public ActionResult Delete(int? id)
        {
            var load = db.DatTours.FirstOrDefault(s => s.MaDatTour == id);
            return View(load);
        }

        // POST: DatTour/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                DatTour s = db.DatTours.FirstOrDefault(sa => sa.MaDatTour == id);
                if (s == null)
                {
                    ViewBag.SuccessMessage = "Không tìm thấy Phiếu Đặt Tour!";
                    return View();
                }
                db.DatTours.DeleteOnSubmit(s);
                db.SubmitChanges();
                ViewBag.SuccessMessage = "Bạn đã Xóa phiếu tour thành công!";
                return RedirectToAction("Index");



            }
            catch
            {
                ViewBag.SuccessMessage = "Bạn đã xóa phiết đặt tour thất bại!";
                return View();
            }
        }




        /////////////////////////
        ///// Action để hiển thị form đặt tour
        public ActionResult BookTour()
        {

            //var detail = db.Tours.FirstOrDefault(s => s.MaTour == (int)Session["MaTour"]);


            return View();
        }

        // Action để xử lý thông tin đặt tour từ form
        [HttpPost]
        public ActionResult BookTour(DatTour datTour)
        {
            if (Session["MaDatTour"] != null)
            {
                // Tiếp tục sử dụng giá trị từ Session
                int maDatTour = (int)Session["MaDatTour"];
                DatTour load = db.DatTours.FirstOrDefault(d => d.MaDatTour == maDatTour);
                var tour = db.Tours.FirstOrDefault(t => t.MaTour == (int)Session["MaTour"]);
                // Kiểm tra xem load có null hay không để tránh lỗi tiếp theo

                // Tiếp tục xử lý với đối tượng load
                load.SLNguoiLon = datTour.SLNguoiLon;
                load.SLTreEm = datTour.SLTreEm;


                
                HopDong hopDong = new HopDong();
                hopDong.MaDatTour = (int)Session["MaDatTour"];
                hopDong.NgayKyHD = DateTime.Now;
                hopDong.TenHD = tour.TenTour;
                hopDong.MaTT = 2;
                hopDong.TongTien = 0;


                db.HopDongs.InsertOnSubmit(hopDong);

                db.SubmitChanges();
                Session["MaHopDong"] = hopDong.MaHD;

                if (Session["MaKH"] == null)
                {
                    return RedirectToAction("Create", "DaiDienKH");
                }
                else
                {
                    load.MaKH = (int)Session["MaKH"];
                }


                return RedirectToAction("Create", "HopDong");



            }
            return RedirectToAction("Index", "Home");






            //return RedirectToAction("BookingSuccess");
        }
      
        // Action để hiển thị trang thông báo đặt tour thành công
        public ActionResult BookingSuccess()
        {
            return View();
        }




    }
}
