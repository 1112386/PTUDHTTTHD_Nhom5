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
    
    public partial class phieuphatsach
    {
        public phieuphatsach()
        {
            this.sach_phieuphatsach = new HashSet<sach_phieuphatsach>();
        }
    
        public int MaPhieuPhatSach { get; set; }
        public Nullable<int> MaDocGia { get; set; }
        public Nullable<double> SoTienPhat { get; set; }
        public string LyDo { get; set; }
        public Nullable<bool> DaDong { get; set; }
    
        public virtual docgia docgia { get; set; }
        public virtual ICollection<sach_phieuphatsach> sach_phieuphatsach { get; set; }
    }
}
