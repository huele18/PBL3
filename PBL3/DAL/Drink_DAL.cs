using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO;

namespace PBL3.DAL
{
    public class Drink_DAL
    {
        private static Drink_DAL instance;
        public static Drink_DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Drink_DAL();
                }
                return instance;
            }
            private set { }
        }
        public DataGridView getDrink()
        {
            DataGridView drink = new DataGridView();
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                drink.DataSource = db.Foods
                    .Select(p => new { p.idFood, p.FoodCategory.Category, p.NameFood, p.price, p.imageFood }).ToList();
            }
            return drink;
        }
        public List<FoodCategory> getAllFoodCategories()
        {
            //QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities();
            List<FoodCategory> fc = new List<FoodCategory>();
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                fc = db.FoodCategories.Select(p => p).ToList();
            }
            return fc;
        }
        public void addCategory(FoodCategory fc)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                db.FoodCategories.Add(fc);
                db.SaveChanges();
            }
        }
        public void editCategory(FoodCategory fc)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                FoodCategory foodCategory = db.FoodCategories.Find(fc.idFoodCategory);
                foodCategory.Category = fc.Category;
                db.SaveChanges();
            }
        }
        public List<Food> GetFoods()
        {
            List<Food> lf = new List<Food>();
            using(QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                lf = db.Foods.Select(p => p).ToList();
            }
            return lf;
        }
        public Food getDrinkById(string id)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                return db.Foods.Where(p => p.idFood.ToString() == id).FirstOrDefault();
            }
        }
        public FoodCategory getCategoryById(string id)
        {
            QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities();
            return db.FoodCategories.Where(p => p.idFoodCategory.ToString() == id).FirstOrDefault();
        }
        public void add(Food f)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                db.Foods.Add(f);
                db.SaveChanges();
                MessageBox.Show("Đã thêm thành công đồ uống mới vào Menu", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void edit(Food after)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                Food f = db.Foods.Find(after.idFood);
                f.NameFood = after.NameFood;
                f.idCategory = after.idCategory;
                f.price = after.price;
                f.imageFood = after.imageFood;
                db.SaveChanges();
                MessageBox.Show("Đã cập nhật thành công đồ uống vào Menu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void del(int idfood)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                Food f = db.Foods.Find(idfood);
                db.Foods.Remove(f);
                db.SaveChanges();
            }
        }
        public DataGridView search(string search)
        {
            //QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities();
            DataGridView drink = new DataGridView();
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                drink.DataSource = db.Foods.Where
                    (
                        p => p.NameFood.ToUpper().Contains(search.ToUpper()) ||
                             p.FoodCategory.Category.ToUpper().Contains(search.ToUpper())
                    )
                    .Select(p => new { p.idFood, p.FoodCategory.Category, p.NameFood, p.price }).ToList();
            }
            return drink;
        }
        
        public List<Food> getMenuDrink()
        {
            List<Food> f = new List<Food>();
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                f = db.Foods.ToList();
            }
            return f;
        }
        public List<Food> getMenuByCategory(int idcategory)
        {
            List<Food> f = new List<Food>();
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                if (idcategory == 0)
                    f = db.Foods.ToList();
                else
                    f = db.Foods.Where(p => p.idCategory == idcategory).ToList();
            }
            return f;
        }
        public List<IGrouping<int, ItemOrder>> sortDrink()
        {
            List<IGrouping<int, ItemOrder>> f = new List<IGrouping<int, ItemOrder>>();
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                f = db.ItemOrders
                    .Where(p => p.idFood != null && p.Bill.thanhtoan == true)
                    .GroupBy(p => p.idFood.Value)
                    .OrderByDescending(p => p.Sum(io => io.billquantity))
                    .ToList();
            }
            return f;
        }


        //public List<KeyValuePair<string, int>> Sort()
        //{
        //    List<KeyValuePair<string, int>> f = new List<KeyValuePair<string, int>>();
        //    using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
        //    {
        //        f = db.ItemOrders
        //            .Where(p => p.idFood != null && p.Bill.thanhtoan == true)
        //            .GroupBy(io => io.Food.NameFood)
        //            .Select(group => new KeyValuePair<string, int>(group.Key, group.Sum(io => io.billquantity).Value))
        //            .OrderByDescending(io => io.Value)
        //            .ToList();
        //    }
        //    return f;
        //}

        public List<KeyValuePair<string, int>> Sort()
        {
            List<KeyValuePair<string, int>> f = new List<KeyValuePair<string, int>>();
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                var queryResult = db.ItemOrders
                    .Where(p => p.idFood != null && p.Bill.thanhtoan == true)
                    .GroupBy(io => io.Food.NameFood)
                    .Select(group => new { Name = group.Key, Quantity = group.Sum(io => io.billquantity) })
                    .OrderByDescending(io => io.Quantity)
                    .ToList();

                foreach (var item in queryResult)
                {
                    f.Add(new KeyValuePair<string, int>(item.Name, item.Quantity.Value));
                }
            }
            return f;
        }
    }
}
