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
        public void getTable()
        {
            foreach(Table i in Table_BLL.Instance.GetTables())
            {
                flowLayoutPanel1.Controls.Add(i);
            }
            
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            fMenu m = new fMenu();
            m.ShowDialog();
            this.Show();
        }
    }
}
