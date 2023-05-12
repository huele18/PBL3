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
    public partial class DetailBill : Form
    {
        private string idbill;
        public DetailBill(string idbill)
        {
            InitializeComponent();
            this.idbill = idbill;
        }

        private void DetailBill_Load(object sender, EventArgs e)
        {
            dgvdetailbill.DataSource = Bill_BLL.Instance.getDetailBill(idbill).DataSource;
            for(int i = 0; i < dgvdetailbill.Rows.Count; i++)
            {
                int count = Convert.ToInt32(dgvdetailbill.Rows[i].Cells["billquantity"].Value);
                int price = Convert.ToInt32(dgvdetailbill.Rows[i].Cells["price"].Value);
                dgvdetailbill.Rows[i].Cells["totalprice"].Value = count * price;
            }
        }
    }
}
