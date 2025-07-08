using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class LoginController : Controller
    {
        TourismModelDataContext db = new TourismModelDataContext("Data Source=BUIDUYHE;Initial Catalog=TourismManage;Integrated Security=True");
      
        // GET: Login
        public ActionResult Index()
        {
            List<NguoiDung> nguoiDungs = db.NguoiDungs.ToList();
            return View(nguoiDungs);
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Đăng Nhập
        [HttpPost]
        public ActionResult Create(FormCollection form)
        {


            var usr = db.NguoiDungs.FirstOrDefault(u => u.TenND == form["tendn"] && u.MatKhau == form["password"]);
           
            if (usr != null)
            {
                //var makh = db.DaiDienKHs.FirstOrDefault(u => u.NguoiDung.TenND == form["tendn"]);
                var makh = db.DaiDienKHs.FirstOrDefault(u => u.NguoiDung != null && u.NguoiDung.TenND == form["tendn"]);
               
                if (makh != null)
                {
                    Session["MaKH"] = makh.MaKH;
                    Session["TenKH"] = makh.TenKH;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.login = "Không tìm thấy thông tin đại diện cho người dùng này!";
                    return View();
                }
            }
            else
            {
                ViewBag.login = "Không tìm thấy Tài khoản này!";
                return View();
            }

        }
        public ActionResult SignUp()
        {
            return View();
        }

        // POST:Đăng ký
        [HttpPost]
        public ActionResult SignUp(FormCollection form)
        {

            

                NguoiDung s = new NguoiDung();
               
                var repass = form["repassword"];
                var name = db.NguoiDungs.FirstOrDefault(p => p.TenND == form["name"]);

                if (form["password"] != form["repassword"])
                {
                    ViewBag.sosanh = "Mật khẩu không trùng khớp!";
                    return View();
                }   
                
                if (name != null)
                {
                    ViewBag.phone = "Đã tòn tại tài khoản với số điện thoại này!";
                    return View();
                }

                s.TenND = form["name"];
                s.MatKhau = form["password"];
                s.MaPQ = 3;
        
               
               
              






                db.NguoiDungs.InsertOnSubmit(s);
             

                db.SubmitChanges();
                TempData["MaND"] = s.MaND;

                return RedirectToAction("SignUp2", "Login");
            



        }
        public ActionResult Logout()
        {
            // Xóa giá trị của Session["TenKH"]
            Session["TenKH"] = null;

            // Chuyển hướng đến trang đăng nhập hoặc trang chính
            return RedirectToAction("Create", "Login"); // Điều này giả sử trang đăng nhập có action là "Create"
        }









        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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
