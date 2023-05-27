using bussineslogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserService _userService;
        private readonly ProductService _productService;

        public HomeController()
        {
            _userService = new UserService();
            _productService = new ProductService();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        // GET: Mascot
        public ActionResult Mascot()
        {
            return View();
        }

        // GET: About
        public ActionResult About()
        {
            return View();
        }
        // GET: Recipe
        public ActionResult Recipe()
        {
            return View();
        }
        // GET: Blog
        public ActionResult Blog()
        {
            return View();
        }
        // GET: Contact
        public ActionResult Contact()
        {
            return View();
        }
    }

}