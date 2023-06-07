namespace PBL3
{
    partial class fMainAdmin
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPosition = new System.Windows.Forms.Label();
            this.lbNameAccount = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lbNotify = new System.Windows.Forms.Label();
            this.btLogout = new System.Windows.Forms.Button();
            this.btAccount = new System.Windows.Forms.Button();
            this.btCa = new System.Windows.Forms.Button();
            this.btStatistic = new System.Windows.Forms.Button();
            this.btBill = new System.Windows.Forms.Button();
            this.btStaff = new System.Windows.Forms.Button();
            this.btMenu = new System.Windows.Forms.Button();
            this.btTable = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.panelMenu.Controls.Add(this.btLogout);
            this.panelMenu.Controls.Add(this.btAccount);
            this.panelMenu.Controls.Add(this.btCa);
            this.panelMenu.Controls.Add(this.btStatistic);
            this.panelMenu.Controls.Add(this.btBill);
            this.panelMenu.Controls.Add(this.btStaff);
            this.panelMenu.Controls.Add(this.btMenu);
            this.panelMenu.Controls.Add(this.btTable);
            this.panelMenu.Controls.Add(this.btHome);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(260, 903);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.lbPosition);
            this.panel1.Controls.Add(this.lbNameAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 90);
            this.panel1.TabIndex = 0;
            // 
            // lbPosition
            // 
            this.lbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.Location = new System.Drawing.Point(0, 51);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(260, 20);
            this.lbPosition.TabIndex = 1;
            this.lbPosition.Text = "<Quản lý>";
            this.lbPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNameAccount
            // 
            this.lbNameAccount.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameAccount.Location = new System.Drawing.Point(0, 9);
            this.lbNameAccount.Name = "lbNameAccount";
            this.lbNameAccount.Size = new System.Drawing.Size(260, 29);
            this.lbNameAccount.TabIndex = 0;
            this.lbNameAccount.Text = "label1";
            this.lbNameAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.panelTitle.Controls.Add(this.lbTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(260, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1341, 90);
            this.panelTitle.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1341, 90);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Hệ thống quản lý quán cafe";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.panelForm.Controls.Add(this.lbNotify);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(260, 90);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1341, 813);
            this.panelForm.TabIndex = 2;
            // 
            // lbNotify
            // 
            this.lbNotify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNotify.Font = new System.Drawing.Font("Lucida Handwriting", 28F, System.Drawing.FontStyle.Bold);
            this.lbNotify.Image = global::PBL3.Properties.Resources.HNT;
            this.lbNotify.Location = new System.Drawing.Point(0, 0);
            this.lbNotify.Name = "lbNotify";
            this.lbNotify.Size = new System.Drawing.Size(1341, 813);
            this.lbNotify.TabIndex = 0;
            this.lbNotify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btLogout
            // 
            this.btLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold);
            this.btLogout.Image = global::PBL3.Properties.Resources.logout;
            this.btLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.Location = new System.Drawing.Point(0, 730);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(260, 80);
            this.btLogout.TabIndex = 25;
            this.btLogout.Text = " Đăng xuất";
            this.btLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btAccount
            // 
            this.btAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAccount.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold);
            this.btAccount.Image = global::PBL3.Properties.Resources.user;
            this.btAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAccount.Location = new System.Drawing.Point(0, 650);
            this.btAccount.Name = "btAccount";
            this.btAccount.Size = new System.Drawing.Size(260, 80);
            this.btAccount.TabIndex = 24;
            this.btAccount.Text = " Tài khoản";
            this.btAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAccount.UseVisualStyleBackColor = true;
            this.btAccount.Click += new System.EventHandler(this.btAccount_Click);
            // 
            // btCa
            // 
            this.btCa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCa.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold);
            this.btCa.Image = global::PBL3.Properties.Resources.shift;
            this.btCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCa.Location = new System.Drawing.Point(0, 570);
            this.btCa.Name = "btCa";
            this.btCa.Size = new System.Drawing.Size(260, 80);
            this.btCa.TabIndex = 23;
            this.btCa.Text = "Ca làm";
            this.btCa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCa.UseVisualStyleBackColor = true;
            this.btCa.Click += new System.EventHandler(this.btCa_Click);
            // 
            // btStatistic
            // 
            this.btStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btStatistic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStatistic.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold);
            this.btStatistic.Image = global::PBL3.Properties.Resources.trend;
            this.btStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btStatistic.Location = new System.Drawing.Point(0, 490);
            this.btStatistic.Name = "btStatistic";
            this.btStatistic.Size = new System.Drawing.Size(260, 80);
            this.btStatistic.TabIndex = 22;
            this.btStatistic.Text = "Thống kê";
            this.btStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btStatistic.UseVisualStyleBackColor = true;
            this.btStatistic.Click += new System.EventHandler(this.btStatistic_Click);
            // 
            // btBill
            // 
            this.btBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btBill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBill.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold);
            this.btBill.Image = global::PBL3.Properties.Resources.bill;
            this.btBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBill.Location = new System.Drawing.Point(0, 410);
            this.btBill.Name = "btBill";
            this.btBill.Size = new System.Drawing.Size(260, 80);
            this.btBill.TabIndex = 14;
            this.btBill.Text = " Hóa đơn bán ra";
            this.btBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBill.UseVisualStyleBackColor = true;
            this.btBill.Click += new System.EventHandler(this.btBill_Click);
            // 
            // btStaff
            // 
            this.btStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btStaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStaff.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold);
            this.btStaff.Image = global::PBL3.Properties.Resources.team;
            this.btStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btStaff.Location = new System.Drawing.Point(0, 330);
            this.btStaff.Name = "btStaff";
            this.btStaff.Size = new System.Drawing.Size(260, 80);
            this.btStaff.TabIndex = 13;
            this.btStaff.Text = " Nhân viên";
            this.btStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btStaff.UseVisualStyleBackColor = true;
            this.btStaff.Click += new System.EventHandler(this.btStaff_Click);
            // 
            // btMenu
            // 
            this.btMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenu.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold);
            this.btMenu.Image = global::PBL3.Properties.Resources.list;
            this.btMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMenu.Location = new System.Drawing.Point(0, 250);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(260, 80);
            this.btMenu.TabIndex = 12;
            this.btMenu.Text = " Đồ uống";
            this.btMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // btTable
            // 
            this.btTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTable.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold);
            this.btTable.Image = global::PBL3.Properties.Resources.dining_table;
            this.btTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTable.Location = new System.Drawing.Point(0, 170);
            this.btTable.Name = "btTable";
            this.btTable.Size = new System.Drawing.Size(260, 80);
            this.btTable.TabIndex = 11;
            this.btTable.Text = " Bàn";
            this.btTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTable.UseVisualStyleBackColor = true;
            this.btTable.Click += new System.EventHandler(this.btTable_Click);
            // 
            // btHome
            // 
            this.btHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold);
            this.btHome.Image = global::PBL3.Properties.Resources.home;
            this.btHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHome.Location = new System.Drawing.Point(0, 90);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(260, 80);
            this.btHome.TabIndex = 10;
            this.btHome.Text = " Home";
            this.btHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // fMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 903);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "fMainAdmin";
            this.Text = "Coffee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label lbNameAccount;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lbNotify;
        private System.Windows.Forms.Button btBill;
        private System.Windows.Forms.Button btStaff;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Button btTable;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btStatistic;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btAccount;
        private System.Windows.Forms.Button btCa;
    }
}

