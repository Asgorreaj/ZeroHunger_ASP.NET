﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zerohunger.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ZeroHungerEntities : DbContext
    {
        public ZeroHungerEntities()
            : base("name=ZeroHungerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<collect_requests> collect_requests { get; set; }
        public virtual DbSet<collected_food_items> collected_food_items { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<restaurant> restaurants { get; set; }
    }
}
