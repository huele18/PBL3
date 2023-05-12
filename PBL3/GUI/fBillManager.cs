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
            setDGV();
        }
        public void setCBBTable()
        {
            cbbTable.Items.AddRange(Table_BLL.Instance.setCBBTable().ToArray());
        }
        public void setDGV()
        {
            QuanLyQuanCafeEntities db = new QuanLyQuanCafeEntities();
            dgvInvoice.DataSource = Bill_BLL.Instance.showDGV().DataSource;
            for (int i = 0; i < dgvInvoice.Rows.Count; i++)
            {
                string s = dgvInvoice.Rows[i].Cells["idBill"].Value.ToString();
                string tongtien = Bill_BLL.Instance.getTotal(s).ToString();
                dgvInvoice.Rows[i].Cells["tong"].Value = tongtien;
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

        private void fBillManager_Load_1(object sender, EventArgs e)
        {
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
                if (Convert.ToBoolean(dgvInvoice.Rows[index].Cells["thanhtoan"].Value))
                {
                    rbPaid.Checked = true;
                }
                else
                {
                    rbUnpaid.Checked = true;
                }
                cbbTable.Text = dgvInvoice.Rows[index].Cells["name"].Value.ToString();

                string tongtien = Bill_BLL.Instance.getTotal(txtIdBill.Text).ToString();
                total.Text = tongtien;
                dgvInvoice.Rows[index].Cells["tong"].Value = tongtien;
            }
            catch (Exception ex) { }
        }



        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idbill = dgvInvoice.Rows[e.RowIndex].Cells["idBill"].Value.ToString();
            DetailBill dtb = new DetailBill(idbill);
            dtb.ShowDialog();
        }
    }
}
