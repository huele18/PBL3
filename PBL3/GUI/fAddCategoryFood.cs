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
    public partial class fAddCategoryFood : Form
    {
        public fAddCategoryFood()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FoodCategory fc = new FoodCategory();
            fc.idFoodCategory = Convert.ToInt32(txtID.Text);
            fc.Category = txtName.Text;
            if (Drink_BLL.Instance.checkID(fc.idFoodCategory))
                MessageBox.Show("ID loại đồ uống đã tồn tại");
            else
            {
                Drink_BLL.Instance.addFoodCategory(fc);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
