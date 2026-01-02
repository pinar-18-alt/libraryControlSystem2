namespace libraryControlSystem2.UI
{
    partial class BorrowReportForm
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
            this.dgvDueSoon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturnBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueSoon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDueSoon
            // 
            this.dgvDueSoon.AllowUserToAddRows = false;
            this.dgvDueSoon.AllowUserToDeleteRows = false;
            this.dgvDueSoon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDueSoon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDueSoon.Location = new System.Drawing.Point(12, 65);
            this.dgvDueSoon.MultiSelect = false;
            this.dgvDueSoon.Name = "dgvDueSoon";
            this.dgvDueSoon.ReadOnly = true;
            this.dgvDueSoon.RowHeadersWidth = 51;
            this.dgvDueSoon.RowTemplate.Height = 24;
            this.dgvDueSoon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDueSoon.Size = new System.Drawing.Size(387, 229);
            this.dgvDueSoon.TabIndex = 0;
            this.dgvDueSoon.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvDueSoon_RowPrePaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "İade Tarihi Yaklaşan Kitaplar";
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(429, 65);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(116, 50);
            this.btnReturnBook.TabIndex = 2;
            this.btnReturnBook.Text = "Kitabı İade Et";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // BorrowReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDueSoon);
            this.Name = "BorrowReportForm";
            this.Text = "BorrowReportForm";
            this.Load += new System.EventHandler(this.BorrowReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueSoon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDueSoon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturnBook;
    }
}