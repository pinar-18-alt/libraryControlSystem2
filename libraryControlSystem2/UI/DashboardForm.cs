using System;
using System.Windows.Forms;
using System.Drawing;


namespace libraryControlSystem2.UI
{
    public partial class DashboardForm : Form
    {
        private string _userRole;

        public DashboardForm(string role)
        {
            InitializeComponent();
            _userRole = role.Trim();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            ApplyRolePermissions();
        }

        private void ApplyRolePermissions()
        {
            // 🔒 Admin olmayan RAPORLARI GÖREMEZ
            if (_userRole != "Admin")
            {
                btnReports.Visible = false;
            }
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            BookForm form = new BookForm(_userRole);

            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(
                this.Location.X + (this.Width - form.Width) / 2,
                this.Location.Y + (this.Height - form.Height) / 2
            );

            form.Show();
        }


        private void btnMembers_Click(object sender, EventArgs e)
        {
            MemberForm form = new MemberForm(_userRole);

            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(
                this.Location.X + (this.Width - form.Width) / 2,
                this.Location.Y + (this.Height - form.Height) / 2
            );

            form.Show();
        }


        private void btnBorrow_Click(object sender, EventArgs e)
        {
            BorrowForm form = new BorrowForm();

            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(
                this.Location.X + (this.Width - form.Width) / 2,
                this.Location.Y + (this.Height - form.Height) / 2
            );

            form.Show();
        }


        private void btnReports_Click(object sender, EventArgs e)
        {
            if (_userRole != "Admin")
            {
                MessageBox.Show("Bu sayfaya erişim yetkiniz yok.");
                return;
            }

            BorrowReportForm form = new BorrowReportForm(_userRole);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(
                this.Location.X + (this.Width - form.Width) / 2,
                this.Location.Y + (this.Height - form.Height) / 2
            );
            form.Show();
        }
    }
}
