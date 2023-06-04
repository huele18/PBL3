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
            setCBB();
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
                paymenttime = (DateTime)billDate.Value,
                thanhtoan = check,
                idTable = ((CBBItem)cbbTable.SelectedItem).Value,
                idAccount = Convert.ToInt32(txtIdAcc.Text),
            };
            Bill_BLL.Instance.editBill(bill);
            txtIdBill.Text = "";
            txtIdAcc.Text = "";
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
                    int id = Convert.ToInt32(i.Cells["idBill"].Value);
                    Bill_BLL.Instance.delBill(id);
                }
                MessageBox.Show("Đã xóa thành công hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((CBBItem)cbFilter.SelectedItem).Value;
            switch (index)
            {
                case 0:
                    dgvInvoice.DataSource = Bill_BLL.Instance.showDGV().DataSource;
                    break;
                case 1:
                    dgvInvoice.DataSource = Bill_BLL.Instance.getBillbyDay().DataSource;
                    break;
                case 2:
                    dgvInvoice.DataSource = Bill_BLL.Instance.getBillbyMonth().DataSource;
                    break;
                case 3:
                    dgvInvoice.DataSource = Bill_BLL.Instance.getBillbyYear().DataSource;
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = (DateTime)searchDate.Value;
            dgvInvoice.DataSource = Bill_BLL.Instance.searchBill(dateTime).DataSource;
        }
        public void setCBB()
        {
            List<CBBItem> list = new List<CBBItem>
            {
                new CBBItem
                {
                    Value = 0,
                    Text = "Tất cả"
                },
                new CBBItem
                {
                    Value = 1,
                    Text = "Theo ngày"
                },
                new CBBItem
                {
                    Value = 2,
                    Text = "Theo tháng"
                },
                new CBBItem
                {
                    Value = 3,
                    Text = "Theo năm"
                },
            };
            cbFilter.DataSource = list;
            cbFilter.SelectedIndex = 0;
        }
    }
}
