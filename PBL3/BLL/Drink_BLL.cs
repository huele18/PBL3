using PBL3.DAL;
using PBL3.DTO;
using PBL3.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Drawing;
using Guna.UI2.WinForms;

namespace PBL3.BLL
{
    public class Drink_BLL
    {
        private static Drink_BLL instance;
        public static Drink_BLL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Drink_BLL();
                }
                return instance;
            }
        }
        public DataGridView showDGV()
        {
            DataGridView dgv = new DataGridView();
            dgv.DataSource = Drink_DAL.Instance.getDrink().DataSource;
            return dgv;
        }
        public List<CBBItem> getCategoryCBB()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach(FoodCategory i in Drink_DAL.Instance.getAllFoodCategories())
            {
                data.Add(new CBBItem
                {
                    Value = i.idFoodCategory,
                    Text = i.Category
                });
            }
            return data;
        }
        public bool checkID(int id)
        {
            foreach (FoodCategory f in Drink_DAL.Instance.getAllFoodCategories())
            {
                if (f.idFoodCategory == id)
                {
                    return true;
                }
            }
            return false;
        }
        public void addFoodCategory(FoodCategory f)
        {
            Drink_DAL.Instance.addCategory(f);
        }
        public void editFoodCategory(FoodCategory f)
        {
            Drink_DAL.Instance.editCategory(f);
        }
        public Food getFoodById(string id)
        {
            foreach(Food f in Drink_DAL.Instance.GetFoods())
            {
                if(f.idFood.ToString() == id)
                    return f;
            }
            return null;
        }
        public bool checkIDFood(string id)
        {
            if(Drink_DAL.Instance.getDrinkById(id) == null)
            {
                return false; // không tồn tại
            }
            return true;
        }
        //public bool checkIDCategory(string id)
        //{
        //    if (Drink_DAL.Instance.getCategoryById(id) == null)
        //    {
        //        return false; // không tồn tại
        //    }
        //    return true;
        //}
        public bool checkData(Food f)
        {
            if (checkIDFood(f.idFood.ToString()))
            {
                MessageBox.Show("ID món đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public void addDrink(Food f)
        {
            if (checkData(f))
            {
                Drink_DAL.Instance.add(f);
            }
        }
        public void editDrink(Food after)
        {
            Drink_DAL.Instance.edit(after);
        }

        public void delDrink(int idfood)
        {
            Drink_DAL.Instance.del(idfood);
        }
        public DataGridView searchDrink(string s)
        {
            DataGridView dgv = new DataGridView();
            dgv.DataSource = Drink_DAL.Instance.search(s).DataSource;
            return dgv;
        }

        public List<Food> getMenuByCategory(int idcategory)
        {
            return Drink_DAL.Instance.getMenuByCategory(idcategory);
        }
        public FoodCategory GetFoodCategoryByID(string idcategory)
        {
            return Drink_DAL.Instance.getCategoryById(idcategory);
        }
        public List<Food> getTop3Bestseller()
        {
            List<Food> f = new List<Food>();
            foreach (var i in Drink_DAL.Instance.getBestSeller().Take(3))
            {
                int idfood = i.Key;
                Food food = Drink_BLL.Instance.getFoodById(idfood.ToString());
                f.Add(food);
            }
            return f;
        }
        public List<ucDrink> getMenuDrink(List<Food> list)
        {
            List<ucDrink> uc = new List<ucDrink>();
            foreach (Food dr in list)
            {
                ucDrink f = new ucDrink();
                if (dr.imageFood != null)
                {
                    byte[] imageData = (byte[])dr.imageFood;
                    MemoryStream ms = new MemoryStream(imageData);
                    Image image = Image.FromStream(ms);
                    f.imageDrink.Image = image;
                }
                f.lbID.Text = dr.idFood.ToString();
                f.lbNameFood.Text = dr.NameFood;
                f.lbPrice.Text = dr.price.ToString();
                f.imageDrink.Tag = dr.idFood;
                uc.Add(f);
            }
            return uc;
        }

        public List<Label> getCategories()
        {
            List<Label> list = new List<Label>();
            foreach (FoodCategory fc in Drink_DAL.Instance.getAllFoodCategories())
            {
                Label pic = new Label();
                pic.AutoSize = false;
                pic.Font = new Font("Times New Roman", 18F);
                pic.TextAlign = ContentAlignment.MiddleCenter;
                pic.Text = fc.Category.ToString();
                pic.Size = new Size(150, 150);
                pic.Margin = new Padding(10, 10, 10, 10);
                System.Drawing.Bitmap image = Properties.Resources.Category;
                pic.Image = image;
                pic.Tag = fc.idFoodCategory;
                list.Add(pic);
            }
            return list;
        }
    }
}
