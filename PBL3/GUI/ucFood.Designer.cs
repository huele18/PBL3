namespace PBL3.GUI
{
    partial class ucFood
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
            this.btSelect = new System.Windows.Forms.Button();
            this.lbNB = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNameFood = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btSelect
            // 
            this.btSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btSelect.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btSelect.Location = new System.Drawing.Point(0, 344);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(300, 35);
            this.btSelect.TabIndex = 0;
            this.btSelect.Text = "Chọn";
            this.btSelect.UseVisualStyleBackColor = false;
            // 
            // lbNB
            // 
            this.lbNB.AutoSize = true;
            this.lbNB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbNB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNB.Location = new System.Drawing.Point(0, 322);
            this.lbNB.Name = "lbNB";
            this.lbNB.Size = new System.Drawing.Size(93, 22);
            this.lbNB.TabIndex = 1;
            this.lbNB.Text = "Số lượng: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.numericUpDown1.Location = new System.Drawing.Point(172, 313);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(128, 30);
            this.numericUpDown1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbNameFood
            // 
            this.lbNameFood.AutoSize = true;
            this.lbNameFood.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameFood.Location = new System.Drawing.Point(3, 283);
            this.lbNameFood.Name = "lbNameFood";
            this.lbNameFood.Size = new System.Drawing.Size(136, 27);
            this.lbNameFood.TabIndex = 4;
            this.lbNameFood.Text = "lbNameFood";
            this.lbNameFood.Click += new System.EventHandler(this.lbNameFood_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(167, 283);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(80, 27);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "lbPrice";
            this.lbPrice.Click += new System.EventHandler(this.lbNameFood_Click);
            // 
            // ucFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbNameFood);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbNB);
            this.Controls.Add(this.btSelect);
            this.Name = "ucFood";
            this.Size = new System.Drawing.Size(300, 379);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Label lbNB;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lbNameFood;
        public System.Windows.Forms.Label lbPrice;
    }
}
