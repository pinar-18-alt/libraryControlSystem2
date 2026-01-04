namespace libraryControlSystem2.UI
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnBooks
            this.btnBooks.Location = new System.Drawing.Point(148, 95);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(107, 120);
            this.btnBooks.Text = "Kitap İşlemleri";
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);

            // btnMembers
            this.btnMembers.Location = new System.Drawing.Point(344, 95);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(107, 120);
            this.btnMembers.Text = "Üye İşlemleri";
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);

            // btnBorrow
            this.btnBorrow.Location = new System.Drawing.Point(539, 95);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(107, 120);
            this.btnBorrow.Text = "Ödünç / İade";
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);

            // btnReports
            this.btnReports.Location = new System.Drawing.Point(344, 280);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(107, 120);
            this.btnReports.Text = "Raporlar";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);

            // DashboardForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.btnBooks);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReports;
    }
}
