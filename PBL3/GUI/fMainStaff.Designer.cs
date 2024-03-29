﻿namespace PBL3.GUI
{
    partial class fMainStaff
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
            this.btLogout = new System.Windows.Forms.Button();
            this.btAccount = new System.Windows.Forms.Button();
            this.btMenu = new System.Windows.Forms.Button();
            this.btTable = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPosition = new System.Windows.Forms.Label();
            this.lbNameAccount = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lbNotify = new System.Windows.Forms.Label();
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
            this.panelMenu.Controls.Add(this.btMenu);
            this.panelMenu.Controls.Add(this.btTable);
            this.panelMenu.Controls.Add(this.btHome);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(260, 903);
            this.panelMenu.TabIndex = 1;
            // 
            // btLogout
            // 
            this.btLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold);
            this.btLogout.Image = global::PBL3.Properties.Resources.logout;
            this.btLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.Location = new System.Drawing.Point(0, 444);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(260, 80);
            this.btLogout.TabIndex = 8;
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
            this.btAccount.Location = new System.Drawing.Point(0, 364);
            this.btAccount.Name = "btAccount";
            this.btAccount.Size = new System.Drawing.Size(260, 80);
            this.btAccount.TabIndex = 7;
            this.btAccount.Text = " Tài khoản";
            this.btAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAccount.UseVisualStyleBackColor = true;
            this.btAccount.Click += new System.EventHandler(this.btAccount_Click);
            // 
            // btMenu
            // 
            this.btMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenu.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold);
            this.btMenu.Image = global::PBL3.Properties.Resources.list;
            this.btMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMenu.Location = new System.Drawing.Point(0, 284);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(260, 80);
            this.btMenu.TabIndex = 3;
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
            this.btTable.Location = new System.Drawing.Point(0, 204);
            this.btTable.Name = "btTable";
            this.btTable.Size = new System.Drawing.Size(260, 80);
            this.btTable.TabIndex = 2;
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
            this.btHome.Location = new System.Drawing.Point(0, 124);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(260, 80);
            this.btHome.TabIndex = 1;
            this.btHome.Text = " Home";
            this.btHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(109)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.lbPosition);
            this.panel1.Controls.Add(this.lbNameAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 124);
            this.panel1.TabIndex = 0;
            // 
            // lbPosition
            // 
            this.lbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.Location = new System.Drawing.Point(0, 76);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(260, 20);
            this.lbPosition.TabIndex = 3;
            this.lbPosition.Text = "<Nhân viên>";
            this.lbPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNameAccount
            // 
            this.lbNameAccount.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameAccount.Location = new System.Drawing.Point(0, 28);
            this.lbNameAccount.Name = "lbNameAccount";
            this.lbNameAccount.Size = new System.Drawing.Size(260, 29);
            this.lbNameAccount.TabIndex = 2;
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
            this.panelTitle.Size = new System.Drawing.Size(1341, 124);
            this.panelTitle.TabIndex = 2;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1341, 124);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Hệ thống quản lý quán cafe";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.panelForm.Controls.Add(this.lbNotify);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(260, 124);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1341, 779);
            this.panelForm.TabIndex = 3;
            // 
            // lbNotify
            // 
            this.lbNotify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNotify.Font = new System.Drawing.Font("Lucida Handwriting", 28F, System.Drawing.FontStyle.Bold);
            this.lbNotify.Image = global::PBL3.Properties.Resources.HNT;
            this.lbNotify.Location = new System.Drawing.Point(0, 0);
            this.lbNotify.Name = "lbNotify";
            this.lbNotify.Size = new System.Drawing.Size(1341, 779);
            this.lbNotify.TabIndex = 1;
            this.lbNotify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fMainStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 903);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "fMainStaff";
            this.Text = "Coffee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMainStaff_FormClosing);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btAccount;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Button btTable;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label lbNameAccount;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbNotify;
    }
}