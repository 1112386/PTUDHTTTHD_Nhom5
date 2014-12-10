using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLThuVien.Models;
using System.Data.Objects;

namespace QLThuVien.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult support()
        {
            return View();
        }
        public ActionResult about()
        {
            return View();
        }
        
    }
}
