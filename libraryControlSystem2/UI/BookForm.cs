using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libraryControlSystem2.BLL;
using libraryControlSystem2.DAL;


namespace libraryControlSystem2.UI
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buton çalıştı");

            BookBLL bookBLL = new BookBLL();

            bookBLL.AddBook(
                txtISBN.Text,
                txtTitle.Text,
                txtAuthor.Text,
                txtPublisher.Text,
                txtYear.Text,
                txtStock.Text
            );
            dgvBooks.DataSource = bookBLL.GetAllBooks();

            MessageBox.Show("Kitap başarıyla eklendi ");
        }

        private void btnListBooks_Click(object sender, EventArgs e)
        {
            BookBLL bookBLL = new BookBLL();
            dgvBooks.DataSource = bookBLL.GetAllBooks();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek kitabı seçin.");
                return;
            }

            int selectedId = Convert.ToInt32(
                dgvBooks.SelectedRows[0].Cells[0].Value
            );

            BookBLL bookBLL = new BookBLL();
            bookBLL.DeleteBook(selectedId);

            MessageBox.Show("Kitap silindi.");

            dgvBooks.DataSource = bookBLL.GetAllBooks();
        }

    }
}
