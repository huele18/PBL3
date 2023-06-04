namespace PBL3.GUI
{
    partial class fAddShift
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
            this.label2 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.cbbStaff = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbCa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbThu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 27);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ca làm:";
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(330, 369);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(122, 47);
            this.btAdd.TabIndex = 28;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // cbbStaff
            // 
            this.cbbStaff.BackColor = System.Drawing.Color.Transparent;
            this.cbbStaff.BorderRadius = 15;
            this.cbbStaff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStaff.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbStaff.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cbbStaff.ForeColor = System.Drawing.Color.Black;
            this.cbbStaff.ItemHeight = 30;
            this.cbbStaff.Location = new System.Drawing.Point(359, 126);
            this.cbbStaff.Name = "cbbStaff";
            this.cbbStaff.Size = new System.Drawing.Size(281, 36);
            this.cbbStaff.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 27);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tên nhân viên:";
            // 
            // cbbCa
            // 
            this.cbbCa.BackColor = System.Drawing.Color.Transparent;
            this.cbbCa.BorderRadius = 15;
            this.cbbCa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbCa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbCa.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cbbCa.ForeColor = System.Drawing.Color.Black;
            this.cbbCa.ItemHeight = 30;
            this.cbbCa.Location = new System.Drawing.Point(359, 185);
            this.cbbCa.Name = "cbbCa";
            this.cbbCa.Size = new System.Drawing.Size(281, 36);
            this.cbbCa.TabIndex = 32;
            this.cbbCa.SelectedIndexChanged += new System.EventHandler(this.cbbCa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 27);
            this.label1.TabIndex = 33;
            this.label1.Text = "Từ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(367, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 27);
            this.label6.TabIndex = 36;
            this.label6.Text = "Đến:";
            // 
            // dtpStart
            // 
            this.dtpStart.Checked = false;
            this.dtpStart.Enabled = false;
            this.dtpStart.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStart.Location = new System.Drawing.Point(440, 241);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 34);
            this.dtpStart.TabIndex = 37;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Checked = false;
            this.dtpEnd.CustomFormat = "";
            this.dtpEnd.Enabled = false;
            this.dtpEnd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEnd.Location = new System.Drawing.Point(440, 301);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 34);
            this.dtpEnd.TabIndex = 38;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitle.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(109)))), ((int)(((byte)(48)))));
            this.lbTitle.Location = new System.Drawing.Point(154, 25);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(541, 55);
            this.lbTitle.TabIndex = 39;
            this.lbTitle.Text = "Phân công ca làm";
            // 
            // lbThu
            // 
            this.lbThu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(109)))), ((int)(((byte)(48)))));
            this.lbThu.Location = new System.Drawing.Point(305, 80);
            this.lbThu.Name = "lbThu";
            this.lbThu.Size = new System.Drawing.Size(147, 32);
            this.lbThu.TabIndex = 40;
            this.lbThu.Text = "Thứ";
            // 
            // fAddShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbThu);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbCa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbStaff);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label2);
            this.Name = "fAddShift";
            this.Text = "Thêm nhân viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAdd;
        private Guna.UI2.WinForms.Guna2ComboBox cbbStaff;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbbCa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbThu;
    }
}