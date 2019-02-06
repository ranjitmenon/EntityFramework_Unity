using EP.DTO.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace EP.DAL
{
    public class EPContext : DbContext
    {
        public EPContext() : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        public virtual DbSet<Customers> People { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
    }
}