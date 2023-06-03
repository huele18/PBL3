namespace PBL3.GUI
{
    partial class ucDrink
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lbNameFood = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.imageDrink = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbID = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.imageDrink)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.guna2Separator1.FillThickness = 5;
            this.guna2Separator1.Location = new System.Drawing.Point(271, 119);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(215, 10);
            this.guna2Separator1.TabIndex = 1;
            // 
            // lbNameFood
            // 
            this.lbNameFood.AutoSize = false;
            this.lbNameFood.BackColor = System.Drawing.Color.Transparent;
            this.lbNameFood.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbNameFood.ForeColor = System.Drawing.Color.Black;
            this.lbNameFood.Location = new System.Drawing.Point(271, 136);
            this.lbNameFood.Name = "lbNameFood";
            this.lbNameFood.Size = new System.Drawing.Size(215, 112);
            this.lbNameFood.TabIndex = 2;
            this.lbNameFood.Text = "lbname";
            // 
            // lbPrice
            // 
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.lbPrice.ForeColor = System.Drawing.Color.Sienna;
            this.lbPrice.Location = new System.Drawing.Point(271, 80);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(79, 33);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "lbprice";
            // 
            // imageDrink
            // 
            this.imageDrink.Dock = System.Windows.Forms.DockStyle.Left;
            this.imageDrink.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.imageDrink.ImageRotate = 0F;
            this.imageDrink.Location = new System.Drawing.Point(0, 0);
            this.imageDrink.Name = "imageDrink";
            this.imageDrink.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imageDrink.Size = new System.Drawing.Size(265, 250);
            this.imageDrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageDrink.TabIndex = 0;
            this.imageDrink.TabStop = false;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.Black;
            this.lbID.Location = new System.Drawing.Point(3, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(64, 25);
            this.lbID.TabIndex = 6;
            this.lbID.Text = "label1";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Sienna;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(427, 80);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(82, 33);
            this.guna2HtmlLabel1.TabIndex = 7;
            this.guna2HtmlLabel1.Text = "VNĐ";
            // 
            // ucDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(164)))), ((int)(((byte)(115)))));
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbNameFood);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.imageDrink);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ucDrink";
            this.Size = new System.Drawing.Size(500, 250);
            ((System.ComponentModel.ISupportInitialize)(this.imageDrink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2CirclePictureBox imageDrink;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Guna.UI2.WinForms.Guna2HtmlLabel lbNameFood;
        public Guna.UI2.WinForms.Guna2HtmlLabel lbPrice;
        public System.Windows.Forms.Label lbID;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
