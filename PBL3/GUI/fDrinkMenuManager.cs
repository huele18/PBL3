using Guna.UI2.WinForms;
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
    public partial class fDrinkMenuManager : Form
    {
        public fDrinkMenuManager()
        {
            InitializeComponent();
            getCategory();
            getDrinkMenu();
        }
        private void getCategory()
        {
            flpCategory.Controls.Clear();
            foreach (Label p in Drink_BLL.Instance.getCategories())
            {
                p.Click += category_Click;
                flpCategory.Controls.Add(p);
            }
        }

        private void getDrinkMenu()
        {
            flpDrink.Controls.Clear();
            List<Food> food = Drink_BLL.Instance.getMenuByCategory(0);
            foreach (ucDrink i in Drink_BLL.Instance.getMenuDrink(food))
            {
                i.imageDrink.Click += btEdit_Click;
                flpDrink.Controls.Add(i);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            int idf = Convert.ToInt32(pic.Tag.ToString());
            fDetailDrink detail = new fDetailDrink(idf);
            detail.ShowDialog();
            getDrinkMenu();
        }

        private void category_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            int idcategory = Convert.ToInt32(lb.Tag);
            List<Food> food = Drink_BLL.Instance.getMenuByCategory(idcategory);
            flpDrink.Controls.Clear();
            foreach (ucDrink i in Drink_BLL.Instance.getMenuDrink(food))
            {
                i.imageDrink.Click += btEdit_Click;
                flpDrink.Controls.Add(i);
            }
        }

        private void btAll_Click(object sender, EventArgs e)
        {
            getDrinkMenu();
        }

        private void btEditCategory_Click(object sender, EventArgs e)
        {
            fEditCategoryFood ec = new fEditCategoryFood();
            ec.ShowDialog();
            getCategory();
        }

        private void btAddDrink_Click(object sender, EventArgs e)
        {
            fDetailDrink d = new fDetailDrink();
            d.ShowDialog();
            getDrinkMenu();
        }

        private void btBSeller_Click(object sender, EventArgs e)
        {
            flpDrink.Controls.Clear();
            List<Food> food = Drink_BLL.Instance.getTop3Bestseller();
            foreach (ucDrink i in Drink_BLL.Instance.getMenuDrink(food))
            {
                i.imageDrink.Click += btEdit_Click;
                flpDrink.Controls.Add(i);
            }
        }
    }
}
