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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbUnpaid = new System.Windows.Forms.RadioButton();
            this.rbPaid = new System.Windows.Forms.RadioButton();
            this.billDate = new System.Windows.Forms.DateTimePicker();
            this.txtIdAcc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdBill = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.idBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymenttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbborder = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbUnpaid);
            this.panel1.Controls.Add(this.rbPaid);
            this.panel1.Controls.Add(this.billDate);
            this.panel1.Controls.Add(this.txtIdAcc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.total);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbbTable);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNameCustomer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIdBill);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 745);
            this.panel1.TabIndex = 28;
            // 
            // rbUnpaid
            // 
            this.rbUnpaid.AutoSize = true;
            this.rbUnpaid.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.rbUnpaid.Location = new System.Drawing.Point(326, 525);
            this.rbUnpaid.Name = "rbUnpaid";
            this.rbUnpaid.Size = new System.Drawing.Size(193, 31);
            this.rbUnpaid.TabIndex = 48;
            this.rbUnpaid.TabStop = true;
            this.rbUnpaid.Text = "Chưa thanh toán";
            this.rbUnpaid.UseVisualStyleBackColor = true;
            // 
            // rbPaid
            // 
            this.rbPaid.AutoSize = true;
            this.rbPaid.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.rbPaid.Location = new System.Drawing.Point(34, 525);
            this.rbPaid.Name = "rbPaid";
            this.rbPaid.Size = new System.Drawing.Size(169, 31);
            this.rbPaid.TabIndex = 47;
            this.rbPaid.TabStop = true;
            this.rbPaid.Text = "Đã thanh toán";
            this.rbPaid.UseVisualStyleBackColor = true;
            // 
            // billDate
            // 
            this.billDate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.billDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.billDate.Location = new System.Drawing.Point(238, 382);
            this.billDate.Name = "billDate";
            this.billDate.Size = new System.Drawing.Size(327, 34);
            this.billDate.TabIndex = 46;
            // 
            // txtIdAcc
            // 
            this.txtIdAcc.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtIdAcc.Location = new System.Drawing.Point(238, 182);
            this.txtIdAcc.Name = "txtIdAcc";
            this.txtIdAcc.Size = new System.Drawing.Size(327, 34);
            this.txtIdAcc.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label7.Location = new System.Drawing.Point(29, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 27);
            this.label7.TabIndex = 44;
            this.label7.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(29, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 27);
            this.label1.TabIndex = 38;
            this.label1.Text = "Bàn:";
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.total.Location = new System.Drawing.Point(238, 451);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(327, 34);
            this.total.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label4.Location = new System.Drawing.Point(29, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 27);
            this.label4.TabIndex = 39;
            this.label4.Text = "Tổng tiền:";
            // 
            // cbbTable
            // 
            this.cbbTable.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cbbTable.FormattingEnabled = true;
            this.cbbTable.Location = new System.Drawing.Point(238, 320);
            this.cbbTable.Name = "cbbTable";
            this.cbbTable.Size = new System.Drawing.Size(327, 34);
            this.cbbTable.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label3.Location = new System.Drawing.Point(29, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 27);
            this.label3.TabIndex = 37;
            this.label3.Text = "Mã nhân viên:";
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtNameCustomer.Location = new System.Drawing.Point(238, 248);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(327, 34);
            this.txtNameCustomer.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label2.Location = new System.Drawing.Point(29, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 27);
            this.label2.TabIndex = 36;
            this.label2.Text = "Thời gian:";
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
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btDelete.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btDelete.ForeColor = System.Drawing.Color.Black;
            this.btDelete.Location = new System.Drawing.Point(356, 582);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(122, 47);
            this.btDelete.TabIndex = 34;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btEdit.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btEdit.ForeColor = System.Drawing.Color.Black;
            this.btEdit.Location = new System.Drawing.Point(95, 582);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(122, 47);
            this.btEdit.TabIndex = 33;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
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
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn:";
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBill,
            this.Customer,
            this.idAccount,
            this.paymenttime,
            this.status,
            this.name,
            this.cbborder,
            this.tong});
            this.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoice.GridColor = System.Drawing.SystemColors.InfoText;
            this.dgvInvoice.Location = new System.Drawing.Point(3, 30);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowHeadersWidth = 51;
            this.dgvInvoice.RowTemplate.Height = 24;
            this.dgvInvoice.Size = new System.Drawing.Size(555, 712);
            this.dgvInvoice.TabIndex = 2;
            this.dgvInvoice.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInvoice_RowHeaderMouseClick);
            // 
            // idBill
            // 
            this.idBill.DataPropertyName = "idBill";
            this.idBill.HeaderText = "ID";
            this.idBill.MinimumWidth = 6;
            this.idBill.Name = "idBill";
            this.idBill.Width = 125;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "Customer";
            this.Customer.HeaderText = "Tên khách hàng";
            this.Customer.MinimumWidth = 6;
            this.Customer.Name = "Customer";
            this.Customer.Width = 125;
            // 
            // idAccount
            // 
            this.idAccount.DataPropertyName = "idAccount";
            this.idAccount.HeaderText = "ID nhân viên";
            this.idAccount.MinimumWidth = 6;
            this.idAccount.Name = "idAccount";
            this.idAccount.Width = 125;
            // 
            // paymenttime
            // 
            this.paymenttime.DataPropertyName = "paymenttime";
            this.paymenttime.HeaderText = "Giờ xuất hóa đơn";
            this.paymenttime.MinimumWidth = 6;
            this.paymenttime.Name = "paymenttime";
            this.paymenttime.Width = 125;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.FalseValue = "false";
            this.status.HeaderText = "Thanh toán";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.TrueValue = "true";
            this.status.Width = 125;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Bàn";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // cbborder
            // 
            this.cbborder.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cbborder.HeaderText = "Đồ uống";
            this.cbborder.MinimumWidth = 6;
            this.cbborder.Name = "cbborder";
            this.cbborder.Width = 250;
            // 
            // tong
            // 
            this.tong.HeaderText = "Tổng tiền";
            this.tong.MinimumWidth = 6;
            this.tong.Name = "tong";
            this.tong.ReadOnly = true;
            this.tong.Width = 125;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbUnpaid;
        private System.Windows.Forms.RadioButton rbPaid;
        private System.Windows.Forms.DateTimePicker billDate;
        private System.Windows.Forms.TextBox txtIdAcc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymenttime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbborder;
        private System.Windows.Forms.DataGridViewTextBoxColumn tong;
    }
}