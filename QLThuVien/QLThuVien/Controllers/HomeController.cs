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
        public ActionResult ThongKeTheoLoaiDG()
        {
            QuanLyThuVienEntities data = new QuanLyThuVienEntities();
            var So_luong_Doc_Gia = data.So_Luong_Tung_Loai_DocGia();
            return View(So_luong_Doc_Gia);
        }
        public ActionResult ThongKeSuDungThuVien()
        {
            QuanLyThuVienEntities data = new QuanLyThuVienEntities();
            var Doc_Gia_Su_Dung = data.ThongKeSoDocGia_TG_MuonSAP();
            return View(Doc_Gia_Su_Dung);
        }
        public ActionResult ThongKeDocGiaMuonSach_AP()
        {
            QuanLyThuVienEntities data = new QuanLyThuVienEntities();
            var Doc_Gia_Muon_Sach_AP = data.ThongKeChiTietMuonSAP();
            return View(Doc_Gia_Muon_Sach_AP);
        }
        public ActionResult ThongKeDocGiaPhat()
        {
            QuanLyThuVienEntities data = new QuanLyThuVienEntities();
            var Doc_Gia_Bi_Phat = data.ThongKePhat();
            return View(Doc_Gia_Bi_Phat);
        }

    }
}
