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
    public partial class fEditCategoryFood : Form
    {
        public fEditCategoryFood()
        {
            InitializeComponent();
            getCBB();
        }

        private void getCBB()
        {
            cbbCategory.Items.AddRange(Drink_BLL.Instance.getCategoryCBB().ToArray());
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            FoodCategory fc = new FoodCategory();
            fc.idFoodCategory = Convert.ToInt32(txtID.Text);
            fc.Category = txtName.Text;
            Drink_BLL.Instance.editFoodCategory(fc);
            MessageBox.Show("Đã cập nhật thông tin thành công");
            this.Close();
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
                MessageBox.Show("Thêm loại đồ uống thành công");
                this.Close();
            }
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = ((CBBItem)cbbCategory.SelectedItem).Value.ToString();
            txtName.Text = ((CBBItem)cbbCategory.SelectedItem).Text;
            txtID.ReadOnly = true;
            btAdd.Enabled = false;
        }
    }
}
