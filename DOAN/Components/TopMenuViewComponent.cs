using Microsoft.AspNetCore.Mvc;
using Model.Dao;
using DOAN.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DOAN.Components
{
    public class TopMenuViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menuDao = new MenuDao();
            var items = menuDao.ListByGroupId(2); // Lấy dữ liệu menu
            return View("_TopMenu", items); // Trả về view với dữ liệu menu
        }
    }
}
