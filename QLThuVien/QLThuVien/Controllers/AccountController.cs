using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using QLThuVien.Models;
using System.Security.Cryptography;
using System.Text;
namespace QLThuVien.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Login(FormCollection f)
        {
            string username=f["username"].ToString();
            string password=f["password"].ToString();
            if(username==null ||username=="" || password==null || password=="")
            {
                return View();
            }
            string passmd5 = Md5(password);
            QuanLyThuVienEntities db = new QuanLyThuVienEntities();
            taikhoan account = db.taikhoans.Where(a => a.Username == username).First();
            if (account != null)
            {
                if(account.pass==passmd5)
                {
                    Session["username"]=username;
                    Session["LoaiTaiKhoan"] = account.LoaiTaiKhoan;
                }
            }
            return RedirectToAction("Index","Home");
        }
        public ActionResult Logout()
        {
            Session.RemoveAll();
            return RedirectToAction("Index", "Home");
        }

        static string Md5(string text)
        {
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] bs = Encoding.UTF8.GetBytes(text);
            bs = x.ComputeHash(bs);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in bs)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
        public ActionResult demo()
        {
            return View();
        }

    }
}
