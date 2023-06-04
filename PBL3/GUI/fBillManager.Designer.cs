namespace PBL3.GUI
{
    partial class fBillManager
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
            this.tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtoan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.paymenttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdAcc = new System.Windows.Forms.TextBox();
            this.billDate = new System.Windows.Forms.DateTimePicker();
            this.rbPaid = new System.Windows.Forms.RadioButton();
            this.rbUnpaid = new System.Windows.Forms.RadioButton();
            this.cbbTable = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.searchDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tong
            // 
            this.tong.HeaderText = "Tổng tiền";
            this.tong.MinimumWidth = 6;
            this.tong.Name = "tong";
            this.tong.ReadOnly = true;
            this.tong.Width = 125;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Bàn";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // thanhtoan
            // 
            this.thanhtoan.DataPropertyName = "thanhtoan";
            this.thanhtoan.FalseValue = "false";
            this.thanhtoan.HeaderText = "Thanh toán";
            this.thanhtoan.MinimumWidth = 6;
            this.thanhtoan.Name = "thanhtoan";
            this.thanhtoan.ReadOnly = true;
            this.thanhtoan.TrueValue = "true";
            this.thanhtoan.Width = 125;
            // 
            // paymenttime
            // 
            this.paymenttime.DataPropertyName = "paymenttime";
            this.paymenttime.HeaderText = "Giờ xuất hóa đơn";
            this.paymenttime.MinimumWidth = 6;
            this.paymenttime.Name = "paymenttime";
            this.paymenttime.ReadOnly = true;
            this.paymenttime.Width = 125;
            // 
            // idAccount
            // 
            this.idAccount.DataPropertyName = "idAccount";
            this.idAccount.HeaderText = "ID nhân viên";
            this.idAccount.MinimumWidth = 6;
            this.idAccount.Name = "idAccount";
            this.idAccount.ReadOnly = true;
            this.idAccount.Width = 125;
            // 
            // idBill
            // 
            this.idBill.DataPropertyName = "idBill";
            this.idBill.HeaderText = "ID";
            this.idBill.MinimumWidth = 6;
            this.idBill.Name = "idBill";
            this.idBill.ReadOnly = true;
            this.idBill.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.groupBox1.Controls.Add(this.dgvInvoice);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.groupBox1.Location = new System.Drawing.Point(625, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 745);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn:";
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBill,
            this.idAccount,
            this.paymenttime,
            this.thanhtoan,
            this.name,
            this.detail,
            this.tong});
            this.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoice.GridColor = System.Drawing.SystemColors.InfoText;
            this.dgvInvoice.Location = new System.Drawing.Point(3, 30);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowHeadersWidth = 51;
            this.dgvInvoice.RowTemplate.Height = 24;
            this.dgvInvoice.Size = new System.Drawing.Size(555, 712);
            this.dgvInvoice.TabIndex = 2;
            this.dgvInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellContentClick);
            this.dgvInvoice.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInvoice_RowHeaderMouseClick);
            // 
            // detail
            // 
            this.detail.HeaderText = "Chi tiết";
            this.detail.MinimumWidth = 6;
            this.detail.Name = "detail";
            this.detail.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.searchDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbFilter);
            this.panel1.Controls.Add(this.cbbTable);
            this.panel1.Controls.Add(this.rbUnpaid);
            this.panel1.Controls.Add(this.rbPaid);
            this.panel1.Controls.Add(this.billDate);
            this.panel1.Controls.Add(this.txtIdAcc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.total);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIdBill);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 745);
            this.panel1.TabIndex = 30;
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btEdit.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btEdit.ForeColor = System.Drawing.Color.Black;
            this.btEdit.Location = new System.Drawing.Point(117, 658);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(122, 47);
            this.btEdit.TabIndex = 33;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btDelete.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btDelete.ForeColor = System.Drawing.Color.Black;
            this.btDelete.Location = new System.Drawing.Point(378, 658);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(122, 47);
            this.btDelete.TabIndex = 34;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label6.Location = new System.Drawing.Point(29, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 27);
            this.label6.TabIndex = 35;
            this.label6.Text = "Mã số đơn:";
            // 
            // txtIdBill
            // 
            this.txtIdBill.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtIdBill.Location = new System.Drawing.Point(238, 116);
            this.txtIdBill.Name = "txtIdBill";
            this.txtIdBill.ReadOnly = true;
            this.txtIdBill.Size = new System.Drawing.Size(327, 34);
            this.txtIdBill.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label2.Location = new System.Drawing.Point(29, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 27);
            this.label2.TabIndex = 36;
            this.label2.Text = "Thời gian:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label3.Location = new System.Drawing.Point(29, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 27);
            this.label3.TabIndex = 37;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label4.Location = new System.Drawing.Point(29, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 27);
            this.label4.TabIndex = 39;
            this.label4.Text = "Tổng tiền:";
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.total.Location = new System.Drawing.Point(238, 388);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(327, 34);
            this.total.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(29, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 27);
            this.label1.TabIndex = 38;
            this.label1.Text = "Bàn:";
            // 
            // txtIdAcc
            // 
            this.txtIdAcc.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtIdAcc.Location = new System.Drawing.Point(238, 184);
            this.txtIdAcc.Name = "txtIdAcc";
            this.txtIdAcc.Size = new System.Drawing.Size(327, 34);
            this.txtIdAcc.TabIndex = 45;
            // 
            // billDate
            // 
            this.billDate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.billDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.billDate.Location = new System.Drawing.Point(238, 320);
            this.billDate.Name = "billDate";
            this.billDate.Size = new System.Drawing.Size(327, 34);
            this.billDate.TabIndex = 46;
            // 
            // rbPaid
            // 
            this.rbPaid.AutoSize = true;
            this.rbPaid.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.rbPaid.Location = new System.Drawing.Point(34, 545);
            this.rbPaid.Name = "rbPaid";
            this.rbPaid.Size = new System.Drawing.Size(169, 31);
            this.rbPaid.TabIndex = 47;
            this.rbPaid.TabStop = true;
            this.rbPaid.Text = "Đã thanh toán";
            this.rbPaid.UseVisualStyleBackColor = true;
            // 
            // rbUnpaid
            // 
            this.rbUnpaid.AutoSize = true;
            this.rbUnpaid.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.rbUnpaid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbUnpaid.Location = new System.Drawing.Point(372, 545);
            this.rbUnpaid.Name = "rbUnpaid";
            this.rbUnpaid.Size = new System.Drawing.Size(193, 31);
            this.rbUnpaid.TabIndex = 48;
            this.rbUnpaid.TabStop = true;
            this.rbUnpaid.Text = "Chưa thanh toán";
            this.rbUnpaid.UseVisualStyleBackColor = true;
            // 
            // cbbTable
            // 
            this.cbbTable.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cbbTable.FormattingEnabled = true;
            this.cbbTable.Location = new System.Drawing.Point(238, 252);
            this.cbbTable.Name = "cbbTable";
            this.cbbTable.Size = new System.Drawing.Size(327, 34);
            this.cbbTable.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label5.Location = new System.Drawing.Point(29, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 27);
            this.label5.TabIndex = 53;
            this.label5.Text = "Xem theo thời gian";
            // 
            // cbFilter
            // 
            this.cbFilter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(238, 469);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(327, 34);
            this.cbFilter.TabIndex = 52;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(34, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 34);
            this.button1.TabIndex = 55;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchDate
            // 
            this.searchDate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.searchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.searchDate.Location = new System.Drawing.Point(238, 28);
            this.searchDate.Name = "searchDate";
            this.searchDate.Size = new System.Drawing.Size(327, 34);
            this.searchDate.TabIndex = 54;
            // 
            // fBillManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1186, 745);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "fBillManager";
            this.Text = "Quản lý hóa đơn bán ra";
            this.Load += new System.EventHandler(this.fBillManager_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn tong;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn thanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymenttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.DataGridViewButtonColumn detail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbTable;
        private System.Windows.Forms.RadioButton rbUnpaid;
        private System.Windows.Forms.RadioButton rbPaid;
        private System.Windows.Forms.DateTimePicker billDate;
        private System.Windows.Forms.TextBox txtIdAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker searchDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFilter;
    }
}