﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyThuVienEntities : DbContext
    {
        public QuanLyThuVienEntities()
            : base("name=QuanLyThuVienEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<anpham> anphams { get; set; }
        public DbSet<anpham_phieumuonAP> anpham_phieumuonAP { get; set; }
        public DbSet<anpham_phieuphatAP> anpham_phieuphatAP { get; set; }
        public DbSet<dausach> dausaches { get; set; }
        public DbSet<docgia> docgias { get; set; }
        public DbSet<linhvuc> linhvucs { get; set; }
        public DbSet<loaidocgia> loaidocgias { get; set; }
        public DbSet<nhanvien> nhanviens { get; set; }
        public DbSet<nhaxuatban> nhaxuatbans { get; set; }
        public DbSet<phieumuonAP> phieumuonAPs { get; set; }
        public DbSet<phieumuonsach> phieumuonsaches { get; set; }
        public DbSet<phieuphatAP> phieuphatAPs { get; set; }
        public DbSet<phieuphatsach> phieuphatsaches { get; set; }
        public DbSet<sach> saches { get; set; }
        public DbSet<sach_phieumuonsach> sach_phieumuonsach { get; set; }
        public DbSet<sach_phieuphatsach> sach_phieuphatsach { get; set; }
        public DbSet<tacgia> tacgias { get; set; }
        public DbSet<taikhoan> taikhoans { get; set; }
    }
}
