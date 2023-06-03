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
            setFLP();
        }
        public void setFLP()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Button i in Table_BLL.Instance.GetTables("All"))
            {
                i.Margin = new Padding(5, 5, 5, 5);
                i.Click += BtTable_Click;
                flowLayoutPanel1.Controls.Add(i);
            }
        }
        private void BtTable_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int idtable = Convert.ToInt32(btn.Tag);
            txtID.ReadOnly = true;
            btAdd.Enabled = false;
            txtID.Text = idtable.ToString();
            txtName.Text = btn.Text;
            if (btn.BackColor == Color.FromArgb(176, 125, 55))
                rbCoNguoi.Checked = true;
            else if (btn.BackColor == Color.FromArgb(228, 195, 147))
                rbTrong.Checked = true;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtID.ReadOnly == false)
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Chưa nhập vào ID bàn", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Chưa nhập vào tên bàn", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                }
                else
                {
                    string tt;
                    if (rbCoNguoi.Checked == true)
                        tt = "Có Người";
                    else tt = "Trống";
                    TableFood tf = new TableFood
                    {
                        idTableFood = Convert.ToInt32(txtID.Text),
                        name = txtName.Text,
                        status = tt
                    };
                    Table_BLL.Instance.addTable(tf);
                }
                setFLP();
            }
            //setDGVTable();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (txtID.ReadOnly == true)
            {
                string tt;
                if (rbTrong.Checked == true)
                    tt = "Trống";
                else tt = "Có Người";
                TableFood tf = new TableFood
                {
                    idTableFood = Convert.ToInt32(txtID.Text),
                    name = txtName.Text,
                    status = tt
                };
                Table_BLL.Instance.editTable(tf);
                MessageBox.Show("Đã cập nhật thành công thông tin bàn", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                btAdd.Enabled = true;
                txtID.ReadOnly = false;
                txtID.Text = "";
                txtName.Text = "";
                rbCoNguoi.Checked = false;
                rbTrong.Checked = true;
                //setDGVTable();
                setFLP();
            }
            else
                MessageBox.Show("Chưa chọn bàn muốn sửa thông tin", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (txtID.ReadOnly == false)
                MessageBox.Show("Chưa chọn bàn muốn xóa", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int idtable = Convert.ToInt32(txtID.Text);
                Table_BLL.Instance.delTable(idtable);
                MessageBox.Show("Đã xóa thành công bàn ra khỏi danh sách", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rbUnoccupied_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Button i in Table_BLL.Instance.GetTables("unoccupied"))
            {
                i.Margin = new Padding(5, 5, 5, 5);
                i.Click += BtTable_Click;
                flowLayoutPanel1.Controls.Add(i);
            }

        }

        private void rbOccupied_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Button i in Table_BLL.Instance.GetTables("occupied"))
            {
                i.Margin = new Padding(5, 5, 5, 5);
                i.Click += BtTable_Click;
                flowLayoutPanel1.Controls.Add(i);
            }

        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            setFLP();
        }
    }
}
