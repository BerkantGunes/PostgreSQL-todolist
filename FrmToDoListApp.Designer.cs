namespace Project10_PostgreSQLToDoListApp
{
    partial class FrmToDoListApp
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
            this.DGVList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVList)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVList
            // 
            this.DGVList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVList.Location = new System.Drawing.Point(75, 72);
            this.DGVList.Name = "DGVList";
            this.DGVList.RowHeadersWidth = 51;
            this.DGVList.RowTemplate.Height = 24;
            this.DGVList.Size = new System.Drawing.Size(846, 356);
            this.DGVList.TabIndex = 0;
            // 
            // FrmToDoListApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 460);
            this.Controls.Add(this.DGVList);
            this.Name = "FrmToDoListApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmToDoListApp";
            this.Load += new System.EventHandler(this.FrmToDoListApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVList;
    }
}