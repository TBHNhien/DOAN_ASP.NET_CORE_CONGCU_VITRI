using DOAN.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
//using System.Web.Routing;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DOAN.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        //protected override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    var session = (UserLogin)Session[CommonConstants.USER_SESSION];
        //    if (session==null)
        //    {
        //        filterContext.Result = new RedirectToRouteResult(new
        //            RouteValueDictionary(new { controller = "Login" , action = "Index" , Area = "Admin" }));
        //    }
        //    base.OnActionExecuting(filterContext);
        //}

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            var session = context.HttpContext.Session.GetString(CommonConstants.USER_SESSION);
            if (string.IsNullOrEmpty(session))
            {
                context.Result = new RedirectToActionResult("Index", "Login", new { Area = "Admin" });
            }
        }

        protected void SetAlert(string message,string type)
        {
            TempData["AlertMessage"] = message;
            //TempData tên lớp , ["AlertMessage"] tên của key
            if (type == "success")
            {
                TempData["AlertType"] = "alert-success";
            }
            else if(type == "warning")
            {
                TempData["AlertType"] = "alert-warming";
            }
            else if (type == "error")
            {
                TempData["AlertType"] = "alert-danger";
            }
        }
    }
}