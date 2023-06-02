namespace PBL3.GUI
{
    partial class DetailBill
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
            this.dgvdetailbill = new System.Windows.Forms.DataGridView();
            this.IdFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetailbill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdetailbill
            // 
            this.dgvdetailbill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvdetailbill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(182)))));
            this.dgvdetailbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetailbill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFood,
            this.NameFood,
            this.billquantity,
            this.price,
            this.totalprice});
            this.dgvdetailbill.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvdetailbill.Location = new System.Drawing.Point(-6, 1);
            this.dgvdetailbill.MaximumSize = new System.Drawing.Size(799, 452);
            this.dgvdetailbill.Name = "dgvdetailbill";
            this.dgvdetailbill.RowHeadersWidth = 51;
            this.dgvdetailbill.RowTemplate.Height = 24;
            this.dgvdetailbill.Size = new System.Drawing.Size(691, 452);
            this.dgvdetailbill.TabIndex = 0;
            // 
            // IdFood
            // 
            this.IdFood.DataPropertyName = "IdFood";
            this.IdFood.HeaderText = "ID";
            this.IdFood.MinimumWidth = 6;
            this.IdFood.Name = "IdFood";
            this.IdFood.Width = 125;
            // 
            // NameFood
            // 
            this.NameFood.DataPropertyName = "NameFood";
            this.NameFood.HeaderText = "Đồ uống";
            this.NameFood.MinimumWidth = 6;
            this.NameFood.Name = "NameFood";
            this.NameFood.ReadOnly = true;
            this.NameFood.Width = 125;
            // 
            // billquantity
            // 
            this.billquantity.DataPropertyName = "billquantity";
            this.billquantity.HeaderText = "Số lượng";
            this.billquantity.MinimumWidth = 6;
            this.billquantity.Name = "billquantity";
            this.billquantity.ReadOnly = true;
            this.billquantity.Width = 125;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Giá tiền";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 125;
            // 
            // totalprice
            // 
            this.totalprice.HeaderText = "Tổng tiền";
            this.totalprice.MinimumWidth = 6;
            this.totalprice.Name = "totalprice";
            this.totalprice.ReadOnly = true;
            this.totalprice.Width = 125;
            // 
            // DetailBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.dgvdetailbill);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailBill";
            this.Text = "DetailBill";
            this.Load += new System.EventHandler(this.DetailBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetailbill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdetailbill;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn billquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalprice;
    }
}