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
        
        public List<ucFood> getMenu(int idcategory)
        {
            List<ucFood> uc = new List<ucFood>();
            List<Food> food = Drink_DAL.Instance.getMenuByCategory(idcategory);
            foreach (Food dr in sortedMenuByFreqency(food))
            {
                ucFood f = new ucFood();
                if (dr.imageFood != null)
                {
                    byte[] imageData = (byte[])dr.imageFood;
                    MemoryStream ms = new MemoryStream(imageData);
                    Image image = Image.FromStream(ms);
                    f.pictureBox1.Image = image;
                }
                f.lbID.Text = dr.idFood.ToString();
                f.lbNameFood.Text = dr.NameFood;
                f.lbPrice.Text = dr.price.ToString();
                f.btSelect.Tag = dr.idFood;
                uc.Add(f);
            }
            return uc;
        }
        public List<Food> sortedMenuByFreqency(List<Food> food)
        {
            List<ItemOrder> order = Bill_BLL.Instance.getDetailedBillByMonth();
            Dictionary<int, int> countMap = new Dictionary<int, int>();
            foreach (ItemOrder item in order)
            {
                if (countMap.ContainsKey(Convert.ToInt32(item.idFood)))
                {
                    countMap[Convert.ToInt32(item.idFood)]+= Convert.ToInt32(item.billquantity);
                }   
                else
                    countMap[Convert.ToInt32(item.idFood)] = Convert.ToInt32(item.billquantity);
                
            }
            // Sắp xếp danh sách food dựa trên số lần xuất hiện của idfood trong Dictionary
            List<Food> sortedFood = food.OrderByDescending(f => countMap.ContainsKey(f.idFood) ? countMap[f.idFood] : 0).ToList();
            return sortedFood;
        }
    }
}
