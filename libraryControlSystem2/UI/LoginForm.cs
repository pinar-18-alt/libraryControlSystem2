using System;
using System.Windows.Forms;
using libraryControlSystem2.BLL;

namespace libraryControlSystem2.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserBLL bll = new UserBLL();
                var dt = bll.Login(
                    txtUsername.Text.Trim(),
                    txtPassword.Text.Trim()
                );

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                    return;
                }

                // 🔹 ROLÜ AL
                string role = dt.Rows[0]["Role"].ToString().Trim();

                // 🔹 DASHBOARD'A GİT
                DashboardForm dashboard = new DashboardForm(role);
                dashboard.Show();

                // 🔹 LOGIN KAPAT
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
