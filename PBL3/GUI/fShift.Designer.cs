namespace PBL3.GUI
{
    partial class fShift
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
            this.end = new System.Windows.Forms.DateTimePicker();
            this.start = new System.Windows.Forms.DateTimePicker();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.txtidAccount = new System.Windows.Forms.TextBox();
            this.txtidShift = new System.Windows.Forms.TextBox();
            this.BtDel = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.dgvShift = new System.Windows.Forms.DataGridView();
            this.TimeEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.end);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.txtDisplayName);
            this.panel1.Controls.Add(this.txtidAccount);
            this.panel1.Controls.Add(this.txtidShift);
            this.panel1.Controls.Add(this.BtDel);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 740);
            this.panel1.TabIndex = 0;
            // 
            // end
            // 
            this.end.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.end.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.end.Location = new System.Drawing.Point(183, 310);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(327, 34);
            this.end.TabIndex = 51;
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.start.Location = new System.Drawing.Point(183, 247);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(327, 34);
            this.start.TabIndex = 50;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtDisplayName.Location = new System.Drawing.Point(183, 191);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(327, 34);
            this.txtDisplayName.TabIndex = 49;
            // 
            // txtidAccount
            // 
            this.txtidAccount.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtidAccount.Location = new System.Drawing.Point(183, 127);
            this.txtidAccount.Name = "txtidAccount";
            this.txtidAccount.Size = new System.Drawing.Size(327, 34);
            this.txtidAccount.TabIndex = 46;
            // 
            // txtidShift
            // 
            this.txtidShift.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtidShift.Location = new System.Drawing.Point(183, 70);
            this.txtidShift.Name = "txtidShift";
            this.txtidShift.Size = new System.Drawing.Size(327, 34);
            this.txtidShift.TabIndex = 45;
            // 
            // BtDel
            // 
            this.BtDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.BtDel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.BtDel.ForeColor = System.Drawing.Color.Black;
            this.BtDel.Location = new System.Drawing.Point(355, 382);
            this.BtDel.Name = "BtDel";
            this.BtDel.Size = new System.Drawing.Size(122, 47);
            this.BtDel.TabIndex = 44;
            this.BtDel.Text = "Xóa";
            this.BtDel.UseVisualStyleBackColor = false;
            this.BtDel.Click += new System.EventHandler(this.BtDel_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btEdit.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btEdit.ForeColor = System.Drawing.Color.Black;
            this.btEdit.Location = new System.Drawing.Point(195, 382);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(122, 47);
            this.btEdit.TabIndex = 43;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btAdd.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btAdd.ForeColor = System.Drawing.Color.Black;
            this.btAdd.Location = new System.Drawing.Point(32, 382);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(122, 47);
            this.btAdd.TabIndex = 42;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label4.Location = new System.Drawing.Point(27, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 27);
            this.label4.TabIndex = 41;
            this.label4.Text = "Giờ kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label2.Location = new System.Drawing.Point(27, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 27);
            this.label2.TabIndex = 40;
            this.label2.Text = "Giờ bắt đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(27, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 27);
            this.label1.TabIndex = 39;
            this.label1.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label3.Location = new System.Drawing.Point(27, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 27);
            this.label3.TabIndex = 38;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label6.Location = new System.Drawing.Point(27, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 36;
            this.label6.Text = "Mã ca";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btSearch);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(566, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 743);
            this.panel2.TabIndex = 1;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btSearch.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btSearch.ForeColor = System.Drawing.Color.Black;
            this.btSearch.Location = new System.Drawing.Point(37, 17);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(122, 47);
            this.btSearch.TabIndex = 48;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtSearch.Location = new System.Drawing.Point(211, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(327, 34);
            this.txtSearch.TabIndex = 46;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // dgvShift
            // 
            this.dgvShift.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShift.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idShift,
            this.idAccount,
            this.DisplayName,
            this.TimeStart,
            this.TimeEnd});
            this.dgvShift.Location = new System.Drawing.Point(0, 3);
            this.dgvShift.Name = "dgvShift";
            this.dgvShift.RowHeadersWidth = 51;
            this.dgvShift.RowTemplate.Height = 24;
            this.dgvShift.Size = new System.Drawing.Size(623, 670);
            this.dgvShift.TabIndex = 0;
            this.dgvShift.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvShift_RowHeaderMouseClick);
            // 
            // TimeEnd
            // 
            this.TimeEnd.DataPropertyName = "TimeEnd";
            this.TimeEnd.HeaderText = "Giờ kết thúc";
            this.TimeEnd.MinimumWidth = 6;
            this.TimeEnd.Name = "TimeEnd";
            this.TimeEnd.Width = 125;
            // 
            // TimeStart
            // 
            this.TimeStart.DataPropertyName = "TimeStart";
            this.TimeStart.HeaderText = "Giờ bắt đầu";
            this.TimeStart.MinimumWidth = 6;
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.Width = 125;
            // 
            // DisplayName
            // 
            this.DisplayName.DataPropertyName = "DisplayName";
            this.DisplayName.HeaderText = "Tên nhân viên";
            this.DisplayName.MinimumWidth = 6;
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.Width = 125;
            // 
            // idAccount
            // 
            this.idAccount.DataPropertyName = "idAccount";
            this.idAccount.HeaderText = "Mã nhân viên";
            this.idAccount.MinimumWidth = 6;
            this.idAccount.Name = "idAccount";
            this.idAccount.Width = 125;
            // 
            // idShift
            // 
            this.idShift.DataPropertyName = "idShift";
            this.idShift.HeaderText = "Mã ca";
            this.idShift.MinimumWidth = 6;
            this.idShift.Name = "idShift";
            this.idShift.Width = 125;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvShift);
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(616, 673);
            this.panel3.TabIndex = 47;
            // 
            // fShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1186, 745);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fShift";
            this.Text = "Quản lý ca làm việc";
           
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtDel;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.TextBox txtidAccount;
        private System.Windows.Forms.TextBox txtidShift;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker end;
        private System.Windows.Forms.DateTimePicker start;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn idShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeEnd;
    }
}