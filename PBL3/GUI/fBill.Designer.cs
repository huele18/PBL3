namespace PBL3.GUI
{
    partial class fBill
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
            this.label10 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbStaff = new System.Windows.Forms.Label();
            this.lbTable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbIdBill = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTong = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBillInfo = new System.Windows.Forms.DataGridView();
            this.idFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Controls.Add(this.lbStaff);
            this.panel1.Controls.Add(this.lbTable);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbIdBill);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 211);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Thời gian thanh toán:";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(203, 185);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(53, 20);
            this.lbTime.TabIndex = 7;
            this.lbTime.Text = "label8";
            // 
            // lbStaff
            // 
            this.lbStaff.AutoSize = true;
            this.lbStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaff.Location = new System.Drawing.Point(126, 123);
            this.lbStaff.Name = "lbStaff";
            this.lbStaff.Size = new System.Drawing.Size(53, 20);
            this.lbStaff.TabIndex = 6;
            this.lbStaff.Text = "label7";
            // 
            // lbTable
            // 
            this.lbTable.AutoSize = true;
            this.lbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTable.Location = new System.Drawing.Point(82, 155);
            this.lbTable.Name = "lbTable";
            this.lbTable.Size = new System.Drawing.Size(53, 20);
            this.lbTable.TabIndex = 5;
            this.lbTable.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bàn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhân viên:";
            // 
            // lbIdBill
            // 
            this.lbIdBill.AutoSize = true;
            this.lbIdBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdBill.Location = new System.Drawing.Point(130, 91);
            this.lbIdBill.Name = "lbIdBill";
            this.lbIdBill.Size = new System.Drawing.Size(53, 20);
            this.lbIdBill.TabIndex = 2;
            this.lbIdBill.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã số đơn:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(378, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa  Đơn";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.lbTong);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 667);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(908, 107);
            this.panel3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(647, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tổng tiền:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(403, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "SĐT: 0000000000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(382, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Địa chỉ: XXX - Đà Nẵng";
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.Location = new System.Drawing.Point(776, 12);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(53, 20);
            this.lbTong.TabIndex = 8;
            this.lbTong.Text = "label9";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBillInfo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(908, 456);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn";
            // 
            // dgvBillInfo
            // 
            this.dgvBillInfo.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvBillInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFood,
            this.NameFood,
            this.count,
            this.price,
            this.Total});
            this.dgvBillInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBillInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(146)))), ((int)(((byte)(160)))));
            this.dgvBillInfo.Location = new System.Drawing.Point(3, 22);
            this.dgvBillInfo.Name = "dgvBillInfo";
            this.dgvBillInfo.RowHeadersWidth = 51;
            this.dgvBillInfo.RowTemplate.Height = 24;
            this.dgvBillInfo.Size = new System.Drawing.Size(902, 431);
            this.dgvBillInfo.TabIndex = 2;
            // 
            // idFood
            // 
            this.idFood.DataPropertyName = "idFood";
            this.idFood.HeaderText = "ID";
            this.idFood.MinimumWidth = 6;
            this.idFood.Name = "idFood";
            this.idFood.Width = 125;
            // 
            // NameFood
            // 
            this.NameFood.DataPropertyName = "NameFood";
            this.NameFood.HeaderText = "Tên Đồ uống";
            this.NameFood.MinimumWidth = 6;
            this.NameFood.Name = "NameFood";
            this.NameFood.Width = 125;
            // 
            // count
            // 
            this.count.DataPropertyName = "billquantity";
            this.count.HeaderText = "Số lượng";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.Width = 125;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Đơn giá";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Tổng Tiền";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // fBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 774);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "fBill";
            this.Text = "fBill";
            this.Load += new System.EventHandler(this.fBill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbStaff;
        private System.Windows.Forms.Label lbTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbIdBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dgvBillInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}