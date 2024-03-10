using DOAN.Models;
using Microsoft.AspNetCore.Mvc;
using Model.Dao;
using System.Diagnostics;

namespace DOAN.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Slides = new SlideDao().ListAll();
            var productDao = new ProductDao();
            ViewBag.NewProducts = productDao.ListNewProduct(3);
            ViewBag.ListFeatureProducts = productDao.ListFeatureProduct(3);

            return View();
        }


        //public PartialViewResult TopMenu()
        //{
        //    var menus = new MenuDao().ListByGroupId(2);
        //    if (menus == null || !menus.Any())
        //    {
        //        menus = new List<DOAN.Models.Menu>(); // Tạo một list rỗng để tránh null reference
        //    }
        //    return PartialView("_TopMenu", menus);
        //}



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
