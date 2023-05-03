using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    public class FoodCategory_DAL
    {
        private static FoodCategory_DAL instance;
        public static FoodCategory_DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FoodCategory_DAL();
                }
                return instance;
            }
            private set { }
        }
        public List<FoodCategory> getFoodCategory()
        {
            List<FoodCategory> l = new List<FoodCategory>();
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                l = db.FoodCategories.ToList();
            }
            return l;
        }
        public void add(FoodCategory fc)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                db.FoodCategories.Add(fc);
                db.SaveChanges();
            }
        }
    }
}
