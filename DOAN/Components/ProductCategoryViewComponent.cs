using Microsoft.AspNetCore.Mvc;
using Model.Dao;
using DOAN.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DOAN.Components
{
    public class ProductCategoryViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new ProductCategoryDao();
            var items = model.ListAll();
            return View("Default", items);
        }
    }
}
