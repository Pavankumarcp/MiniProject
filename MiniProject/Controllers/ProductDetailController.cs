using MiniProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MiniProject.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly ApplicationDbContext _context = null;
        public ProductDetailController()
        {
            _context = new ApplicationDbContext();
        }
        
        // GET: ProductDetail
        public ActionResult Index()
        {
            var prdDetails = _context.ProductDetails.ToList();
            return View(prdDetails);
        }
        public ActionResult Create()
        { 
        }
    }
}