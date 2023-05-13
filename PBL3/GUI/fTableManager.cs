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
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            setDGVTable();
        }
        public void setDGVTable()
        {
            dgvTable.DataSource = Table_BLL.Instance.showDGV();
            dgvTable.Columns["Bills"].Visible = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Chưa nhập vào ID bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Chưa nhập vào tên bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else
            {
                string tt;
                if (rbTrong.Checked == true)
                {
                    tt = "Trống";
                }
                else
                {
                    tt = "Có Người";
                }
                TableFood tf = new TableFood
                {
                    idTableFood = Convert.ToInt32(txtID.Text),
                    name = txtName.Text,
                    status = tt
                };
                Table_BLL.Instance.addTable(tf);
            }
            setDGVTable();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            bool oldName = true;
            string tt;
            if (rbTrong.Checked == true)
            {
                tt = "Trống";
            }
            else
            {
                tt = "Có Người";
            }
            string name = Table_BLL.Instance.getTableFoodById(Convert.ToInt32(txtID.Text)).name;
            TableFood tf = new TableFood
            {
                idTableFood = Convert.ToInt32(txtID.Text),
                name = txtName.Text,
                status = tt
            };
            if (tf.name != name) 
            {
                oldName = false;
            }
            Table_BLL.Instance.editTable(tf, oldName);
            btAdd.Enabled = true;
            txtID.ReadOnly = false;
            txtID.Text = "";
            txtName.Text = "";
            rbCoNguoi.Checked = false;
            rbTrong.Checked = true;
            setDGVTable();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvTable.SelectedRows.Count > 0)
            {
                int idtable;
                foreach (DataGridViewRow i in dgvTable.SelectedRows)
                {
                    idtable = Convert.ToInt32(i.Cells[0].Value.ToString());
                    Table_BLL.Instance.delTable(idtable);
                }
                MessageBox.Show("Đã xóa thành công bàn ra khỏi danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Chưa chọn cột muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            setDGVTable();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dgvTable.DataSource = Table_BLL.Instance.searchTable(txtSearch.Text).DataSource;
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                setDGVTable();
            }
        }

        private void dgvTable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                btAdd.Enabled = false;
                txtID.ReadOnly = true;
                int index = e.RowIndex;
                txtID.Text = dgvTable.Rows[index].Cells[0].Value.ToString();
                txtName.Text = dgvTable.Rows[index].Cells[1].Value.ToString();
                string tt;
                tt = dgvTable.Rows[index].Cells[2].Value.ToString();
                if (tt == "Trống")
                    rbTrong.Checked = true;
                else
                    rbCoNguoi.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
