using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLThuVien.Controllers
{
    public class ThuThuController : Controller
    {
        //
        // GET: /ThuThu/

        public ActionResult Index()
        {
            return View("ThuThu_Home");
        }

    }
}
