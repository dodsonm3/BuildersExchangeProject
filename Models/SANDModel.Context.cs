﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuildersExchangeProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SANDEntities : DbContext
    {
        public SANDEntities()
            : base("name=SANDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CATEGORY> CATEGORIES { get; set; }
        public virtual DbSet<FILTER> FILTERs { get; set; }
        public virtual DbSet<LINK> LINKs { get; set; }
        public virtual DbSet<LINKDATA> LINKDATAs { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
