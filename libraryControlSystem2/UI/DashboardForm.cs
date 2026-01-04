using libraryControlSystem2.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace libraryControlSystem2.UI
{
    public partial class DashboardForm : Form
    {
        private string _userRole;

        public DashboardForm(string role)
        {
            InitializeComponent();
            _userRole = role;
        }


        private void ApplyRolePermissions()
        {
            if (_userRole == "Staff")
            {
                btnReports.Visible = false;
            }
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {



        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            BookForm form = new BookForm(_userRole);
            form.Show();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            MemberForm form = new MemberForm(_userRole);
            form.Show();
        }


        private void btnBorrow_Click(object sender, EventArgs e)
        {
            BorrowForm form = new BorrowForm();
            form.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            BorrowReportForm form = new BorrowReportForm();
            form.Show();
        }
    }
}

