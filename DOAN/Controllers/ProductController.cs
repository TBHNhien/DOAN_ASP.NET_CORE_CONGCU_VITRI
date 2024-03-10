using Microsoft.AspNetCore.Mvc;

namespace DOAN.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
