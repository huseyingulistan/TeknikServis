﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace teknikServis
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class teknikServisEntities : DbContext
    {
        public teknikServisEntities()
            : base("name=teknikServisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tblAdmin> tblAdmin { get; set; }
        public virtual DbSet<tblArizaDetay> tblArizaDetay { get; set; }
        public virtual DbSet<tblCari> tblCari { get; set; }
        public virtual DbSet<tblDepartman> tblDepartman { get; set; }
        public virtual DbSet<tblFaturaBilgi> tblFaturaBilgi { get; set; }
        public virtual DbSet<tblFaturaDetay> tblFaturaDetay { get; set; }
        public virtual DbSet<tblGider> tblGider { get; set; }
        public virtual DbSet<tblKategori> tblKategori { get; set; }
        public virtual DbSet<tblNotlarım> tblNotlarım { get; set; }
        public virtual DbSet<tblPersonel> tblPersonel { get; set; }
        public virtual DbSet<tblUrun> tblUrun { get; set; }
        public virtual DbSet<tblUrunHareket> tblUrunHareket { get; set; }
        public virtual DbSet<tblUrunKabul> tblUrunKabul { get; set; }
        public virtual DbSet<tblUrunTakip> tblUrunTakip { get; set; }
    }
}