﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace myoBlog29API.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MyDbEntities : DbContext
    {
        public MyDbEntities()
            : base("name=MyDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Makale> Makale { get; set; }
        public virtual DbSet<Uye> Uye { get; set; }
        public virtual DbSet<Yorum> Yorum { get; set; }
    }
}
