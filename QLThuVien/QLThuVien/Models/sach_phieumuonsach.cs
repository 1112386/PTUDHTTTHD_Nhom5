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
    
    public partial class sach_phieumuonsach
    {
        public int id { get; set; }
        public int MaPhieuMuonSach { get; set; }
    
        public virtual sach sach { get; set; }
    }
}
