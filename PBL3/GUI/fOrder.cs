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
        private int idacc;
        public fOrder(int idacc)
        {
            InitializeComponent();
            getTable();
            this.idacc = idacc;
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
            foreach (Button i in Table_BLL.Instance.GetTables())
            {
                i.Click += BtTable_Click;
                flowLayoutPanel1.Controls.Add(i);
            }
        }
        private void BtTable_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int idtable = Convert.ToInt32(btn.Tag);
            txtTable.Text = btn.Text;

            Bill b = Bill_BLL.Instance.getBillTableByIdTable(idtable);
            if (b != null)
            {
                txtIdBill.Text = b.idBill.ToString();

            }
            List<ItemOrder> billInfos = Bill_BLL.Instance.getBillInfoByIdBill(idtable);
            dgvOrders.Rows.Clear();
            if (billInfos.Count > 0)
            {
                foreach (ItemOrder bInf in billInfos)
                {
                    Food f = Drink_BLL.Instance.getFoodById(bInf.idFood.ToString());
                    int index = dgvOrders.Rows.Count;
                    DataGridViewRow row = dgvOrders.Rows[index - 1];
                    dgvOrders.Rows.Add();
                    dgvOrders.Rows[index - 1].Cells["idFood"].Value = bInf.idFood;
                    dgvOrders.Rows[index - 1].Cells["NameFood"].Value = f.NameFood;
                    dgvOrders.Rows[index - 1].Cells["price"].Value = f.price;
                    dgvOrders.Rows[index - 1].Cells["count"].Value = bInf.billquantity;
                    dgvOrders.Rows[index - 1].Cells["Total"].Value = f.price * bInf.billquantity;
                }
            }
            else
            {
                if (b == null)
                    txtIdBill.Text = "";
            }
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            fMenu m = new fMenu();
            m.addDataToGridViewDelegate += new fMenu.AddDataToGridView(AddDGV);
            m.ShowDialog();
            this.Show();
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in dgvOrders.SelectedRows)
                {
                    dgvOrders.Rows.RemoveAt(item.Index);
                }
            }
            else
            {
                MessageBox.Show("Chọn (những) món muốn hủy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttongiam_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in dgvOrders.SelectedRows)
                {
                    if(Convert.ToInt32(dgvOrders.Rows[item.Index].Cells["count"].Value) > 1)
                    {
                        dgvOrders.Rows[item.Index].Cells["count"].Value = Convert.ToInt32(dgvOrders.Rows[item.Index].Cells["count"].Value) - 1;
                        int price = Convert.ToInt32(dgvOrders.Rows[item.Index].Cells["price"].Value);
                        int count = Convert.ToInt32(dgvOrders.Rows[item.Index].Cells["count"].Value);
                        dgvOrders.Rows[item.Index].Cells["Total"].Value = price * count;
                    }
                    else
                    {
                        dgvOrders.Rows.RemoveAt(item.Index);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn (những) món muốn giảm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            //thêm bill
            Bill bill = new Bill();
            try
            {
                bill.idBill = Convert.ToInt32(txtIdBill.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("Sai định dạng ID!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DateTime td = DateTime.Now;
            bill.paymenttime = td;
            bill.thanhtoan = false;
            bill.idAccount = idacc;
            bill.idTable = Table_BLL.Instance.getTableIDByName("Bàn " + txtTable.Text);
            //thêm item order
            List<ItemOrder> lio = new List<ItemOrder>();
            for (int i = 0; i < dgvOrders.Rows.Count; i++)
            {
                ItemOrder io = new ItemOrder();
                io.idBill = bill.idBill;
                io.idFood = Convert.ToInt32(dgvOrders.Rows[i].Cells["idFood"].Value);
                io.billquantity = Convert.ToInt32(dgvOrders.Rows[i].Cells["count"].Value);
                lio.Add(io);
            }
            Bill_BLL.Instance.addBill(bill, lio);
            //bàn có người
            TableFood tbf = Table_BLL.Instance.getTableFoodById(bill.idBill);
            tbf.status = "Có Người";
            Table_BLL.Instance.editTable(tbf);
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {

        }
    }
}
