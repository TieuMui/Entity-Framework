﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameWork
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLBanHangEntities : DbContext
    {
        public QLBanHangEntities()
            : base("name=QLBanHangEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CTDONH> CTDONH { get; set; }
        public virtual DbSet<CTPNHAP> CTPNHAP { get; set; }
        public virtual DbSet<CTPXUAT> CTPXUAT { get; set; }
        public virtual DbSet<DONDH> DONDH { get; set; }
        public virtual DbSet<NHACC> NHACC { get; set; }
        public virtual DbSet<PNHAP> PNHAP { get; set; }
        public virtual DbSet<PXUAT> PXUAT { get; set; }
        public virtual DbSet<PHIEUTHU> PHIEUTHU { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TONKHO> TONKHO { get; set; }
        public virtual DbSet<VATTU> VATTU { get; set; }

        public string Message { get; set; }
    }
}
