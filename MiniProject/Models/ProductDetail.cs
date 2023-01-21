using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace MiniProject.Models
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        
        public int Quantity { get; set; }
        public float Discount { get; set; }
        public double TotalPrice { get; set; }
        public PackSizeddl PackSize { get; set; }
        public int PackId { get; set; }
        public Categoryddl Category { get; set; }
        public int CategoryId { get; set; }

    }
}