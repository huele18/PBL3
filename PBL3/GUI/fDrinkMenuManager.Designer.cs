namespace PBL3.GUI
{
    partial class fDrinkMenuManager
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btBSeller = new Guna.UI2.WinForms.Guna2Button();
            this.btAddDrink = new Guna.UI2.WinForms.Guna2Button();
            this.btAll = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btEditCategory = new Guna.UI2.WinForms.Guna2Button();
            this.flpCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.flpDrink = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loại đồ uống:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btBSeller);
            this.panel2.Controls.Add(this.btAddDrink);
            this.panel2.Controls.Add(this.btAll);
            this.panel2.Controls.Add(this.guna2Separator2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(854, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 632);
            this.panel2.TabIndex = 1;
            // 
            // btBSeller
            // 
            this.btBSeller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.btBSeller.BorderRadius = 25;
            this.btBSeller.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btBSeller.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btBSeller.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btBSeller.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btBSeller.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btBSeller.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btBSeller.ForeColor = System.Drawing.Color.Black;
            this.btBSeller.Location = new System.Drawing.Point(-47, 322);
            this.btBSeller.Name = "btBSeller";
            this.btBSeller.Size = new System.Drawing.Size(199, 69);
            this.btBSeller.TabIndex = 10;
            this.btBSeller.Text = "BestSeller";
            this.btBSeller.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btBSeller.Click += new System.EventHandler(this.btBSeller_Click);
            // 
            // btAddDrink
            // 
            this.btAddDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.btAddDrink.BorderRadius = 25;
            this.btAddDrink.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAddDrink.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAddDrink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAddDrink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAddDrink.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btAddDrink.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btAddDrink.ForeColor = System.Drawing.Color.Black;
            this.btAddDrink.Image = global::PBL3.Properties.Resources.add;
            this.btAddDrink.ImageSize = new System.Drawing.Size(30, 30);
            this.btAddDrink.Location = new System.Drawing.Point(-47, 408);
            this.btAddDrink.Name = "btAddDrink";
            this.btAddDrink.Size = new System.Drawing.Size(199, 69);
            this.btAddDrink.TabIndex = 8;
            this.btAddDrink.Text = "Thêm";
            this.btAddDrink.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btAddDrink.Click += new System.EventHandler(this.btAddDrink_Click);
            // 
            // btAll
            // 
            this.btAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.btAll.BorderRadius = 25;
            this.btAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btAll.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btAll.ForeColor = System.Drawing.Color.Black;
            this.btAll.Location = new System.Drawing.Point(-47, 236);
            this.btAll.Name = "btAll";
            this.btAll.Size = new System.Drawing.Size(199, 69);
            this.btAll.TabIndex = 9;
            this.btAll.Text = "Tất cả   ";
            this.btAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btAll.Click += new System.EventHandler(this.btAll_Click);
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(151)))), ((int)(((byte)(95)))));
            this.guna2Separator2.FillStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Separator2.FillThickness = 4;
            this.guna2Separator2.Location = new System.Drawing.Point(0, 210);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(190, 10);
            this.guna2Separator2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btEditCategory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 210);
            this.panel3.TabIndex = 0;
            // 
            // btEditCategory
            // 
            this.btEditCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.btEditCategory.BorderRadius = 25;
            this.btEditCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btEditCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btEditCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btEditCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btEditCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btEditCategory.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btEditCategory.ForeColor = System.Drawing.Color.Black;
            this.btEditCategory.Image = global::PBL3.Properties.Resources.edit;
            this.btEditCategory.ImageSize = new System.Drawing.Size(30, 30);
            this.btEditCategory.Location = new System.Drawing.Point(-47, 17);
            this.btEditCategory.Name = "btEditCategory";
            this.btEditCategory.Size = new System.Drawing.Size(199, 69);
            this.btEditCategory.TabIndex = 7;
            this.btEditCategory.Text = "Sửa  ";
            this.btEditCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btEditCategory.Click += new System.EventHandler(this.btEditCategory_Click);
            // 
            // flpCategory
            // 
            this.flpCategory.AutoScroll = true;
            this.flpCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCategory.Location = new System.Drawing.Point(0, 44);
            this.flpCategory.Name = "flpCategory";
            this.flpCategory.Size = new System.Drawing.Size(854, 210);
            this.flpCategory.TabIndex = 2;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(151)))), ((int)(((byte)(95)))));
            this.guna2Separator1.FillStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Separator1.FillThickness = 4;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 254);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(854, 10);
            this.guna2Separator1.TabIndex = 3;
            // 
            // flpDrink
            // 
            this.flpDrink.AutoScroll = true;
            this.flpDrink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDrink.Location = new System.Drawing.Point(0, 264);
            this.flpDrink.Name = "flpDrink";
            this.flpDrink.Size = new System.Drawing.Size(854, 412);
            this.flpDrink.TabIndex = 4;
            // 
            // fDrinkMenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1044, 676);
            this.Controls.Add(this.flpDrink);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.flpCategory);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fDrinkMenuManager";
            this.Text = "Quản lý Đồ uống";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flpCategory;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btAll;
        private Guna.UI2.WinForms.Guna2Button btEditCategory;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.FlowLayoutPanel flpDrink;
        private Guna.UI2.WinForms.Guna2Button btAddDrink;
        private Guna.UI2.WinForms.Guna2Button btBSeller;
    }
}