namespace libraryControlSystem2.UI
{
    partial class DashboardForm
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
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.lblBorrowed = new System.Windows.Forms.Label();
            this.lblDueSoon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalBooks
            // 
            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.Location = new System.Drawing.Point(12, 9);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(100, 16);
            this.lblTotalBooks.TabIndex = 0;
            this.lblTotalBooks.Text = "Toplam Kitap: 0";
            // 
            // lblBorrowed
            // 
            this.lblBorrowed.AutoSize = true;
            this.lblBorrowed.Location = new System.Drawing.Point(12, 42);
            this.lblBorrowed.Name = "lblBorrowed";
            this.lblBorrowed.Size = new System.Drawing.Size(70, 16);
            this.lblBorrowed.TabIndex = 1;
            this.lblBorrowed.Text = "Ödünçte: 0";
            // 
            // lblDueSoon
            // 
            this.lblDueSoon.AutoSize = true;
            this.lblDueSoon.Location = new System.Drawing.Point(12, 78);
            this.lblDueSoon.Name = "lblDueSoon";
            this.lblDueSoon.Size = new System.Drawing.Size(117, 16);
            this.lblDueSoon.TabIndex = 2;
            this.lblDueSoon.Text = "İadesi Yaklaşan: 0";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDueSoon);
            this.Controls.Add(this.lblBorrowed);
            this.Controls.Add(this.lblTotalBooks);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Label lblBorrowed;
        private System.Windows.Forms.Label lblDueSoon;
    }
}