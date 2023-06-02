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
    public partial class fShift : Form
    {
        public fShift()
        {
            InitializeComponent();
            setDGV();
        }
        public void setDGV()
        {
            dgvShift.DataSource = Shift_BLL.Instance.showDGV();

        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtidAccount.Text))
            {
                MessageBox.Show("Chưa nhập vào ID nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtidAccount.Focus();
            }
            else if(string.IsNullOrEmpty(txtDisplayName.Text)) 
            {
                MessageBox.Show("Chưa nhập vào tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDisplayName.Focus();
            }
            else
            {
                int idShift;
                if (!int.TryParse(txtidShift.Text, out idShift))
                {
                    MessageBox.Show("ID Shift không hợp lệ. Vui lòng nhập một số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idAccount;
                if (!int.TryParse(txtidAccount.Text, out idAccount))
                {
                    MessageBox.Show("ID Account không hợp lệ. Vui lòng nhập một số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime timeStart;
                if (!DateTime.TryParse(start.Text, out timeStart))
                {
                    MessageBox.Show("Giá trị Time Start không hợp lệ. Vui lòng nhập một ngày/giờ đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime timeEnd;
                if (!DateTime.TryParse(end.Text, out timeEnd))
                {
                    MessageBox.Show("Giá trị Time End không hợp lệ. Vui lòng nhập một ngày/giờ đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Calam calam = new Calam
                {
                    idShift = Convert.ToInt32(txtidShift.Text),
                    idAccount = Convert.ToInt32(txtidAccount.Text),
                    DisplayName = txtDisplayName.Text,
                    TimeStart = start.Value,
                    TimeEnd = end.Value,
                };
                Shift_BLL.Instance.addCalam(calam);
            }
            setDGV();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            Calam calam = new Calam
            {
                idShift= Convert.ToInt32(txtidShift.Text),
                idAccount = Convert.ToInt32(txtidAccount.Text),
                DisplayName = txtDisplayName.Text,
                TimeStart = (DateTime)start.Value,
                TimeEnd = (DateTime)end.Value,
            };
            Shift_BLL.Instance.editShift(calam);
            txtidShift.Text = "";
            txtidAccount.Text = "";
            txtDisplayName.Text = calam.DisplayName;
            setDGV();
        }

        private void BtDel_Click(object sender, EventArgs e)
        {

            if (dgvShift.SelectedRows.Count > 0)
            {
                int idShift;
                foreach (DataGridViewRow i in dgvShift.SelectedRows)
                {
                    idShift = Convert.ToInt32(i.Cells[0].Value.ToString());
                    Shift_BLL.Instance.delShift(idShift);
                }
            }
            else
                MessageBox.Show("Chưa chọn cột muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            setDGV();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dgvShift.DataSource = Shift_BLL.Instance.searchCalam(txtSearch.Text).DataSource;
            if(string.IsNullOrEmpty(txtSearch.Text))
            {
                setDGV();
            }
        }

        private void dgvShift_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
               // btAdd.Visible = false;
                //txtidShift.ReadOnly = true;
                int index = e.RowIndex;
                txtidShift.Text = dgvShift.Rows[index].Cells[0].Value.ToString();
                txtidAccount.Text = dgvShift.Rows[index].Cells[1].Value.ToString();
                txtDisplayName.Text = dgvShift.Rows[index].Cells[2].Value.ToString();
                start.Text = dgvShift.Rows[index].Cells[3].Value.ToString();
                end.Text = dgvShift.Rows[index].Cells[4].Value.ToString();   
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        /*private void fShift_Load(object sender, EventArgs e)
        {
            setDGV();
        }*/
    }
}
