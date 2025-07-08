using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Razor;
using Web.Models;
using System.Data.Linq;

namespace Web.Controllers
{
    public class ToursController : Controller
    {



        TourismModelDataContext db = new TourismModelDataContext("Data Source=DESKTOP-Q2HMOGS\\SQLEXPRESS;Initial Catalog=TourismManage;Integrated Security=True");
        // GET: Tours
        public ActionResult Index(string search = "")
        {

            // Lấy danh sách tour từ cơ sở dữ liệu
            //List<Tour> tours = db.Tours.ToList();
            List<Tour> tours = db.Tours.Where(row => row.TenTour.Contains(search)).ToList();
            // Kiểm tra và tính toán số ngày đi cho mỗi tour
            foreach (var tour in tours)
                {
                    int soNgayDi = TinhSoNgayDi(Convert.ToDateTime( tour.NgayVe), Convert.ToDateTime(tour.NgayDi));

                    ViewBag.SoNgayDi = soNgayDi; // Thêm một thuộc tính vào đối tượng Tour để lưu trữ số ngày đi
                }






            ViewBag.Search = search;
                return View(tours);
            
        }

        private int TinhSoNgayDi(DateTime ngayVe, DateTime ngayDi)
        {
            if (ngayVe >= ngayDi)
            {
                TimeSpan chenhLech = ngayVe.Subtract(ngayDi);
                return chenhLech.Days;
            }
            else
            {
                return 0;
            }
        }
        public ActionResult Detail(int? id)
        {

            //if (id == null)
            //{
            //    return RedirectToAction("ErrorID", "Error");
            //}
            System.Diagnostics.Debug.WriteLine($"Received id: {id}");
            Tour tour = db.Tours.Where(row => row.MaTour == id).FirstOrDefault();
            Session["MaTour"] = id;
            return View(tour);

        }

        public ActionResult DiemDen()
        {
           
            var randomTours = GetRandomTours(4);
            // Chuyển dữ liệu từ model cơ sở dữ liệu sang ViewModel

            //ViewBag.TourImages = randomTours[0].Select(tour => (tour.Hinh1 != null) ? Convert.ToBase64String(tour.Hinh1.ToArray()) : null).ToList();


           



            if (randomTours.Count >= 4)
            {
                ViewBag.Tour1 = randomTours[0].MaTour;
                //ViewBag.Tour2 = randomTours[0].Hinh1;
                ViewBag.Tour3 = randomTours[0].TenTour;

                ViewBag.Tour4 = randomTours[1].MaTour;
                //ViewBag.Tour5 = randomTours[1].Hinh1;
                ViewBag.Tour6 = randomTours[1].TenTour;

                ViewBag.Tour7 = randomTours[2].MaTour;
                //ViewBag.Tour8 = randomTours[2].Hinh1;
                ViewBag.Tour9 = randomTours[2].TenTour;

                ViewBag.Tour10 = randomTours[3].MaTour;
                //ViewBag.Tour11 = randomTours[3].Hinh1;
                ViewBag.Tour12 = randomTours[3].TenTour;
            }
            return View();

            //return View();
        }


 
        private List<Tour> GetRandomTours(int numberOfTours)
        {

            var allTours = db.Tours.ToList();

            // Nếu có ít hơn numberOfTours tour trong cơ sở dữ liệu, lấy tất cả
            if (allTours.Count <= numberOfTours)
            {
                return allTours;
            }

            // Nếu có nhiều hơn numberOfTours tour, lấy ngẫu nhiên numberOfTours tour
            var random = new Random();
            var randomIndexes = Enumerable.Range(0, allTours.Count).OrderBy(x => random.Next()).Take(numberOfTours);

            return randomIndexes.Select(index => allTours[index]).ToList();
        }
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(Tour tour, HttpPostedFileBase Hinh1File, HttpPostedFileBase Hinh2File, HttpPostedFileBase Hinh3File, HttpPostedFileBase Hinh4File)
        {
            if (ModelState.IsValid)
            {

                Tour s = new Tour();
                s.TenTour = tour.TenTour;
                s.NgayDi = tour.NgayDi;
                s.NgayVe = tour.NgayVe;
                s.MoTa = tour.MoTa;
                s.Gia = tour.Gia;
                s.DiemKhoiHanh = tour.DiemKhoiHanh;
                s.SoGhe = tour.SoGhe;
                s.GioKhoiHanh = tour.GioKhoiHanh;
                s.MaDiaDiem = tour.MaDiaDiem;
                s.SoNguoiDat = tour.SoNguoiDat;
                s.MaLoaiKS = tour.MaLoaiKS;
                s.MaPT = tour.MaPT;
                s.TinhTrang = tour.TinhTrang;
                if (Hinh1File != null && Hinh1File.ContentLength > 0)
                {
                    s.Hinh1 = ReadFileData(Hinh1File);
                }

                if (Hinh2File != null && Hinh2File.ContentLength > 0)
                {
                    s.Hinh2 = ReadFileData(Hinh2File);
                }

                if (Hinh3File != null && Hinh3File.ContentLength > 0)
                {
                    s.Hinh3 = ReadFileData(Hinh3File);
                }

                if (Hinh4File != null && Hinh4File.ContentLength > 0)
                {
                    s.Hinh4 = ReadFileData(Hinh4File);
                }
                db.Tours.InsertOnSubmit(s);
                db.SubmitChanges();


                return RedirectToAction("Index", "Home");
            }

            return View(tour);

        }
        private byte[] ReadFileData(HttpPostedFileBase file)
        {
            using (var binaryReader = new BinaryReader(file.InputStream))
            {
                return binaryReader.ReadBytes(file.ContentLength);
            }
        }



    }
}