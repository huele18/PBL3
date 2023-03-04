using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3._1
{
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();
        }
        private void fManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTableManager tm = new fTableManager();
            this.Hide();
            tm.ShowDialog();
            this.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fEmployeeManager em = new fEmployeeManager();
            this.Hide();
            em.ShowDialog();
            this.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMenuManager mm = new fMenuManager();
            this.Hide();
            mm.ShowDialog();
            this.Show();
        }

        private void hóaĐơnBánRaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fInvoiceManager im = new fInvoiceManager();
            this.Hide();
            im.ShowDialog();
            this.Show();
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStatistics s = new fStatistics();
            s.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            fBill b = new fBill();
            b.ShowDialog();
        }
    }
}
