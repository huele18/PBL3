using PBL3.BLL;
using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PBL3.GUI
{
    public partial class fOrder : Form
    {
        private static int idaccount = 0;
        public fOrder(int id)
        {
            InitializeComponent();
            idaccount = id;
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
            flowLayoutPanel1.Controls.Clear();
            foreach(Button i in Table_BLL.Instance.GetTables())
            {
                i.Click += BtTable_Click;
                flowLayoutPanel1.Controls.Add(i);
            }
        }
        public void setDGV(int id)
        {
            Bill b = Bill_BLL.Instance.getBillTableByIdTable(id);
            if (b != null)
            {
                txtIdBill.Text = b.idBill.ToString();
                List<ItemOrder> billInfos = Bill_BLL.Instance.getBillInfoByIdBill(b.idBill);
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
            }
        }

        private void BtTable_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int idtable = Convert.ToInt32(btn.Tag);
            txtTable.Text = btn.Text;

            txtIdBill.Text = "";
            dgvOrders.Rows.Clear();
            setDGV(idtable);

            //Bill b = Bill_BLL.Instance.getBillTableByIdTable(idtable);
            //if (b != null)
            //{
            //    txtIdBill.Text = b.idBill.ToString();
            //    List<ItemOrder> billInfos = Bill_BLL.Instance.getBillInfoByIdBill(idtable);
            //    if (billInfos.Count > 0)
            //    {
            //        foreach (ItemOrder bInf in billInfos)
            //        {
            //            Food f = Drink_BLL.Instance.getFoodById(bInf.idFood.ToString());
            //            int index = dgvOrders.Rows.Count;
            //            DataGridViewRow row = dgvOrders.Rows[index - 1];
            //            dgvOrders.Rows.Add();
            //            dgvOrders.Rows[index - 1].Cells["idFood"].Value = bInf.idFood;
            //            dgvOrders.Rows[index - 1].Cells["NameFood"].Value = f.NameFood;
            //            dgvOrders.Rows[index - 1].Cells["price"].Value = f.price;
            //            dgvOrders.Rows[index - 1].Cells["count"].Value = bInf.billquantity;
            //            dgvOrders.Rows[index - 1].Cells["Total"].Value = f.price * bInf.billquantity;
            //        }
            //    }
            //}
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            fMenu m = new fMenu();
            m.addDataToGridViewDelegate += new fMenu.AddDataToGridView(AddDGV);
            m.ShowDialog();
            this.Show();
        }

        private void btGiam_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 1)
            {
                string dgvRowCount = dgvOrders.CurrentRow.Cells["count"].Value.ToString();
                string dgvRowPrice = dgvOrders.CurrentRow.Cells["price"].Value.ToString();
                int count = Convert.ToInt32(dgvRowCount);
                int price = Convert.ToInt32(dgvRowPrice);
                count--;
                if (count == 0)
                {
                    dgvOrders.Rows.RemoveAt(dgvOrders.CurrentRow.Index);
                }
                else
                {
                    dgvOrders.CurrentRow.Cells["count"].Value = count;
                    dgvOrders.CurrentRow.Cells["Total"].Value = count * price;

                }
            }
            else
                MessageBox.Show("Chọn 1 hàng để thực hiện thao tác");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvOrders.SelectedRows)
                {
                    dgvOrders.Rows.RemoveAt(row.Index);
                }
                //dgvOrders.Rows.RemoveAt(dgvOrders.CurrentRow.Index);
            }
            else
                MessageBox.Show("Mỗi lần chỉ xóa được 1 món");
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            int index = dgvOrders.Rows.Count - 1;
            if (index <= 0)
            {
                //thay doi trang thai cua TableFood
                TableFood tf = Table_BLL.Instance.getTableFoodById(Convert.ToInt32(txtTable.Text));
                tf.status = "Trống";
                Table_BLL.Instance.editTable(tf);

                getTable();

                //xoa bill, itemOrder cuar bill
                if (!string.IsNullOrEmpty(txtIdBill.Text))
                {
                Bill_BLL.Instance.removeBill(txtIdBill.Text);
                }
            }
            else
            {
                //thay doi trang thai cua ban
                TableFood tf = Table_BLL.Instance.getTableFoodById(Convert.ToInt32(txtTable.Text));
                tf.status = "Có Người";
                Table_BLL.Instance.editTable(tf);

                getTable();

                //luu bill
                if (string.IsNullOrEmpty(txtIdBill.Text))
                {
                    Bill bill = new Bill()
                    {
                        Customer = "Chua dat ten",
                        paymenttime = null,
                        thanhtoan = false,
                        idTable = Convert.ToInt32(txtTable.Text),
                        idAccount = idaccount
                    };
                    Bill_BLL.Instance.addBill(bill);

                    //setDGV(Convert.ToInt32(txtTable.Text));
                    Bill b = Bill_BLL.Instance.getBillTableByIdTable(Convert.ToInt32(txtTable.Text));
                    txtIdBill.Text = b.idBill.ToString();
                }
                saveOrder();

                //luu itemOrder
                //Bill_BLL.Instance.delItemOrder(txtIdBill.Text);

                //for (int i = 0; i < dgvOrders.Rows.Count - 1; i++)
                //{
                //    ItemOrder item = new ItemOrder()
                //    {
                //        idBill = Convert.ToInt32(txtIdBill.Text),
                //        idFood = Convert.ToInt32(dgvOrders.Rows[i].Cells["idFood"].Value.ToString()),
                //        billquantity = Convert.ToInt32(dgvOrders.Rows[i].Cells["count"].Value.ToString()),
                //    };
                //    Bill_BLL.Instance.updateItemOrder(item);
                //}
                //MessageBox.Show("Đã cập nhật thành công danh sách đồ uống", "Thông báo",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public void saveOrder()
        {
            Bill_BLL.Instance.delItemOrder(txtIdBill.Text);

            for (int i = 0; i < dgvOrders.Rows.Count - 1; i++)
            {
                ItemOrder item = new ItemOrder()
                {
                    idBill = Convert.ToInt32(txtIdBill.Text),
                    idFood = Convert.ToInt32(dgvOrders.Rows[i].Cells["idFood"].Value.ToString()),
                    billquantity = Convert.ToInt32(dgvOrders.Rows[i].Cells["count"].Value.ToString()),
                };
                Bill_BLL.Instance.updateItemOrder(item);
            }
            MessageBox.Show("Đã cập nhật thành công danh sách đồ uống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
