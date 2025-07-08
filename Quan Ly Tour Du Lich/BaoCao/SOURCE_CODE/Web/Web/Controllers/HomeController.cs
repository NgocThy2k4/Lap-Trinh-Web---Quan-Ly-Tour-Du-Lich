using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;
namespace Web.Controllers
{
    public class HomeController : Controller
    {
        TourismModelDataContext db = new TourismModelDataContext("Data Source=DESKTOP-Q2HMOGS\\SQLEXPRESS;Initial Catalog=TourismManage;Integrated Security=True");

        // GET: Home
        public ActionResult Index()
        {

            var load = db.Tours.ToList();
                
           
            //var randomTours = GetRandomTours(4);



            //ViewBag.Tour1 = randomTours[0].HinhAnh;
            //ViewBag.Tour2 = randomTours[0].TenTour;
            //ViewBag.Tour3 = randomTours[1].HinhAnh;
            //ViewBag.Tour4 = randomTours[1].TenTour;
            //ViewBag.Tour5 = randomTours[2].HinhAnh;
            //ViewBag.Tour6 = randomTours[2].TenTour;
            //ViewBag.Tour7 = randomTours[3].HinhAnh;
            //ViewBag.Tour8 = randomTours[3].TenTour;
            return View(load);
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
    }
}
