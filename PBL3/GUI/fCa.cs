using Guna.UI2.WinForms;
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
    public partial class fCa : Form
    {
        public fCa()
        {
            InitializeComponent();
            getFLP();
        }
        public void getFLP()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach(ucShift uc in Shift_BLL.Instance.GetUcShifts())
            {
                uc.btView.Click += view_Click;
                uc.btAdd.Click += add_Click;
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string thu = btn.Tag.ToString();
            fViewShift fv = new fViewShift(thu);
            fv.ShowDialog();
            getFLP();
        }
        private void add_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string thu = btn.Tag.ToString();
            fAddShift fv = new fAddShift(thu);
            fv.ShowDialog();
            getFLP();
        }

        private void fCa_Load(object sender, EventArgs e)
        {
            getFLP();
        }
    }
}
