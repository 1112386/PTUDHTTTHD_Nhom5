//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLThuVien.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class phieumuonsach
    {
        public phieumuonsach()
        {
            this.sach_phieumuonsach = new HashSet<sach_phieumuonsach>();
        }
    
        public int MaPhieuMuonSach { get; set; }
        public Nullable<int> MaDocGia { get; set; }
        public Nullable<System.DateTime> NgayMuon { get; set; }
        public Nullable<System.DateTime> NgayHetHan { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> SoLanGiaHan { get; set; }
        public string DaTraHet { get; set; }
    
        public virtual docgia docgia { get; set; }
        public virtual ICollection<sach_phieumuonsach> sach_phieumuonsach { get; set; }
    }
}
