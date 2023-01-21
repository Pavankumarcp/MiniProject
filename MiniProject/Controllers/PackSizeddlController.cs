using MiniProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MiniProject.Controllers
{
    public class PackSizeddlController : Controller
    {
        private readonly ApplicationDbContext _context = null;
        public PackSizeddlController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: ProductDetail
        public ActionResult Index()
        {
            var Packsizeddl = _context.PackSize.ToList();
            return View(Packsizeddl);
        }
    }
}