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
    
    public partial class anpham
    {
        public anpham()
        {
            this.anpham_phieumuonAP = new HashSet<anpham_phieumuonAP>();
        }
    
        public int MaAnPham { get; set; }
        public Nullable<int> MaNXB { get; set; }
        public Nullable<int> So { get; set; }
        public string Nam { get; set; }
        public string ISSN { get; set; }
        public string TongBienTap { get; set; }
        public Nullable<double> GiaTien { get; set; }
    
        public virtual nhaxuatban nhaxuatban { get; set; }
        public virtual ICollection<anpham_phieumuonAP> anpham_phieumuonAP { get; set; }
    }
}
