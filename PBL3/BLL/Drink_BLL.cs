﻿using PBL3.DAL;
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
            foreach (Food dr in Drink_DAL.Instance.getMenuByCategory(idcategory))
            {
                ucFood f = new ucFood();
                if (dr.imageFood != null)
                {
                    byte[] imageData = (byte[])dr.imageFood;
                    MemoryStream ms = new MemoryStream(imageData);
                    Image image = Image.FromStream(ms);
                    f.pictureBox1.Image = image;
                }
                f.lbNameFood.Text = dr.NameFood;
                f.lbPrice.Text = dr.price + " VNĐ";
                uc.Add(f);
            }
            return uc;
        }

    }
}