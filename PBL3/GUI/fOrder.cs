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
    public partial class fOrder : Form
    {
        public fOrder()
        {
            InitializeComponent();
            getTable();
        }

        public int addQuantity(int id)
        {
            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                var cellValue = row.Cells["idFood"].Value;
                if (cellValue != null && cellValue.ToString() == id.ToString()) 
                    return row.Index;
            }
            return -1;
        }
        public void AddDGV(int data1)
        {
            Food f = Drink_BLL.Instance.getFoodById(data1.ToString());
            int index = dgvOrders.Rows.Count;
            int rowIndexQuatity = addQuantity(f.idFood);
            if (rowIndexQuatity == -1)
            {
                DataGridViewRow row = dgvOrders.Rows[index - 1];
                dgvOrders.Rows.Add();
                dgvOrders.Rows[index - 1].Cells["idFood"].Value = data1;
                dgvOrders.Rows[index - 1].Cells["NameFood"].Value = f.NameFood;
                dgvOrders.Rows[index - 1].Cells["price"].Value = f.price;
                dgvOrders.Rows[index - 1].Cells["count"].Value = 1;
                dgvOrders.Rows[index - 1].Cells["Total"].Value = f.price;
            }
            else
            {
                string dgvRowCount = dgvOrders.Rows[rowIndexQuatity].Cells["count"].Value.ToString();
                string dgvRowPrice = dgvOrders.Rows[rowIndexQuatity].Cells["price"].Value.ToString();
                int count = Convert.ToInt32(dgvRowCount);
                int price = Convert.ToInt32(dgvRowPrice);
                count++;
                dgvOrders.Rows[rowIndexQuatity].Cells["count"].Value = count;
                dgvOrders.Rows[rowIndexQuatity].Cells["Total"].Value = count * price;
            }
        }

        public void getTable()
        {
            foreach(Button i in Table_BLL.Instance.GetTables())
            {
                flowLayoutPanel1.Controls.Add(i);
            }
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            fMenu m = new fMenu();
            m.addDataToGridViewDelegate += new fMenu.AddDataToGridView(AddDGV);
            m.ShowDialog();
            this.Show();
        }
    }
}
