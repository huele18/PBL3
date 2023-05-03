using PBL3.BLL;
using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI
{
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
            setCBBCategory();
            getFood();
        }
        public void getFood()
        {
            foreach(ucFood i in Drink_BLL.Instance.getMenu(0))
            {
                flowLayoutPanel1.Controls.Add(i);
            }
        }
        public void setCBBCategory()
        {
            cbbCategory.Items.Add(new CBBItem { Value = 0, Text = "Tất cả" });
            cbbCategory.Items.AddRange(Drink_BLL.Instance.getCategoryCBB().ToArray());
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            int idcategory = ((CBBItem)cbbCategory.SelectedItem).Value;
            foreach (ucFood i in Drink_BLL.Instance.getMenu(idcategory))
            {
                flowLayoutPanel1.Controls.Add(i);
            }
        }
    }
}
