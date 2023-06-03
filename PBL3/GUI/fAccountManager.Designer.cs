namespace PBL3.GUI
{
    partial class fAccountManager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btUpdateInf = new System.Windows.Forms.Button();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDAccount = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCalam = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btsetPass = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtNewPass2 = new System.Windows.Forms.TextBox();
            this.txtNewPass1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1150, 713);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btUpdateInf);
            this.tabPage1.Controls.Add(this.rbFemale);
            this.tabPage1.Controls.Add(this.rbMale);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtIDAccount);
            this.tabPage1.Controls.Add(this.txtType);
            this.tabPage1.Controls.Add(this.txtDisplayName);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtCalam);
            this.tabPage1.Controls.Add(this.txtUserName);
            this.tabPage1.Controls.Add(this.txtSDT);
            this.tabPage1.Controls.Add(this.txtPass);
            this.tabPage1.Controls.Add(this.lbTitle);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(146)))), ((int)(((byte)(160)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1142, 674);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin cá nhân";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.FillColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.ImageRotate = 0F;
            this.pictureBox1.Location = new System.Drawing.Point(133, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox1.Size = new System.Drawing.Size(205, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btUpdateInf
            // 
            this.btUpdateInf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btUpdateInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btUpdateInf.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btUpdateInf.ForeColor = System.Drawing.Color.Black;
            this.btUpdateInf.Location = new System.Drawing.Point(450, 589);
            this.btUpdateInf.Name = "btUpdateInf";
            this.btUpdateInf.Size = new System.Drawing.Size(234, 49);
            this.btUpdateInf.TabIndex = 25;
            this.btUpdateInf.Text = "Cập nhật thông tin";
            this.btUpdateInf.UseVisualStyleBackColor = false;
            this.btUpdateInf.Click += new System.EventHandler(this.btUpdateInf_Click);
            // 
            // rbFemale
            // 
            this.rbFemale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.rbFemale.ForeColor = System.Drawing.Color.Black;
            this.rbFemale.Location = new System.Drawing.Point(846, 209);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(63, 31);
            this.rbFemale.TabIndex = 24;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.rbMale.ForeColor = System.Drawing.Color.Black;
            this.rbMale.Location = new System.Drawing.Point(632, 209);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(79, 31);
            this.rbMale.TabIndex = 23;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(417, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 27);
            this.label5.TabIndex = 21;
            this.label5.Text = "Địa chỉ:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(417, 538);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 27);
            this.label11.TabIndex = 20;
            this.label11.Text = "Loại tài khoản:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(189, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 22);
            this.label14.TabIndex = 19;
            this.label14.Text = "Thêm ảnh";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(417, 492);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 27);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ca làm:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(417, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "SDT:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(417, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 27);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(417, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "Giới tính:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(417, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 27);
            this.label7.TabIndex = 22;
            this.label7.Text = "Username:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(417, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(417, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(417, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID tài khoản:";
            // 
            // txtIDAccount
            // 
            this.txtIDAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDAccount.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtIDAccount.Location = new System.Drawing.Point(632, 114);
            this.txtIDAccount.Name = "txtIDAccount";
            this.txtIDAccount.ReadOnly = true;
            this.txtIDAccount.Size = new System.Drawing.Size(345, 34);
            this.txtIDAccount.TabIndex = 11;
            // 
            // txtType
            // 
            this.txtType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtType.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtType.Location = new System.Drawing.Point(632, 531);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(345, 34);
            this.txtType.TabIndex = 10;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDisplayName.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtDisplayName.Location = new System.Drawing.Point(632, 161);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(345, 34);
            this.txtDisplayName.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtAddress.Location = new System.Drawing.Point(632, 303);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(345, 34);
            this.txtAddress.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtEmail.Location = new System.Drawing.Point(632, 348);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(345, 34);
            this.txtEmail.TabIndex = 7;
            // 
            // txtCalam
            // 
            this.txtCalam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCalam.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtCalam.Location = new System.Drawing.Point(632, 486);
            this.txtCalam.Name = "txtCalam";
            this.txtCalam.ReadOnly = true;
            this.txtCalam.Size = new System.Drawing.Size(345, 34);
            this.txtCalam.TabIndex = 6;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtUserName.Location = new System.Drawing.Point(632, 393);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(345, 34);
            this.txtUserName.TabIndex = 5;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtSDT.Location = new System.Drawing.Point(632, 253);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(345, 34);
            this.txtSDT.TabIndex = 12;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtPass.Location = new System.Drawing.Point(632, 440);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(345, 34);
            this.txtPass.TabIndex = 4;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitle.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(109)))), ((int)(((byte)(48)))));
            this.lbTitle.Location = new System.Drawing.Point(310, 39);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(541, 55);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Tài khoản cá nhân";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.tabPage2.Controls.Add(this.btsetPass);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label99);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtOldPass);
            this.tabPage2.Controls.Add(this.txtNewPass2);
            this.tabPage2.Controls.Add(this.txtNewPass1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(146)))), ((int)(((byte)(160)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1142, 674);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đổi mật khẩu";
            // 
            // btsetPass
            // 
            this.btsetPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btsetPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btsetPass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsetPass.ForeColor = System.Drawing.Color.Black;
            this.btsetPass.Location = new System.Drawing.Point(467, 453);
            this.btsetPass.Name = "btsetPass";
            this.btsetPass.Size = new System.Drawing.Size(234, 49);
            this.btsetPass.TabIndex = 10;
            this.btsetPass.Text = "Đổi mật khẩu";
            this.btsetPass.UseVisualStyleBackColor = false;
            this.btsetPass.Click += new System.EventHandler(this.btsetPass_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(276, 351);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 26);
            this.label13.TabIndex = 7;
            this.label13.Text = "Nhập lại:";
            // 
            // label99
            // 
            this.label99.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.ForeColor = System.Drawing.Color.Black;
            this.label99.Location = new System.Drawing.Point(276, 247);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(133, 26);
            this.label99.TabIndex = 8;
            this.label99.Text = "Mật khẩu cũ:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(276, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 26);
            this.label12.TabIndex = 9;
            this.label12.Text = "Mật khẩu mới:";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOldPass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPass.Location = new System.Drawing.Point(518, 239);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(377, 34);
            this.txtOldPass.TabIndex = 4;
            // 
            // txtNewPass2
            // 
            this.txtNewPass2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPass2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass2.Location = new System.Drawing.Point(518, 351);
            this.txtNewPass2.Name = "txtNewPass2";
            this.txtNewPass2.PasswordChar = '*';
            this.txtNewPass2.Size = new System.Drawing.Size(377, 34);
            this.txtNewPass2.TabIndex = 5;
            // 
            // txtNewPass1
            // 
            this.txtNewPass1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPass1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass1.Location = new System.Drawing.Point(518, 294);
            this.txtNewPass1.Name = "txtNewPass1";
            this.txtNewPass1.PasswordChar = '*';
            this.txtNewPass1.Size = new System.Drawing.Size(377, 34);
            this.txtNewPass1.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(109)))), ((int)(((byte)(48)))));
            this.label10.Location = new System.Drawing.Point(384, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(382, 55);
            this.label10.TabIndex = 2;
            this.label10.Text = "Đổi mật khẩu";
            // 
            // fAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1150, 713);
            this.Controls.Add(this.tabControl1);
            this.Name = "fAccountManager";
            this.Text = "Quản lý tài khoản cá nhân";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btUpdateInf;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDAccount;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCalam;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btsetPass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.TextBox txtNewPass2;
        private System.Windows.Forms.TextBox txtNewPass1;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox1;
    }
}