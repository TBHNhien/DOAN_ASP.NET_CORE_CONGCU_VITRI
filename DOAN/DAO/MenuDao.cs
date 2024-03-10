using DOAN.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    
    public class MenuDao
    {
        OnlineShop10Context db = null;
        public MenuDao()
        {
            db = new OnlineShop10Context();
        }

        public List<Menu> ListByGroupId(int groupId)
        {

            return db.Menus.Where(x => x.TypeId == groupId && x.Status == true).OrderBy(x=>x.DisplayOrder).ToList();
        }

    }
}
