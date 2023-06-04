namespace PBL3.GUI
{
    partial class ucShift
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbThu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btView = new Guna.UI2.WinForms.Guna2Button();
            this.lbToi = new System.Windows.Forms.ListBox();
            this.lbChieu = new System.Windows.Forms.ListBox();
            this.lbSang = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbThu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 42);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(699, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tối";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sáng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chiều";
            // 
            // lbThu
            // 
            this.lbThu.AutoSize = true;
            this.lbThu.Location = new System.Drawing.Point(14, 10);
            this.lbThu.Name = "lbThu";
            this.lbThu.Size = new System.Drawing.Size(69, 27);
            this.lbThu.TabIndex = 0;
            this.lbThu.Text = "Thứ 2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.btView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 91);
            this.panel2.TabIndex = 1;
            // 
            // btAdd
            // 
            this.btAdd.BorderRadius = 20;
            this.btAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btAdd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btAdd.ForeColor = System.Drawing.Color.Black;
            this.btAdd.Location = new System.Drawing.Point(460, 6);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(122, 51);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "Add";
            // 
            // btView
            // 
            this.btView.BorderRadius = 20;
            this.btView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btView.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btView.ForeColor = System.Drawing.Color.Black;
            this.btView.Location = new System.Drawing.Point(253, 6);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(122, 51);
            this.btView.TabIndex = 5;
            this.btView.Text = "View";
            // 
            // lbToi
            // 
            this.lbToi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbToi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbToi.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbToi.FormattingEnabled = true;
            this.lbToi.ItemHeight = 26;
            this.lbToi.Location = new System.Drawing.Point(606, 42);
            this.lbToi.Name = "lbToi";
            this.lbToi.Size = new System.Drawing.Size(238, 172);
            this.lbToi.TabIndex = 8;
            // 
            // lbChieu
            // 
            this.lbChieu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbChieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbChieu.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbChieu.FormattingEnabled = true;
            this.lbChieu.ItemHeight = 26;
            this.lbChieu.Location = new System.Drawing.Point(368, 42);
            this.lbChieu.Name = "lbChieu";
            this.lbChieu.Size = new System.Drawing.Size(238, 172);
            this.lbChieu.TabIndex = 7;
            // 
            // lbSang
            // 
            this.lbSang.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSang.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSang.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbSang.FormattingEnabled = true;
            this.lbSang.ItemHeight = 26;
            this.lbSang.Location = new System.Drawing.Point(130, 42);
            this.lbSang.Name = "lbSang";
            this.lbSang.Size = new System.Drawing.Size(238, 172);
            this.lbSang.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 172);
            this.panel3.TabIndex = 5;
            // 
            // ucShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.lbToi);
            this.Controls.Add(this.lbChieu);
            this.Controls.Add(this.lbSang);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucShift";
            this.Size = new System.Drawing.Size(844, 305);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbThu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ListBox lbToi;
        public System.Windows.Forms.ListBox lbChieu;
        public System.Windows.Forms.ListBox lbSang;
        private System.Windows.Forms.Panel panel3;
        public Guna.UI2.WinForms.Guna2Button btAdd;
        public Guna.UI2.WinForms.Guna2Button btView;
    }
}
