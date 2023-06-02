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
    public partial class fDetailDrink : Form
    {
        //private bool check;
        //private int id;
        public fDetailDrink()
        {
            InitializeComponent();
            getCBB();
            btEdit.Enabled = false;
            btDelete.Enabled = false;
        }
        public fDetailDrink(int idfood)
        {
            InitializeComponent();
            getCBB();
            GUI(idfood.ToString());
            txtID.ReadOnly = true;
            btAdd.Enabled = false;
        }
        public void getCBB()
        {
            cbbCategory.Items.AddRange(Drink_BLL.Instance.getCategoryCBB().ToArray());
        }
        private void GUI(string idfood)
        {
            Food f = Drink_BLL.Instance.getFoodById(idfood);
            txtID.Text = f.idFood.ToString();
            txtName.Text = f.NameFood;
            txtPrice.Text = f.price.ToString();
            cbbCategory.Text = Drink_BLL.Instance.GetFoodCategoryByID(f.idCategory.ToString()).Category;
            if (f.imageFood != null)
            {
                byte[] imageData = (byte[])f.imageFood;
                MemoryStream ms = new MemoryStream(imageData);
                Image image = Image.FromStream(ms);
                imageDrink.Image = image;
            }
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
            if (checkData())
            {
                Food f = new Food
                {
                    idFood = Convert.ToInt32(txtID.Text),
                    NameFood = txtName.Text,
                    idCategory = ((CBBItem)cbbCategory.SelectedItem).Value,
                    price = Convert.ToDouble(txtPrice.Text)
                };
                if (imageDrink.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    imageDrink.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imageData = ms.ToArray();
                    f.imageFood = imageData;
                }
                Drink_BLL.Instance.addDrink(f);
                this.Close();
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                Food f = new Food();
                f.idFood = Convert.ToInt32(txtID.Text);
                f.NameFood = txtName.Text;
                f.idCategory = ((CBBItem)cbbCategory.SelectedItem).Value;
                f.price = Convert.ToDouble(txtPrice.Text);

                if (imageDrink.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    imageDrink.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imageData = ms.ToArray();
                    f.imageFood = imageData;
                }
                else
                    f.imageFood = null;

                Drink_BLL.Instance.editDrink(f);
                this.Close();

            }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Drink_BLL.Instance.delDrink(Convert.ToInt32(txtID.Text));
            this.Close();
        }

        private void imageDrink_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //PictureBox pb = new PictureBox();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn tệp tin ảnh đã chọn
                string imagePath = ofd.FileName;

                // Cắt ảnh thành hình vuông
                Image squareImage = CropToSquare(Image.FromFile(imagePath));

                // Hiển thị ảnh cắt được trong PictureBox
                imageDrink.Image = squareImage;
                //imageDrink.Image = new Bitmap(ofd.FileName);
                //MemoryStream ms = new MemoryStream();
                //imageDrink.Image.Save(ms, imageDrink.Image.RawFormat);
            }
            //else imageDrink.Image = null;
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
    }
}
