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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != 
            DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            //if (txtName.Text == name && txtPass.Text == pass)
            //{
                fManager f = new fManager();
                this.Hide();
                f.ShowDialog();
                this.Show();
            //    txtPass.Text = null;
            //}
            //else
            //{
            //    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!", "Thông báo", MessageBoxButtons.OK);
            //    txtName.Text = null; 
            //    txtPass.Text = null;
            //}
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
