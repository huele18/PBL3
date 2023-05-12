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
            SetdgvEmployee();
        }
        private byte[] ImageToByteArray(PictureBox picture)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox1.Image.Save(memoryStream, pictureBox1.Image.RawFormat);
            return memoryStream.ToArray();
        }
        public void SetdgvEmployee()
        {
            dgvEmployee.DataSource = Account_BLL.Instance.GetAccounts();
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
            if (string.IsNullOrWhiteSpace(tbShift.Text))
            {
                MessageBox.Show("Chưa nhập vào teen nhaan vieen", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbShift.Focus();
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

        private void btSearchEmployee_Click(object sender, EventArgs e)
        {
            if (tbSearchEmployee.Text == "")
            {
                SetdgvEmployee();
            }
            else
            {
                dgvEmployee.DataSource = Account_BLL.Instance.searchAccount(tbSearchEmployee.Text);
            }
        }

        private void btRReset_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dgvEmployee.SelectedRows)
                {
                    int idaccount = Convert.ToInt32(i.Cells[0].Value.ToString());
                    Account_BLL.Instance.resetPass(idaccount, pw);
                    MessageBox.Show("Đã reset password thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetdgvEmployee();
                }
            }
            else
                MessageBox.Show("Chưa chọn cột muốn reset password", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                nv.Calam = tbShift.Text;
                nv.Type = Convert.ToInt32(tbAccessCode.Text);
                nv.Anh = ImageToByteArray(pictureBox1);
                int add = Account_BLL.Instance.addNV(nv);
                switch (add)
                {
                    case 0:
                        SetdgvEmployee();
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
                nv.Calam = tbShift.Text;
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
                        tbShift.Text = "";
                        tbAccessCode.Text = "";
                        pictureBox1.Image = null;
                        SetdgvEmployee();
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
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                int idstaff;
                foreach (DataGridViewRow i in dgvEmployee.SelectedRows)
                {
                    idstaff = Convert.ToInt32(i.Cells[0].Value.ToString());
                    Account_BLL.Instance.deleteNV(idstaff);
                    MessageBox.Show("Đã xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                SetdgvEmployee();
            }
            else
            {
                MessageBox.Show("Chưa chọn cột muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvEmployee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbEmployeeId.ReadOnly = true;
            int index = e.RowIndex;
            tbEmployeeId.Text = dgvEmployee.Rows[index].Cells[0].Value.ToString();
            tbEmployeeName.Text = dgvEmployee.Rows[index].Cells[1].Value.ToString();
            if (dgvEmployee.Rows[index].Cells[2].Value != null && Convert.ToBoolean(dgvEmployee.Rows[index].Cells[2].Value.ToString()) == true)
                rbMale.Checked = true;
            else if (dgvEmployee.Rows[index].Cells[2].Value != null && Convert.ToBoolean(dgvEmployee.Rows[index].Cells[2].Value.ToString()) == false)
                rbFemale.Checked = true;
            else if (dgvEmployee.Rows[index].Cells[2].Value == null)
            {
                rbMale.Checked = false;
                rbFemale.Checked = false;
            }
            tbPhoneNumber.Text = dgvEmployee.Rows[index].Cells[3].Value.ToString();
            tbAddress.Text = dgvEmployee.Rows[index].Cells[4].Value.ToString();
            tbEmail.Text = dgvEmployee.Rows[index].Cells[5].Value.ToString();
            tbUsername.Text = dgvEmployee.Rows[index].Cells[6].Value.ToString();
            tbShift.Text = dgvEmployee.Rows[index].Cells["Calam"].Value.ToString();
            tbAccessCode.Text = dgvEmployee.Rows[index].Cells["Type"].Value.ToString();
            if (dgvEmployee.Rows[index].Cells["anh"].Value != null && dgvEmployee.Rows[index].Cells["anh"].Value != DBNull.Value)
            {
                byte[] imageData = (byte[])dgvEmployee.Rows[index].Cells["anh"].Value;
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

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please choose a picture";
            ofd.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pictureBox1.ImageLocation = ofd.FileName;

            }
        }
    }
}
