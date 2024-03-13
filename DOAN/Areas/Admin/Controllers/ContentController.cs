using Model.Dao;
//using Model.EF;
using DOAN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DOAN.Areas.Admin.Controllers
{
    public class ContentController : Controller
    {
        // GET: Admin/Content
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            SetViewBag();
            return View();
        }

        [HttpGet]
        public IActionResult Edit(long id)
        {
            var dao = new ContentDao();
            var content = dao.GetByID(id);
            SetViewBag(content.CategoryId);
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Content model)
        {
            if (ModelState.IsValid)
            {

            }
            SetViewBag(model.CategoryId);
            return View();
        }


        [HttpPost]
        //[ValidateInput(false)]
        public IActionResult Create(Content model)
        {
            if (ModelState.IsValid)
            {

            }
            SetViewBag();
            return View();
        }

        public void SetViewBag(long? selectedId = null)
        {
            var dao = new CategoryDao();
            ViewBag.CategoryID = new SelectList(dao.ListAll(), "ID", "Name", selectedId);
        }
    }
}