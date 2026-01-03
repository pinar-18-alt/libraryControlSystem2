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

            lblTotalBooks.Text = bll.TotalBooks().ToString();
            lblTotalMembers.Text = bll.TotalMembers().ToString();
            lblActiveBorrows.Text = bll.ActiveBorrows().ToString();
            lblLateBorrows.Text = bll.LateBorrows().ToString();
        }

    }
}

