using PBL3.BLL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI
{
    public partial class fDrinkMenu : Form
    {
        public delegate void AddDataToGridView(int data1);
        public AddDataToGridView addDataToGridViewDelegate;
        public fDrinkMenu()
        {
            InitializeComponent();
            setCBBCategory();
            getFood();
        }
        public void getFood()
        {
            foreach (ucDrink i in Drink_BLL.Instance.getMenuDrink(Drink_BLL.Instance.getMenuByCategory(0)))
            {
                i.imageDrink.Click += BtSelect_Click;
                flowLayoutPanel1.Controls.Add(i);
            }
        }
        public void setCBBCategory()
        {
            cbbCategory.Items.Add(new CBBItem { Value = 0, Text = "Tất cả" });
            cbbCategory.Items.AddRange(Drink_BLL.Instance.getCategoryCBB().ToArray());
        }
        private void BtSelect_Click(object sender, EventArgs e)
        {
            PictureBox bt = (PictureBox)sender;
            int idfood = Convert.ToInt32(bt.Tag);
            if (bt.Tag != null)
                if (addDataToGridViewDelegate != null)
                    addDataToGridViewDelegate(idfood);
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            int idcategory = ((CBBItem)cbbCategory.SelectedItem).Value;
            List<Food> food = Drink_BLL.Instance.getMenuByCategory((int)idcategory);
            foreach (ucDrink i in Drink_BLL.Instance.getMenuDrink(food))
            {
                i.imageDrink.Click += BtSelect_Click;
                flowLayoutPanel1.Controls.Add(i);
            }
        }

        private void btBestSeller_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (ucDrink i in Drink_BLL.Instance.getMenuDrink(Drink_BLL.Instance.getTop3Bestseller()))
            {
                i.imageDrink.Click += BtSelect_Click;
                flowLayoutPanel1.Controls.Add(i);
            }
        }
    }
}
