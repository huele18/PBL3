namespace PBL3.GUI
{
    partial class ucAccountInfo
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
            this.pbAnh = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbChucvu = new System.Windows.Forms.Label();
            this.lbSdt = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCa = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAnh
            // 
            this.pbAnh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbAnh.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbAnh.Location = new System.Drawing.Point(3, 3);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(110, 94);
            this.pbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnh.TabIndex = 0;
            this.pbAnh.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(119, 18);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(87, 27);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "lbName";
            // 
            // lbChucvu
            // 
            this.lbChucvu.AutoSize = true;
            this.lbChucvu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucvu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbChucvu.Location = new System.Drawing.Point(120, 56);
            this.lbChucvu.Name = "lbChucvu";
            this.lbChucvu.Size = new System.Drawing.Size(85, 22);
            this.lbChucvu.TabIndex = 2;
            this.lbChucvu.Text = "lbChucvu";
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSdt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbSdt.Location = new System.Drawing.Point(368, 39);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(52, 22);
            this.lbSdt.TabIndex = 3;
            this.lbSdt.Text = "lbSdt";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbEmail.Location = new System.Drawing.Point(548, 23);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(73, 22);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "lbEmail";
            // 
            // lbCa
            // 
            this.lbCa.AutoSize = true;
            this.lbCa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCa.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbCa.Location = new System.Drawing.Point(888, 39);
            this.lbCa.Name = "lbCa";
            this.lbCa.Size = new System.Drawing.Size(48, 22);
            this.lbCa.TabIndex = 5;
            this.lbCa.Text = "lbCa";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbAddress.Location = new System.Drawing.Point(548, 56);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(92, 22);
            this.lbAddress.TabIndex = 6;
            this.lbAddress.Text = "lbAddress";
            // 
            // ucAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbCa);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbSdt);
            this.Controls.Add(this.lbChucvu);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pbAnh);
            this.Name = "ucAccountInfo";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(1050, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbAnh;
        public System.Windows.Forms.Label lbName;
        public System.Windows.Forms.Label lbChucvu;
        public System.Windows.Forms.Label lbSdt;
        public System.Windows.Forms.Label lbEmail;
        public System.Windows.Forms.Label lbCa;
        public System.Windows.Forms.Label lbAddress;
    }
}
