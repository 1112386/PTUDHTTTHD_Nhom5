using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLThuVien.Controllers
{
    public class DocGiaController : Controller
    {
        //
        // GET: /DocGia/

        public ActionResult Index()
        {
            return View("DocGia_Home");
        }

    }
}
