namespace libraryControlSystem2.UI
{
    partial class BorrowReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvDueSoon;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvDueSoon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueSoon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDueSoon
            // 
            this.dgvDueSoon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDueSoon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDueSoon.Location = new System.Drawing.Point(0, 0);
            this.dgvDueSoon.Name = "dgvDueSoon";
            this.dgvDueSoon.RowHeadersWidth = 51;
            this.dgvDueSoon.Size = new System.Drawing.Size(800, 450);
            this.dgvDueSoon.TabIndex = 0;
            this.dgvDueSoon.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvDueSoon_RowPrePaint);
            // 
            // BorrowReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDueSoon);
            this.Name = "BorrowReportForm";
            this.Text = "İade Tarihi Yaklaşan Kitaplar";
            this.Load += new System.EventHandler(this.BorrowReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueSoon)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
