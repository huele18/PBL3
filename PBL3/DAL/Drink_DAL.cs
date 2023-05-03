using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities();
            DataGridView drink = new DataGridView();
            drink.DataSource = db.Foods
                .Select(p => new { p.idFood, p.FoodCategory.Category, p.NameFood, p.price, p.imageFood }).ToList();
            return drink;
        }
        public List<FoodCategory> getAllFoodCategories()
        {
            QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities();
            List<FoodCategory> fc = new List<FoodCategory>();
            fc = db.FoodCategories.Select(p => p).ToList();
            return fc;
        }
        public Food getDrinkById(string id)
        {
            QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities();
            foreach (Food f in db.Foods)
            {
                if (f.idFood.ToString() == id)
                {
                    return f;
                }
            }
            return null;
        }
        //public Food getCategoryById(string id)
        //{
        //    QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities();
        //    foreach (Food f in db.Foods)
        //    {
        //        if (f.idCategory.ToString() == id)
        //        {
        //            return f;
        //        }
        //    }
        //    return null;
        //}
        public void add(Food f)
        {
            using (QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities())
            {
                db.Foods.Add(f);
                db.SaveChanges();
                MessageBox.Show("Đã thêm thành công đồ uống mới vào Menu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Đã cập nhật thành công đồ uống vào Menu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities();
            DataGridView drink = new DataGridView();
            drink.DataSource = db.Foods.Where
                (
                    p => p.NameFood.ToUpper().Contains(search.ToUpper()) ||
                         p.FoodCategory.Category.ToUpper().Contains(search.ToUpper())
                )
                .Select(p => new { p.idFood, p.FoodCategory.Category, p.NameFood, p.price }).ToList();
            return drink;
        }
        
        public List<Food> getMenuDrink()
        {
            List<Food> f = new List<Food>();
            QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities();
            f = db.Foods.ToList();
            return f;
        }
        public List<Food> getMenuByCategory(int idcategory)
        {
            List<Food> f = new List<Food>();
            QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities();
            if(idcategory == 0)
                f = db.Foods.ToList();
            else
                f = db.Foods.Where(p => p.idCategory == idcategory).ToList();
            return f;
        }
    }
}
