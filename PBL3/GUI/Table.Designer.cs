namespace PBL3.GUI
{
    partial class Table
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btNameTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btNameTable
            // 
            this.btNameTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btNameTable.Location = new System.Drawing.Point(0, 0);
            this.btNameTable.Name = "btNameTable";
            this.btNameTable.Size = new System.Drawing.Size(150, 150);
            this.btNameTable.TabIndex = 0;
            this.btNameTable.Text = "button1";
            this.btNameTable.UseVisualStyleBackColor = true;
            this.btNameTable.Click += new System.EventHandler(this.btNameTable_Click);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btNameTable);
            this.Name = "Table";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btNameTable;
    }
}
