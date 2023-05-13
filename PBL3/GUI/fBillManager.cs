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
    public partial class fBillManager : Form
    {
        public fBillManager()
        {
            InitializeComponent();
            setCBBTable();
            DGV();
        }
        public void setCBBTable()
        {
            cbbTable.Items.AddRange(Table_BLL.Instance.setCBBTable().ToArray());
        }
        public void setDGV()
        {
            dgvInvoice.DataSource = Bill_BLL.Instance.showDGV().DataSource;
            for (int i = 0; i < dgvInvoice.Rows.Count; i++)
            {
                string s = dgvInvoice.Rows[i].Cells["idBill"].Value.ToString();
                string tongtien = Bill_BLL.Instance.getTotal(s).ToString();
                dgvInvoice.Rows[i].Cells["tong"].Value = tongtien;
            }
        }

        public void DGV()
        {
            foreach(Bill b in Bill_BLL.Instance.getBills())
            {
                int index = dgvInvoice.Rows.Count;
                DataGridViewRow row = dgvInvoice.Rows[index - 1];
                dgvInvoice.Rows.Add();
                dgvInvoice.Rows[index - 1].Cells["idBill"].Value = b.idBill;
                dgvInvoice.Rows[index - 1].Cells["Customer"].Value = b.Customer;
                dgvInvoice.Rows[index - 1].Cells["idAccount"].Value = b.idAccount;
                dgvInvoice.Rows[index - 1].Cells["paymenttime"].Value = b.paymenttime;
                dgvInvoice.Rows[index - 1].Cells["name"].Value = Table_BLL.Instance.getTableFoodById(b.idTable).name;
                dgvInvoice.Rows[index - 1].Cells["tong"].Value = Bill_BLL.Instance.getTotal(b.idBill.ToString());
                DataGridViewComboBoxCell cbbcell = new DataGridViewComboBoxCell();
                cbbcell.Items.AddRange(Bill_BLL.Instance.getOrderedDrinnkCBB(b.idBill.ToString()).ToArray());
                dgvInvoice.Rows[index - 1].Cells["cbborder"] = cbbcell;
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (rbPaid.Checked == true)
            {
                check = true;
            }
            Bill bill = new Bill
            {
                idBill = Convert.ToInt32(txtIdBill.Text),
                Customer = txtNameCustomer.Text,
                paymenttime = (DateTime)billDate.Value,
                thanhtoan = check,
                idTable = ((CBBItem)cbbTable.SelectedItem).Value,
                idAccount = Convert.ToInt32(txtIdAcc.Text),
            };
            Bill_BLL.Instance.editBill(bill);
            txtIdBill.Text = "";
            txtIdAcc.Text = "";
            txtNameCustomer.Text = "";
            total.Text = "";
            cbbTable.Text = "";
            setDGV();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvInvoice.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgvInvoice.SelectedRows)
                {
                    string id = i.Cells["idBill"].Value.ToString();
                    Bill_BLL.Instance.delBill(id);
                }
                MessageBox.Show("Đã xóa thành công bàn ra khỏi danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Chưa chọn cột muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            setDGV();
        }

        private void dgvInvoice_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                txtIdBill.Text = dgvInvoice.Rows[index].Cells["idBill"].Value.ToString();
                txtNameCustomer.Text = dgvInvoice.Rows[index].Cells["Customer"].Value.ToString();
                txtIdAcc.Text = dgvInvoice.Rows[index].Cells["idAccount"].Value.ToString();
                billDate.Text = dgvInvoice.Rows[index].Cells["paymenttime"].Value.ToString();
                cbbTable.Text = dgvInvoice.Rows[index].Cells["name"].Value.ToString();
                total.Text = dgvInvoice.Rows[index].Cells["tong"].Value.ToString();


                //cbborder.DataSource = null;
                //cbborder.DataSource = Bill_BLL.Instance.getOrderedDrinnkCBB(txtIdBill.Text);
                //string tongtien = Bill_BLL.Instance.getTotal(txtIdBill.Text).ToString();
                //total.Text = tongtien;
                //dgvInvoice.Rows[index].Cells["tong"].Value = tongtien;
            }
            catch (Exception ex) { }
        }
    }
}
