using PBL3.BLL;
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
    public partial class fStaffManager : Form
    {
        public static string pw = "1234";
        public fStaffManager()
        {
            InitializeComponent();
            setFLP();
        }
        private byte[] ImageToByteArray(PictureBox picture)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox1.Image.Save(memoryStream, pictureBox1.Image.RawFormat);
            return memoryStream.ToArray();
        }
        public void setFLP()
        {
            flp.Controls.Clear();
            List<Account> accounts = Account_BLL.Instance.GetAccounts();
            foreach (ucAccountInfo p in Account_BLL.Instance.GetUcAccountInfos(accounts))
            {
                p.Click += uc_Click;
                flp.Controls.Add(p);
            }
        }

        private void uc_Click(object sender, EventArgs e)
        {
            ucAccountInfo uca = (ucAccountInfo)sender;
            tbEmployeeId.ReadOnly = true;
            btAddEmployee.Enabled = false;
            int idAcc = Convert.ToInt32(uca.Tag);
            Account acc = Account_BLL.Instance.getAccountByID(idAcc);
            tbEmployeeId.Text = acc.idAccount.ToString();
            tbEmployeeName.Text = acc.DisplayName;
            if (acc.GT == true)
                rbMale.Checked = true;
            else if (acc.GT == false)
                rbFemale.Checked = true;
            tbPhoneNumber.Text = acc.SDT;
            tbAddress.Text = acc.address;
            tbEmail.Text = acc.email;
            tbUsername.Text = acc.UserName;
            tbAccessCode.Text = acc.Type.ToString();
            if (acc.Anh != null)
            {
                byte[] imageData = (byte[])acc.Anh;
                using (MemoryStream ms1 = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms1);
                    pictureBox1.Image = image;
                }
            }
            else
            {
                pictureBox1.Image = null; // Gán giá trị null cho PictureBox.Image
            }
        }
        public bool checkDataEmployee()
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                MessageBox.Show("Chưa nhập vào Username", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUsername.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbEmployeeName.Text))
            {
                MessageBox.Show("Chưa nhập vào teen nhaan vieen", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbEmployeeName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbEmployeeId.Text))
            {
                MessageBox.Show("Chưa nhập vào teen nhaan vieen", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbEmployeeId.Focus();
                return false;
            }
            return true;
        }
        private void btRReset_Click(object sender, EventArgs e)
        {
            if (tbEmployeeId.ReadOnly == true)
            {
                //foreach (DataGridViewRow i in dgvEmployee.SelectedRows)
                //{
                    int idaccount = Convert.ToInt32(tbEmployeeId.Text);
                    Account_BLL.Instance.resetPass(idaccount, pw);
                    MessageBox.Show("Đã reset password thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setFLP();
                //}
            }
            else
                MessageBox.Show("Chưa chọn nhân viên muốn reset password", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                Account nv = new Account();

                nv.idAccount = Convert.ToInt32(tbEmployeeId.Text);
                nv.DisplayName = tbEmployeeName.Text;
                nv.SDT = tbPhoneNumber.Text;
                if (rbMale.Checked == true)
                    nv.GT = true;
                else if (rbFemale.Checked == true)
                    nv.GT = false;
                else
                    nv.GT = null;
                nv.address = tbAddress.Text;
                nv.email = tbEmail.Text;
                nv.UserName = tbUsername.Text;
                nv.Password = pw;
                nv.Type = Convert.ToInt32(tbAccessCode.Text);
                nv.Anh = ImageToByteArray(pictureBox1);
                int add = Account_BLL.Instance.addNV(nv);
                switch (add)
                {
                    case 0:
                        setFLP();
                        break;
                    case 1:
                        tbUsername.Focus();
                        break;
                    case 2:
                        break;
                    case 3:
                        tbEmployeeId.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập chưa đủ thông tin hoặc thông tin sai định dạng", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btUpdateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                int idAccount = Convert.ToInt32(tbEmployeeId.Text);
                Account nv = Account_BLL.Instance.GetAccountByid(idAccount);

                nv.DisplayName = tbEmployeeName.Text;
                if (rbMale.Checked == true)
                    nv.GT = true;
                else if (rbFemale.Checked == true)
                    nv.GT = false;
                else
                    nv.GT = null;
                nv.SDT = tbPhoneNumber.Text;
                nv.email = tbEmail.Text;
                nv.address = tbAddress.Text;
                nv.UserName = tbUsername.Text;
                nv.Anh = ImageToByteArray(pictureBox1);
                int Type = Convert.ToInt32(tbAccessCode.Text);
                int update = Account_BLL.Instance.updateAccount(nv);
                switch (update)
                {
                    case 0:
                        tbEmployeeId.ReadOnly = false;
                        tbEmployeeId.Text = "";
                        tbEmployeeName.Text = "";
                        rbMale.Checked = false;
                        rbFemale.Checked = false;
                        tbPhoneNumber.Text = "";
                        tbAddress.Text = "";
                        tbEmail.Text = "";
                        tbUsername.Text = "";
                        tbAccessCode.Text = "";
                        pictureBox1.Image = null;
                        setFLP();
                        break;
                    case 1:
                        tbUsername.Focus();
                        break;
                    case 2:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập chưa đủ thông tin hoặc thông tin sai định dạng", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (tbEmployeeId.ReadOnly == true)
            {
                int idstaff;
                //foreach (DataGridViewRow i in dgvEmployee.SelectedRows)
                //{
                    idstaff = Convert.ToInt32(tbEmployeeId.Text);
                    Account_BLL.Instance.deleteNV(idstaff);
                    MessageBox.Show("Đã xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                setFLP();
            }
            else
            {
                MessageBox.Show("Chưa chọn nhân viên muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void browse_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Title = "Please choose a picture";
            //ofd.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            //ofd.Multiselect = false;
            //if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    this.pictureBox1.ImageLocation = ofd.FileName;

            //}
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn tệp tin ảnh đã chọn
                string imagePath = ofd.FileName;

                // Cắt ảnh thành hình vuông
                Image squareImage = CropToSquare(Image.FromFile(imagePath));

                // Hiển thị ảnh cắt được trong PictureBox
                pictureBox1.Image = squareImage;
                //pictureBox1.Image = new Bitmap(ofd.FileName);
                //MemoryStream ms = new MemoryStream();
                //pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            }
            else pictureBox1.Image = null;
        }
        private Image CropToSquare(Image image)
        {
            int size = Math.Min(image.Width, image.Height);
            int x = (image.Width - size) / 2;
            int y = (image.Height - size) / 2;

            Bitmap squareImage = new Bitmap(size, size);
            using (Graphics graphics = Graphics.FromImage(squareImage))
            {
                graphics.DrawImage(image, new Rectangle(0, 0, size, size),
                    new Rectangle(x, y, size, size), GraphicsUnit.Pixel);
            }

            return squareImage;
        }

        private void tbSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            flp.Controls.Clear();
            if (!string.IsNullOrEmpty(tbSearchEmployee.Text))
            {
                List<Account> acc = Account_BLL.Instance.searchAccount(tbSearchEmployee.Text);
                foreach (ucAccountInfo p in Account_BLL.Instance.GetUcAccountInfos(acc))
                {
                    p.Click += uc_Click;
                    flp.Controls.Add(p);
                }
            }
            else
                setFLP();
        }
    }
}
