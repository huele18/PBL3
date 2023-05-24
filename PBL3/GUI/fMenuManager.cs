using PBL3.BLL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI
{
    public partial class fMenuManager : Form
    {
        public fMenuManager()
        {
            InitializeComponent();
            setDGVFood();
            setCBBCategory();
        }
        public void setCBBCategory()
        {
            cbbCategory.Items.AddRange(Drink_BLL.Instance.getCategoryCBB().ToArray());
        }
        public void setDGVFood()
        {
            dgvFood.DataSource = Drink_BLL.Instance.showDGV().DataSource;
            dgvFood.Columns["imageFood"].Visible = false;
        }
        public bool checkData()
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Chưa nhập vào ID món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Chưa nhập vào tên món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbbCategory.Text))
            {
                MessageBox.Show("Chưa chọn phân loại món!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbCategory.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Chưa nhập vào giá tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }
            return true;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            
            if (checkData()) {
                Food f = new Food
                {
                    idFood = Convert.ToInt32(txtID.Text),
                    NameFood = txtName.Text,
                    idCategory = ((CBBItem)cbbCategory.SelectedItem).Value,
                    price = Convert.ToDouble(txtPrice.Text)
                };
                if (pictureBox1.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imageData = ms.ToArray();
                    f.imageFood = imageData;
                }
                Drink_BLL.Instance.addDrink(f);
            }
            setDGVFood();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (checkData()) {
                Food f = new Food();
                f.idFood = Convert.ToInt32(txtID.Text);
                f.NameFood = txtName.Text;
                f.idCategory = ((CBBItem)cbbCategory.SelectedItem).Value;
                f.price = Convert.ToDouble(txtPrice.Text);

                if (pictureBox1.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imageData = ms.ToArray();
                    f.imageFood = imageData;
                }

                Drink_BLL.Instance.editDrink(f);
            }
            btAdd.Enabled = true;
            txtID.ReadOnly = false;
            txtID.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            cbbCategory.Text = "";
            pictureBox1.Image = null;
            setDGVFood();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvFood.SelectedRows.Count > 0)
            {
                int idfood;
                foreach (DataGridViewRow i in dgvFood.SelectedRows)
                {
                    idfood = Convert.ToInt32(i.Cells[0].Value.ToString());
                    Drink_BLL.Instance.delDrink(idfood);
                }
            }
            else
                MessageBox.Show("Chưa chọn cột muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            setDGVFood();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                dgvFood.DataSource = Drink_BLL.Instance.searchDrink(txtSearch.Text).DataSource;
            }
            else
            {
                setDGVFood();
            }
        }

        private void dgvFood_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                btAdd.Enabled = false;
                txtID.ReadOnly = true;
                int index = e.RowIndex;
                txtID.Text = dgvFood.Rows[index].Cells[0].Value.ToString();
                cbbCategory.Text = dgvFood.Rows[index].Cells[1].Value.ToString();
                txtName.Text = dgvFood.Rows[index].Cells[2].Value.ToString();
                txtPrice.Text = dgvFood.Rows[index].Cells[3].Value.ToString();

                if (dgvFood.Rows[index].Cells[4].Value != null && dgvFood.Rows[index].Cells[4].Value != DBNull.Value)
                {
                    byte[] imageData = (byte[])dgvFood.Rows[index].Cells[4].Value;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);
                        pictureBox1.Image = image;
                    }
                }
                else
                {
                    pictureBox1.Image = null; // Gán giá trị null cho PictureBox.Image
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void btAddCategory_Click(object sender, EventArgs e)
        {
            fAddCategoryFood acf = new fAddCategoryFood();
            acf.ShowDialog();
            cbbCategory.Items.Clear();
            setCBBCategory();
        }
    }
}
