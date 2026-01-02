using System;
using System.Data;
using System.Windows.Forms;
using libraryControlSystem2.BLL;

namespace libraryControlSystem2.UI
{
    public partial class BookForm : Form
    {
        int selectedBookId = 0;

        public BookForm()
        {
            InitializeComponent();
            LoadBooks(); // Form açılır açılmaz listele
        }

        //  KİTAPLARI YÜKLE (RAPORLAMA)
        private void LoadBooks()
        {
            BookBLL bookBLL = new BookBLL();
            dgvBooks.DataSource = bookBLL.GetAllBooks();

            dgvBooks.Columns[0].Visible = false; // BookID gizle
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ReadOnly = true;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //  FORM TEMİZLEME (ADIM 9)
        private void ClearInputs()
        {
            txtISBN.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPublisher.Clear();
            txtYear.Clear();
            txtStock.Clear();

            selectedBookId = 0;
            btnAddBook.Enabled = true;
        }

        //  KİTAP EKLE
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                BookBLL bookBLL = new BookBLL();

                bookBLL.AddBook(
                    txtISBN.Text,
                    txtTitle.Text,
                    txtAuthor.Text,
                    txtPublisher.Text,
                    txtYear.Text,
                    txtStock.Text
                );

                MessageBox.Show("Kitap başarıyla eklendi");

                LoadBooks();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //  KİTAPLARI LİSTELE
        private void btnListBooks_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }

        //  KİTAP SİL
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

            LoadBooks();
            ClearInputs();
        }

        // KİTAP GÜNCELLE
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (selectedBookId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek kitabı seçin.");
                return;
            }

            try
            {
                BookBLL bookBLL = new BookBLL();

                bookBLL.UpdateBook(
                    selectedBookId,
                    txtISBN.Text,
                    txtTitle.Text,
                    txtAuthor.Text,
                    txtPublisher.Text,
                    txtYear.Text,
                    txtStock.Text
                );

                MessageBox.Show("Kitap güncellendi.");

                dgvBooks.DataSource = bookBLL.GetAllBooks();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (selectedBookId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek kitabı seçin.");
                return;
            }

            try
            {
                BookBLL bookBLL = new BookBLL();
                bookBLL.UpdateBook(
                    selectedBookId,
                    txtISBN.Text,
                    txtTitle.Text,
                    txtAuthor.Text,
                    txtPublisher.Text,
                    txtYear.Text,
                    txtStock.Text
                );

                MessageBox.Show("Kitap güncellendi");

                LoadBooks();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //  GRID SATIR SEÇİMİ → TEXTBOX DOLDUR
        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvBooks.Rows[e.RowIndex].Cells[0].Value == null || dgvBooks.Rows[e.RowIndex].Cells[0].Value == DBNull.Value)
            {
                return;
            }
            if (e.RowIndex < 0)
                return;

            selectedBookId = Convert.ToInt32(
                dgvBooks.Rows[e.RowIndex].Cells[0].Value
            );

            txtISBN.Text = dgvBooks.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTitle.Text = dgvBooks.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAuthor.Text = dgvBooks.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPublisher.Text = dgvBooks.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtYear.Text = dgvBooks.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtStock.Text = dgvBooks.Rows[e.RowIndex].Cells[6].Value.ToString();

            btnAddBook.Enabled = false; // Güncelleme moduna geç
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            BookBLL bookBLL = new BookBLL();
            dgvBooks.DataSource = bookBLL.GetAllBooks();

            dgvBooks.Columns[0].Visible = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ReadOnly = true;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnLowStock_Click(object sender, EventArgs e)
        {
            BookBLL bookBLL = new BookBLL();
            dgvBooks.DataSource = bookBLL.GetLowStockBooks();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                BookBLL bookBLL = new BookBLL();
                dgvBooks.DataSource = bookBLL.SearchBooks(txtSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
