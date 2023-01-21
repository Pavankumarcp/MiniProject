using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MiniProject.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("MyCon")
        {
            
        }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Categoryddl> Category { get; set; }
        public DbSet<PackSizeddl> PackSize { get; set; }
    }
}