using DOAN.Models;
//using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class ContentDao
    {
        OnlineShop10Context db = null;
        public ContentDao()
        {
            db = new OnlineShop10Context();
        }

        public Content GetByID(long id)
        {
            return db.Contents.Find(id);
        }
    }
}
