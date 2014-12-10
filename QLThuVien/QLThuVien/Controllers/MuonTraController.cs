using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLThuVien.Models;

namespace QLThuVien.Controllers
{
    public class MuonTraController : Controller
    {
        public ActionResult MaThe()
        {
            return View();
        }

        public ActionResult GetInfo(FormCollection f)
        {
            string Mathe = f["mathe"];
            QuanLyThuVienEntities db = new QuanLyThuVienEntities();

            var Phieumuon = from p in db.phieumuonsaches
                            join ps in db.sach_phieumuonsach on p.MaPhieuMuonSach equals ps.MaPhieuMuonSach
                            join s in db.saches on ps.id equals s.id
                            join ds in db.dausaches on s.MaDauSach equals ds.MaDauSach
                            where p.docgia.MaThe == Mathe && ps.TrangThai == "0"                          
                            select new DSMuonModels
                            {
                                MaDG=p.docgia.MaDocGia,
                                HoTenDG= p.docgia.HoTen,
                                DiaChiDG= p.docgia.DiaChi,
                                EmailDG= p.docgia.Email,
                                AnhDG= p.docgia.AnhDocGia,
                                GioiTinhDG= p.docgia.GioiTinh,
                                MaTheDG= p.docgia.MaThe,
                                SoDTDG= p.docgia.SoDT,
                                TenSach = ds.NhanDeChinh,
                                NgayMuon = (DateTime)p.NgayMuon,
                                NgayTra = (DateTime)p.NgayHetHan,
                                MaCaBietSach=s.MaCaBiet
                            };
            return View(Phieumuon);
        }

        public ActionResult GetInfoBook(FormCollection f)
        {
            string Mathe = f["mathesach"];
            QuanLyThuVienEntities db = new QuanLyThuVienEntities();
            var book = from b in db.saches
                       join ds in db.dausaches on b.MaDauSach equals ds.MaDauSach
                       join nxb in db.nhaxuatbans on ds.MaNXB equals nxb.MaNXB
                       where b.MaCaBiet == Mathe
                       select new SachModels
                       {
                           MaCaBiet= b.MaCaBiet,
                           TenSach= b.dausach.NhanDeChinh,
                           NhaXB= nxb.TenNXB,
                       };
            return PartialView(book);
        }
        public ActionResult DSMuon()
        {
            QuanLyThuVienEntities db = new QuanLyThuVienEntities();
            var ds = from p in db.phieumuonsaches
                     where p.DaTraHet == "0"
                     select new DSMuon
                     {
                         MaDocGia=p.docgia.MaDocGia,
                         id= p.MaPhieuMuonSach,
                         HoTen= p.docgia.HoTen,
                         NgayMuon = (DateTime)p.NgayMuon,
                         NgayTra = (DateTime)p.NgayHetHan,
                         SoLanGiaHan= (int)p.SoLanGiaHan,
                         SoSachDangMuon= p.sach_phieumuonsach.Where(x=>x.TrangThai=="0").Count(),
                     };
            return View(ds);
        }

        public ActionResult ChiTiet(Int32 id)
        {
            QuanLyThuVienEntities db = new QuanLyThuVienEntities();
            var ct= from ps in db.sach_phieumuonsach
                    join s in db.saches on ps.id equals s.id
                    join ds in db.dausaches on s.MaDauSach equals ds.MaDauSach
                    join dg in db.docgias on ps.phieumuonsach.MaDocGia equals dg.MaDocGia
                    where ps.MaPhieuMuonSach == id && ps.TrangThai =="0"
                    select new DSMuonModels
                    {
                        MaDG = dg.MaDocGia,
                        HoTenDG = dg.HoTen,
                        DiaChiDG = dg.DiaChi,
                        EmailDG = dg.Email,
                        AnhDG = dg.AnhDocGia,
                        GioiTinhDG = dg.GioiTinh,
                        MaTheDG = dg.MaThe,
                        SoDTDG = dg.SoDT,
                        TenSach = ds.NhanDeChinh,
                        NgayMuon = (DateTime)ps.phieumuonsach.NgayMuon,
                        NgayTra = (DateTime)ps.phieumuonsach.NgayHetHan,
                        MaCaBietSach = s.MaCaBiet
                    };
            return View(ct);
        }

    }
}

//return new RedirectResult(Url.Action("edit", new { id }) + "#tab-2" );