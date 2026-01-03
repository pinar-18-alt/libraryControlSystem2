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
            this.lblActiveBorrows = new System.Windows.Forms.Label();
            this.lblTotalMembers = new System.Windows.Forms.Label();
            this.lblLateBorrows = new System.Windows.Forms.Label();
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
            // lblActiveBorrows
            // 
            this.lblActiveBorrows.AutoSize = true;
            this.lblActiveBorrows.Location = new System.Drawing.Point(12, 42);
            this.lblActiveBorrows.Name = "lblActiveBorrows";
            this.lblActiveBorrows.Size = new System.Drawing.Size(70, 16);
            this.lblActiveBorrows.TabIndex = 1;
            this.lblActiveBorrows.Text = "Ödünçte: 0";
            // 
            // lblTotalMembers
            // 
            this.lblTotalMembers.AutoSize = true;
            this.lblTotalMembers.Location = new System.Drawing.Point(12, 78);
            this.lblTotalMembers.Name = "lblTotalMembers";
            this.lblTotalMembers.Size = new System.Drawing.Size(85, 16);
            this.lblTotalMembers.TabIndex = 2;
            this.lblTotalMembers.Text = "Toplam Üye:";
            // 
            // lblLateBorrows
            // 
            this.lblLateBorrows.AutoSize = true;
            this.lblLateBorrows.Location = new System.Drawing.Point(12, 108);
            this.lblLateBorrows.Name = "lblLateBorrows";
            this.lblLateBorrows.Size = new System.Drawing.Size(75, 16);
            this.lblLateBorrows.TabIndex = 3;
            this.lblLateBorrows.Text = "Gecikenler:";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLateBorrows);
            this.Controls.Add(this.lblTotalMembers);
            this.Controls.Add(this.lblActiveBorrows);
            this.Controls.Add(this.lblTotalBooks);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
       
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Label lblActiveBorrows;
        private System.Windows.Forms.Label lblTotalMembers;
        private System.Windows.Forms.Label lblLateBorrows;
    }
}