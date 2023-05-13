using PBL3.BLL;
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
        private DataTable dttable = new DataTable();
        public fBill(string idbill, string table, string staffname, DataTable data)
        {
            InitializeComponent();
            lbIdBill.Text = idbill;
            lbStaff.Text = staffname;
            lbTable.Text = table;
            lbTime.Text = DateTime.Now.ToString();
            dttable = data;
            dgvBillInfo.DataSource = dttable;
            lbTong.Text = TongTien(idbill).ToString();
            //dgvBillInfo.DataSource = dgvBill.DataSource;
        }
        public int TongTien(string idbill)
        {
            return Bill_BLL.Instance.getTotal(idbill);
        }
    }
}
