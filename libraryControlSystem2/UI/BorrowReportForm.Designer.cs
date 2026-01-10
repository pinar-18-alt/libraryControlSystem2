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
            this.dgvLateBorrows = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMostBorrowed = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvActiveMembers = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueSoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLateBorrows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostBorrowed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDueSoon
            // 
            this.dgvDueSoon.AllowUserToAddRows = false;
            this.dgvDueSoon.AllowUserToDeleteRows = false;
            this.dgvDueSoon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDueSoon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDueSoon.Location = new System.Drawing.Point(24, 59);
            this.dgvDueSoon.MultiSelect = false;
            this.dgvDueSoon.Name = "dgvDueSoon";
            this.dgvDueSoon.ReadOnly = true;
            this.dgvDueSoon.RowHeadersWidth = 51;
            this.dgvDueSoon.RowTemplate.Height = 24;
            this.dgvDueSoon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDueSoon.Size = new System.Drawing.Size(407, 229);
            this.dgvDueSoon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(88, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "İade Tarihi Yaklaşan Kitaplar";
            // 
            // dgvLateBorrows
            // 
            this.dgvLateBorrows.AllowUserToAddRows = false;
            this.dgvLateBorrows.AllowUserToDeleteRows = false;
            this.dgvLateBorrows.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLateBorrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLateBorrows.Location = new System.Drawing.Point(24, 380);
            this.dgvLateBorrows.MultiSelect = false;
            this.dgvLateBorrows.Name = "dgvLateBorrows";
            this.dgvLateBorrows.ReadOnly = true;
            this.dgvLateBorrows.RowHeadersWidth = 51;
            this.dgvLateBorrows.RowTemplate.Height = 24;
            this.dgvLateBorrows.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLateBorrows.Size = new System.Drawing.Size(407, 211);
            this.dgvLateBorrows.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(109, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Geç Kalan Kitaplar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvMostBorrowed
            // 
            this.dgvMostBorrowed.AllowUserToAddRows = false;
            this.dgvMostBorrowed.AllowUserToDeleteRows = false;
            this.dgvMostBorrowed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostBorrowed.Location = new System.Drawing.Point(463, 59);
            this.dgvMostBorrowed.MultiSelect = false;
            this.dgvMostBorrowed.Name = "dgvMostBorrowed";
            this.dgvMostBorrowed.ReadOnly = true;
            this.dgvMostBorrowed.RowHeadersWidth = 51;
            this.dgvMostBorrowed.RowTemplate.Height = 24;
            this.dgvMostBorrowed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostBorrowed.Size = new System.Drawing.Size(407, 229);
            this.dgvMostBorrowed.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(538, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "En Çok Ödünç Alınan Kitaplar";
            // 
            // dgvActiveMembers
            // 
            this.dgvActiveMembers.AllowUserToAddRows = false;
            this.dgvActiveMembers.AllowUserToDeleteRows = false;
            this.dgvActiveMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActiveMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveMembers.Location = new System.Drawing.Point(463, 380);
            this.dgvActiveMembers.MultiSelect = false;
            this.dgvActiveMembers.Name = "dgvActiveMembers";
            this.dgvActiveMembers.ReadOnly = true;
            this.dgvActiveMembers.RowHeadersWidth = 51;
            this.dgvActiveMembers.RowTemplate.Height = 24;
            this.dgvActiveMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActiveMembers.Size = new System.Drawing.Size(407, 211);
            this.dgvActiveMembers.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(613, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Aktif Üyeler";
            // 
            // BorrowReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::libraryControlSystem2.Properties.Resources.Gemini_Generated_Image_6a9d6z6a9d6z6a9d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvActiveMembers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMostBorrowed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLateBorrows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDueSoon);
            this.Name = "BorrowReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BorrowReportForm";
            this.Load += new System.EventHandler(this.BorrowReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueSoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLateBorrows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostBorrowed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDueSoon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLateBorrows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMostBorrowed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvActiveMembers;
        private System.Windows.Forms.Label label4;
    }
}