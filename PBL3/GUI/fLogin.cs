﻿using PBL3.BLL;
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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //fMain m = new fMain();
            //this.Hide();
            //m.ShowDialog();
            //this.Show();

            //int login = Account_BLL.Instance.checkLogin(txtName.Text, txtPass.Text);
            int login = Account_BLL.Instance.checkLogin(txtName.Text, Account_BLL.Instance.GetMD5(txtPass.Text));
            if (login == 1)
            {
                fMainAdmin f = new fMainAdmin(txtName.Text);
                this.Hide();
                f.ShowDialog();
                this.Show();
                txtPass.Text = "";
            }
            else if (login == 0)
            {
                fMainStaff f = new fMainStaff(txtName.Text);
                this.Hide();
                f.ShowDialog();
                this.Show();
                txtPass.Text = "";
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!", "Thông báo", MessageBoxButtons.OK);
                txtName.Text = "";
                txtPass.Text = "";
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo) !=
            DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
