using MiniProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniProject.Controllers
{
    public class CategoryddlController : Controller
    {
        private readonly ApplicationDbContext _context = null;
        public CategoryddlController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: ProductDetail
        public ActionResult Index()
        {
            var Categoryddl = _context.Category.ToList();
            return View(Categoryddl);
        }
    }
}