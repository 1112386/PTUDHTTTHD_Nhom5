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
    
    public partial class tacgia
    {
        public tacgia()
        {
            this.dausaches = new HashSet<dausach>();
        }
    
        public int MaTacGia { get; set; }
        public string HoTen { get; set; }
        public string HocVi { get; set; }
        public string ButDanh { get; set; }
        public string DiaChi { get; set; }
        public string email { get; set; }
    
        public virtual ICollection<dausach> dausaches { get; set; }
    }
}
