using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace DOAN.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {
        // GET: Admin/Category
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }

        [Area("Admin")]
        public IActionResult Create()
        {
            return View();
        }
    }
}