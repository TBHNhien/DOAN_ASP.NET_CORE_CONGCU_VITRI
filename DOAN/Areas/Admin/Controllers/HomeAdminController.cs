using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;




namespace DOAN.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeAdminController : BaseController
    {
        // GET: Admin/Home
        public IActionResult Index()
        {
            
            return View();
        }
    }
}