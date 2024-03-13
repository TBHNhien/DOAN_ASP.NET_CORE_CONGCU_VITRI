using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;




namespace DOAN.Controllers
{
    public class HomeAdminController : Controller
    {
        // GET: Admin/Home
        public IActionResult Index()
        {
            
            return View();
        }
    }
}