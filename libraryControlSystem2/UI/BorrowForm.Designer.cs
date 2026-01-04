namespace libraryControlSystem2.UI
{
    partial class BorrowForm
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
            this.cmbMembers = new System.Windows.Forms.ComboBox();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvBorrows = new System.Windows.Forms.DataGridView();
            this.dgvLateBorrows = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLateBorrows)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMembers
            // 
            this.cmbMembers.FormattingEnabled = true;
            this.cmbMembers.Location = new System.Drawing.Point(121, 129);
            this.cmbMembers.Name = "cmbMembers";
            this.cmbMembers.Size = new System.Drawing.Size(203, 24);
            this.cmbMembers.TabIndex = 0;
            // 
            // cmbBooks
            // 
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(121, 207);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(203, 24);
            this.cmbBooks.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Üye seç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap seç";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(51, 295);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDueDate.TabIndex = 4;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(35, 373);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(81, 36);
            this.btnBorrow.TabIndex = 5;
            this.btnBorrow.Text = "Ödünç Ver";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(151, 373);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 36);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "İade Al";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // dgvBorrows
            // 
            this.dgvBorrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrows.Location = new System.Drawing.Point(357, 110);
            this.dgvBorrows.Name = "dgvBorrows";
            this.dgvBorrows.RowHeadersWidth = 51;
            this.dgvBorrows.RowTemplate.Height = 24;
            this.dgvBorrows.Size = new System.Drawing.Size(374, 348);
            this.dgvBorrows.TabIndex = 7;
            // 
            // dgvLateBorrows
            // 
            this.dgvLateBorrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLateBorrows.Location = new System.Drawing.Point(818, 110);
            this.dgvLateBorrows.Name = "dgvLateBorrows";
            this.dgvLateBorrows.RowHeadersWidth = 51;
            this.dgvLateBorrows.RowTemplate.Height = 24;
            this.dgvLateBorrows.Size = new System.Drawing.Size(386, 348);
            this.dgvLateBorrows.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(928, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Geciken Kitaplar";
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 511);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvLateBorrows);
            this.Controls.Add(this.dgvBorrows);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBooks);
            this.Controls.Add(this.cmbMembers);
            this.Name = "BorrowForm";
            this.Text = "BorrowForm";
            this.Load += new System.EventHandler(this.BorrowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLateBorrows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMembers;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvBorrows;
        private System.Windows.Forms.DataGridView dgvLateBorrows;
        private System.Windows.Forms.Label label3;
    }
}