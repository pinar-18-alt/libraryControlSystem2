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

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                DbConnection db = new DbConnection();
                MySqlConnection conn = db.OpenConnection();

                MessageBox.Show("MySQL bağlantısı başarılı");

                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.Show();
            this.Hide();


        }
    }
}
