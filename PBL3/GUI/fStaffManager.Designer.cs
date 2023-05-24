namespace PBL3.GUI
{
    partial class fStaffManager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.browse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btDeleteEmployee = new System.Windows.Forms.Button();
            this.btUpdateEmployee = new System.Windows.Forms.Button();
            this.btRReset = new System.Windows.Forms.Button();
            this.btAddEmployee = new System.Windows.Forms.Button();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAccessCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbShift = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmployeeName = new System.Windows.Forms.TextBox();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.tbEmployeeId = new System.Windows.Forms.TextBox();
            this.lbEmployeeId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSearchEmployee = new System.Windows.Forms.Button();
            this.tbSearchEmployee = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.idAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anh = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.groupBox1.Controls.Add(this.browse);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btDeleteEmployee);
            this.groupBox1.Controls.Add(this.btUpdateEmployee);
            this.groupBox1.Controls.Add(this.btRReset);
            this.groupBox1.Controls.Add(this.btAddEmployee);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbAccessCode);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbShift);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbPhoneNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbEmployeeName);
            this.groupBox1.Controls.Add(this.lbEmployeeName);
            this.groupBox1.Controls.Add(this.tbEmployeeId);
            this.groupBox1.Controls.Add(this.lbEmployeeId);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 743);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết:";
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.ForeColor = System.Drawing.Color.White;
            this.browse.Location = new System.Drawing.Point(430, 120);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(112, 36);
            this.browse.TabIndex = 32;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.Location = new System.Drawing.Point(239, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btDeleteEmployee
            // 
            this.btDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteEmployee.ForeColor = System.Drawing.Color.White;
            this.btDeleteEmployee.Location = new System.Drawing.Point(430, 684);
            this.btDeleteEmployee.Name = "btDeleteEmployee";
            this.btDeleteEmployee.Size = new System.Drawing.Size(122, 47);
            this.btDeleteEmployee.TabIndex = 25;
            this.btDeleteEmployee.Text = "Xóa";
            this.btDeleteEmployee.UseVisualStyleBackColor = false;
            this.btDeleteEmployee.Click += new System.EventHandler(this.btDeleteEmployee_Click);
            // 
            // btUpdateEmployee
            // 
            this.btUpdateEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btUpdateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateEmployee.ForeColor = System.Drawing.Color.White;
            this.btUpdateEmployee.Location = new System.Drawing.Point(258, 684);
            this.btUpdateEmployee.Name = "btUpdateEmployee";
            this.btUpdateEmployee.Size = new System.Drawing.Size(122, 47);
            this.btUpdateEmployee.TabIndex = 26;
            this.btUpdateEmployee.Text = "Sửa";
            this.btUpdateEmployee.UseVisualStyleBackColor = false;
            this.btUpdateEmployee.Click += new System.EventHandler(this.btUpdateEmployee_Click);
            // 
            // btRReset
            // 
            this.btRReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btRReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRReset.ForeColor = System.Drawing.Color.White;
            this.btRReset.Location = new System.Drawing.Point(80, 631);
            this.btRReset.Name = "btRReset";
            this.btRReset.Size = new System.Drawing.Size(473, 47);
            this.btRReset.TabIndex = 27;
            this.btRReset.Text = "Đặt lại mật khẩu mặc định";
            this.btRReset.UseVisualStyleBackColor = false;
            this.btRReset.Click += new System.EventHandler(this.btRReset_Click);
            // 
            // btAddEmployee
            // 
            this.btAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btAddEmployee.Location = new System.Drawing.Point(81, 684);
            this.btAddEmployee.Name = "btAddEmployee";
            this.btAddEmployee.Size = new System.Drawing.Size(130, 47);
            this.btAddEmployee.TabIndex = 28;
            this.btAddEmployee.Text = "Thêm";
            this.btAddEmployee.UseVisualStyleBackColor = false;
            this.btAddEmployee.Click += new System.EventHandler(this.btAddEmployee_Click);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(239, 333);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(77, 30);
            this.rbMale.TabIndex = 24;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(405, 333);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(61, 30);
            this.rbFemale.TabIndex = 23;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "Giới tính:";
            // 
            // tbAccessCode
            // 
            this.tbAccessCode.Location = new System.Drawing.Point(239, 569);
            this.tbAccessCode.Name = "tbAccessCode";
            this.tbAccessCode.Size = new System.Drawing.Size(371, 34);
            this.tbAccessCode.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 572);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 26);
            this.label9.TabIndex = 20;
            this.label9.Text = "Mã quyền:";
            // 
            // tbShift
            // 
            this.tbShift.Location = new System.Drawing.Point(238, 529);
            this.tbShift.Name = "tbShift";
            this.tbShift.Size = new System.Drawing.Size(371, 34);
            this.tbShift.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 532);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ca làm:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(239, 489);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(370, 34);
            this.tbUsername.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tên đăng nhập:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(239, 449);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(371, 34);
            this.tbEmail.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(239, 409);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(371, 34);
            this.tbAddress.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Địa chỉ:";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(239, 369);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(371, 34);
            this.tbPhoneNumber.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "SĐT:";
            // 
            // tbEmployeeName
            // 
            this.tbEmployeeName.Location = new System.Drawing.Point(239, 293);
            this.tbEmployeeName.Name = "tbEmployeeName";
            this.tbEmployeeName.Size = new System.Drawing.Size(371, 34);
            this.tbEmployeeName.TabIndex = 5;
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Location = new System.Drawing.Point(33, 296);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(152, 26);
            this.lbEmployeeName.TabIndex = 4;
            this.lbEmployeeName.Text = "Tên nhân viên:";
            // 
            // tbEmployeeId
            // 
            this.tbEmployeeId.Location = new System.Drawing.Point(239, 253);
            this.tbEmployeeId.Name = "tbEmployeeId";
            this.tbEmployeeId.Size = new System.Drawing.Size(371, 34);
            this.tbEmployeeId.TabIndex = 3;
            // 
            // lbEmployeeId
            // 
            this.lbEmployeeId.AutoSize = true;
            this.lbEmployeeId.Location = new System.Drawing.Point(33, 256);
            this.lbEmployeeId.Name = "lbEmployeeId";
            this.lbEmployeeId.Size = new System.Drawing.Size(145, 26);
            this.lbEmployeeId.TabIndex = 2;
            this.lbEmployeeId.Text = "Mã nhân viên:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.btSearchEmployee);
            this.panel1.Controls.Add(this.tbSearchEmployee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(657, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 100);
            this.panel1.TabIndex = 1;
            // 
            // btSearchEmployee
            // 
            this.btSearchEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearchEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearchEmployee.ForeColor = System.Drawing.Color.White;
            this.btSearchEmployee.Location = new System.Drawing.Point(402, 27);
            this.btSearchEmployee.Name = "btSearchEmployee";
            this.btSearchEmployee.Size = new System.Drawing.Size(122, 47);
            this.btSearchEmployee.TabIndex = 3;
            this.btSearchEmployee.Text = "Tìm kiếm";
            this.btSearchEmployee.UseVisualStyleBackColor = false;
            this.btSearchEmployee.Click += new System.EventHandler(this.btSearchEmployee_Click);
            // 
            // tbSearchEmployee
            // 
            this.tbSearchEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchEmployee.Location = new System.Drawing.Point(3, 35);
            this.tbSearchEmployee.Name = "tbSearchEmployee";
            this.tbSearchEmployee.Size = new System.Drawing.Size(352, 30);
            this.tbSearchEmployee.TabIndex = 2;
            this.tbSearchEmployee.Text = "Nhập từ khóa cần tìm kiếm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.panel2.Controls.Add(this.dgvEmployee);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(657, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 643);
            this.panel2.TabIndex = 2;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAccount,
            this.DisplayName,
            this.GT,
            this.SDT,
            this.address,
            this.email,
            this.UserName,
            this.Calam,
            this.Type,
            this.Anh});
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.GridColor = System.Drawing.SystemColors.InfoText;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(536, 643);
            this.dgvEmployee.TabIndex = 1;
            this.dgvEmployee.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmployee_RowHeaderMouseClick);
            // 
            // idAccount
            // 
            this.idAccount.DataPropertyName = "idAccount";
            this.idAccount.HeaderText = "Mã nhân viên";
            this.idAccount.MinimumWidth = 6;
            this.idAccount.Name = "idAccount";
            this.idAccount.Width = 118;
            // 
            // DisplayName
            // 
            this.DisplayName.DataPropertyName = "DisplayName";
            this.DisplayName.HeaderText = "Họ tên";
            this.DisplayName.MinimumWidth = 6;
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.Width = 69;
            // 
            // GT
            // 
            this.GT.DataPropertyName = "GT";
            this.GT.HeaderText = "Giới tính";
            this.GT.MinimumWidth = 6;
            this.GT.Name = "GT";
            this.GT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GT.Width = 58;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 84;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Địa chỉ";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.Width = 74;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 94;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Tên đăng nhập";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Width = 123;
            // 
            // Calam
            // 
            this.Calam.DataPropertyName = "Calam";
            this.Calam.HeaderText = "Ca làm";
            this.Calam.MinimumWidth = 6;
            this.Calam.Name = "Calam";
            this.Calam.Width = 98;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Chức vụ";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 110;
            // 
            // Anh
            // 
            this.Anh.DataPropertyName = "Anh";
            this.Anh.HeaderText = "Anh";
            this.Anh.MinimumWidth = 6;
            this.Anh.Name = "Anh";
            this.Anh.Visible = false;
            this.Anh.Width = 125;
            // 
            // fStaffManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1193, 743);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "fStaffManager";
            this.Text = "Quản lý danh sách nhân viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btDeleteEmployee;
        private System.Windows.Forms.Button btUpdateEmployee;
        private System.Windows.Forms.Button btRReset;
        private System.Windows.Forms.Button btAddEmployee;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAccessCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbShift;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmployeeName;
        private System.Windows.Forms.Label lbEmployeeName;
        private System.Windows.Forms.TextBox tbEmployeeId;
        private System.Windows.Forms.Label lbEmployeeId;
        private System.Windows.Forms.Button btSearchEmployee;
        private System.Windows.Forms.TextBox tbSearchEmployee;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewImageColumn Anh;
    }
}