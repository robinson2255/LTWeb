using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult KhachHang()
        {
            return View();
        }

        public ActionResult SanPham()
        {
            return View();
        }
    }
}