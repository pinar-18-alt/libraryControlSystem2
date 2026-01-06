using libraryControlSystem2.BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace libraryControlSystem2.UI
{
    public partial class BorrowReportForm : Form
    {
        private string _userRole;

        public BorrowReportForm(string role)
        {
            InitializeComponent();
            _userRole = role;
        }

        private void BorrowReportForm_Load(object sender, EventArgs e)
        {
            if (_userRole != "Admin")
            {
                MessageBox.Show("Bu sayfaya erişim yetkiniz yok.");
                this.Close();
                return;
            }

            BorrowBLL borrowBLL = new BorrowBLL();

            dgvDueSoon.DataSource = borrowBLL.GetDueSoonBorrows();
            dgvDueSoon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDueSoon.ReadOnly = true;

            dgvLateBorrows.DataSource = borrowBLL.GetLateBorrows();
            dgvLateBorrows.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLateBorrows.ReadOnly = true;

            dgvMostBorrowed.DataSource = borrowBLL.GetMostBorrowedBooks();
            dgvMostBorrowed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMostBorrowed.ReadOnly = true;

            if (dgvMostBorrowed.Rows.Count > 0)
                dgvMostBorrowed.Rows[0].DefaultCellStyle.BackColor = Color.LightGreen;

            dgvActiveMembers.DataSource = borrowBLL.GetActiveMembers();
            dgvActiveMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActiveMembers.ReadOnly = true;

            if (dgvActiveMembers.Rows.Count > 0)
                dgvActiveMembers.Rows[0].DefaultCellStyle.BackColor = Color.LightGreen;
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (dgvDueSoon.SelectedRows.Count == 0)
            {
                MessageBox.Show("İade edilecek kaydı seçin.");
                return;
            }

            int borrowId = Convert.ToInt32(
                dgvDueSoon.SelectedRows[0].Cells["BorrowID"].Value
            );

            BorrowBLL bll = new BorrowBLL();
            bll.ReturnBook(borrowId);

            MessageBox.Show("Kitap iade edildi.");

            dgvDueSoon.DataSource = bll.GetDueSoonBorrows();
            dgvLateBorrows.DataSource = bll.GetLateBorrows();
        }

        
    }
}
