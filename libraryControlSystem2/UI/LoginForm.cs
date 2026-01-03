using System;
using System.Windows.Forms;
using libraryControlSystem2.DAL;
using MySql.Data.MySqlClient;
using libraryControlSystem2.UI;



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
            BookForm bookForm = new BookForm();
            bookForm.Show();
            this.Hide();


        }
    }
}
