using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QLThuVien.Models
{
    public class DSMuon
    {
        public int MaDocGia { set; get; }
        public string HoTen { set; get; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime NgayMuon { set; get; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime NgayTra { set; get; }
        public int SoLanGiaHan { set; get; }
        public int SoSachDangMuon { set; get; }
        public int id { set; get; }
    }
}