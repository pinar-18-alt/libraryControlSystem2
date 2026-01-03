using libraryControlSystem2.BLL;
using System;
using System.Windows.Forms;

namespace libraryControlSystem2.UI
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            DashboardBLL bll = new DashboardBLL();

            lblTotalBooks.Text = "Toplam Kitap: " + bll.TotalBooks();
            lblBorrowed.Text = "Ödünçte: " + bll.BorrowedBooks();
            lblDueSoon.Text = "İadesi Yaklaşan: " + bll.DueSoonBooks();
        }

        private void DashboardForm_Load_1(object sender, EventArgs e)
        {
            DashboardBLL bll = new DashboardBLL();

            lblTotalBooks.Text = "Toplam Kitap: " + bll.TotalBooks();
            lblBorrowed.Text = "Ödünçte: " + bll.BorrowedBooks();
            lblDueSoon.Text = "İadesi Yaklaşan: " + bll.DueSoonBooks();

        }
    }
}
