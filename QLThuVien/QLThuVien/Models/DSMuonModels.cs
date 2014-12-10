using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace QLThuVien.Models
{
    public class DSMuonModels
    {
        public string TenSach { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime NgayMuon { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime NgayTra { get; set; }
        public string MaCaBietSach { get; set; }
        public string HoTenDG { get; set; }
        public string DiaChiDG { get; set; }
        public string EmailDG { get; set; }
        public string MaTheDG { get; set; }
        public string SoDTDG { get; set; }
        public string AnhDG { get; set; }
        public string GioiTinhDG { get; set; }
        public int MaDG { get; set; }
    }
}