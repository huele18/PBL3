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
    public partial class fBill : Form
    {
        public fBill(string idbill, string table, string staffname)
        {
            InitializeComponent();
            lbIdBill.Text = idbill;
            lbStaff.Text = staffname;
            lbTable.Text = table;
            lbTime.Text = DateTime.Now.ToString();
            lbTong.Text = TongTien(idbill).ToString();
            dgvBillInfo.DataSource = Bill_BLL.Instance.getDetailBill(idbill).DataSource;
            for (int i = 0; i < dgvBillInfo.Rows.Count; i++)
            {
                int count = Convert.ToInt32(dgvBillInfo.Rows[i].Cells["count"].Value);
                int price = Convert.ToInt32(dgvBillInfo.Rows[i].Cells["price"].Value);
                dgvBillInfo.Rows[i].Cells["Total"].Value = count * price;
            }
        }
        public int TongTien(string idbill)
        {
            return Bill_BLL.Instance.getTotal(idbill);
        }

        private void fBill_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvBillInfo.Rows.Count; i++)
            {
                int count = Convert.ToInt32(dgvBillInfo.Rows[i].Cells["count"].Value);
                int price = Convert.ToInt32(dgvBillInfo.Rows[i].Cells["price"].Value);
                dgvBillInfo.Rows[i].Cells["Total"].Value = count * price;
            }
        }
    }
}
