using PBL3.BLL;
using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI
{
    public partial class fAccountManager : Form
    {
        public fAccountManager(int idaccount)
        {
            InitializeComponent();
            GUI(Account_BLL.Instance.getAccountByID(idaccount));
        }
        public void GUI(Account acc)
        {
            txtIDAccount.Text = acc.idAccount.ToString();
            txtDisplayName.Text = acc.DisplayName;
            if (acc.GT == true)
                rbMale.Checked = true;
            else if (acc.GT == false)
                rbFemale.Checked = true;
            else
            {
                rbMale.Checked = false;
                rbMale.Checked = false;
            }
            txtSDT.Text = acc.SDT;
            txtAddress.Text = acc.address;
            txtEmail.Text = acc.email;
            txtUserName.Text = acc.UserName;
            txtPass.Text = acc.Password;
            txtCalam.Text = acc.Calam;
            txtType.Text = acc.Type.ToString();
            if (acc.Type == 1)
            {
                txtCalam.ReadOnly = false;
            }
            if (acc.Anh != null)
            {
                byte[] imageData = (byte[])acc.Anh;
                MemoryStream ms = new MemoryStream(imageData);
                Image image = Image.FromStream(ms);
                pictureBox1.Image = image;
            }
        }


        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(txtDisplayName.Text))
            {
                MessageBox.Show("Không được để trống họ và tên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDisplayName.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Không được để trống họ và tên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Không được để trống họ và tên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Không được để trống họ và tên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Không được để trống họ và tên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            if (!Account_BLL.Instance.checkUsername(Convert.ToInt32(txtIDAccount.Text), txtUserName.Text))
            {
                MessageBox.Show("Username đã tồn tại. Vui lòng nhập lại.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return false;
            }
                return true;
        }

        private void btUpdateInf_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                try
                {
                    Account acc = new Account();
                    acc.idAccount = Convert.ToInt32(txtIDAccount.Text);
                    acc.DisplayName = txtDisplayName.Text;
                    acc.SDT = txtSDT.Text;
                    if (rbMale.Checked == true)
                    {
                        acc.GT = true;
                    }
                    else if (rbFemale.Checked == true)
                    {
                        acc.GT = false;
                    }
                    else
                    {
                        acc.GT = null;
                    }
                    acc.address = txtAddress.Text;
                    acc.email = txtEmail.Text;
                    acc.UserName = txtUserName.Text;
                    acc.Password = txtPass.Text;
                    acc.Calam = txtCalam.Text;
                    acc.Type = Convert.ToInt32(txtType.Text);
                    if (pictureBox1.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        byte[] imageData = ms.ToArray();
                        acc.Anh = imageData;
                    }
                    else
                        acc.Anh = null;

                    Account_BLL.Instance.editAccount(acc);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }

        private void btsetPass_Click(object sender, EventArgs e)
        {
            if(txtPass.Text != txtOldPass.Text)
            {
                MessageBox.Show("Mật khẩu cũ không đúng. Vui lòng nhập lại.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOldPass.Focus();
            }
            else
            {
                if (txtNewPass2.Text != txtNewPass1.Text)
                {
                    MessageBox.Show("Nhập lại mật khẩu không trùng khớp. Vui lòng nhập lại.", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Account_BLL.Instance.changePassword(Convert.ToInt32(txtIDAccount.Text), txtNewPass1.Text);
                    txtPass.Text = txtNewPass1.Text;
                    txtOldPass.Text = "";
                    txtNewPass1.Text = "";
                    txtNewPass2.Text = "";
                }
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //PictureBox pb = new PictureBox();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            }
            else pictureBox1.Image = null;
        }
    }
}
