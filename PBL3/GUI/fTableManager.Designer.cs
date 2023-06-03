namespace PBL3.GUI
{
    partial class fTableManager
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
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.rbCoNguoi = new System.Windows.Forms.RadioButton();
            this.rbTrong = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbOccupied = new System.Windows.Forms.RadioButton();
            this.rbUnoccupied = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.btEdit);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.rbCoNguoi);
            this.groupBox1.Controls.Add(this.rbTrong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 724);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết:";
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(413, 311);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(122, 47);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.Location = new System.Drawing.Point(254, 311);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(122, 47);
            this.btEdit.TabIndex = 10;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(90, 311);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(122, 47);
            this.btAdd.TabIndex = 11;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // rbCoNguoi
            // 
            this.rbCoNguoi.AutoSize = true;
            this.rbCoNguoi.Location = new System.Drawing.Point(384, 203);
            this.rbCoNguoi.Name = "rbCoNguoi";
            this.rbCoNguoi.Size = new System.Drawing.Size(126, 30);
            this.rbCoNguoi.TabIndex = 8;
            this.rbCoNguoi.Text = "Có Khách";
            this.rbCoNguoi.UseVisualStyleBackColor = true;
            // 
            // rbTrong
            // 
            this.rbTrong.AutoSize = true;
            this.rbTrong.Location = new System.Drawing.Point(225, 203);
            this.rbTrong.Name = "rbTrong";
            this.rbTrong.Size = new System.Drawing.Size(89, 30);
            this.rbTrong.TabIndex = 7;
            this.rbTrong.Text = "Trống";
            this.rbTrong.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trạng thái:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(225, 142);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(327, 34);
            this.txtName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên bàn:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(225, 78);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(327, 34);
            this.txtID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã số bàn:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.rbAll);
            this.panel1.Controls.Add(this.rbOccupied);
            this.panel1.Controls.Add(this.rbUnoccupied);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(634, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 52);
            this.panel1.TabIndex = 1;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.rbAll.Location = new System.Drawing.Point(389, 12);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(89, 30);
            this.rbAll.TabIndex = 11;
            this.rbAll.Text = "Tất cả";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbOccupied
            // 
            this.rbOccupied.AutoSize = true;
            this.rbOccupied.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.rbOccupied.Location = new System.Drawing.Point(210, 12);
            this.rbOccupied.Name = "rbOccupied";
            this.rbOccupied.Size = new System.Drawing.Size(126, 30);
            this.rbOccupied.TabIndex = 10;
            this.rbOccupied.Text = "Có Khách";
            this.rbOccupied.UseVisualStyleBackColor = true;
            this.rbOccupied.CheckedChanged += new System.EventHandler(this.rbOccupied_CheckedChanged);
            // 
            // rbUnoccupied
            // 
            this.rbUnoccupied.AutoSize = true;
            this.rbUnoccupied.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.rbUnoccupied.Location = new System.Drawing.Point(70, 12);
            this.rbUnoccupied.Name = "rbUnoccupied";
            this.rbUnoccupied.Size = new System.Drawing.Size(89, 30);
            this.rbUnoccupied.TabIndex = 9;
            this.rbUnoccupied.Text = "Trống";
            this.rbUnoccupied.UseVisualStyleBackColor = true;
            this.rbUnoccupied.CheckedChanged += new System.EventHandler(this.rbUnoccupied_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(634, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 672);
            this.panel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(531, 672);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1165, 724);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "fTableManager";
            this.Text = "Quản Lý bàn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.RadioButton rbCoNguoi;
        private System.Windows.Forms.RadioButton rbTrong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rbOccupied;
        private System.Windows.Forms.RadioButton rbUnoccupied;
        private System.Windows.Forms.RadioButton rbAll;
    }
}