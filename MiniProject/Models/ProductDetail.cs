using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}