
using DOAN.Areas.Admin.Models;
using DOAN.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Model.Dao;
using Newtonsoft.Json;

namespace DOAN.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.UserName, Encryptor.MD5Hash(model.Password));
                if (result == 1)
                {
                    var user = dao.GetById(model.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.UserName;
                    userSession.UserID = user.Id;
                    //Session.Add(CommonConstants.USER_SESSION, userSession);

                    // Gán giá trị cho session
                    HttpContext.Session.SetString(CommonConstants.USER_SESSION, JsonConvert.SerializeObject(userSession));
                 

                    return RedirectToAction("Index", "Home");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại .");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Tài khoản đang bị khoá .");
                }
                else if (result == -2)
                {
                    ModelState.AddModelError("", "Mật khẩu không đúng .");
                }
                else
                {
                    ModelState.AddModelError("", "đăng nhập không đúng .");
                }
            }
            return View("Index");
        }
    }
}