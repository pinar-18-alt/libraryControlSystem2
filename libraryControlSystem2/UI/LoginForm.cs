using System;
using System.Drawing;
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

               
                string role = dt.Rows[0]["Role"].ToString().Trim();

                
                DashboardForm dashboard = new DashboardForm(role);
                dashboard.Show();

               
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(52, 152, 219);
            btnLogin.ForeColor = Color.White;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(41, 128, 185);
            btnLogin.ForeColor = Color.WhiteSmoke;
        }
    }
}
