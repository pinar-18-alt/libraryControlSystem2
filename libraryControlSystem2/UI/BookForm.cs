using System;
using System.Windows.Forms;
using libraryControlSystem2.BLL;

namespace libraryControlSystem2.UI
{
    public partial class BookForm : Form
    {
        private int selectedBookId = 0;
        private string _userRole;

        // 🔹 SADECE PARAMETRELİ CONSTRUCTOR
        public BookForm(string role)
        {
            InitializeComponent();
            _userRole = role;

            LoadBooks();
            ApplyRolePermissions();
        }

        // 🔹 ROL BAZLI YETKİ KONTROLÜ
        private void ApplyRolePermissions()
        {
            if (_userRole == "User")
            {
                btnAddBook.Visible = false;
                btnDeleteBook.Visible = false;
                btnUpdateBook.Visible = false;
                btnLowStock.Visible = false;
               // btnBorrowReport.Visible = false; // 🔴 RAPOR YOK
            }

            // STAFF → yönetir ama RAPOR GÖREMEZ
            if (_userRole == "Staff")
            {
               // btnBorrowReport.Visible = false; // 🔴 SADECE BU YETERLİ
            }

            // ADMIN → HER ŞEY AÇIK (HİÇBİR ŞEY YAPMA)
        }

        // 🔹 KİTAPLARI YÜKLE
        private void LoadBooks()
        {
            BookBLL bookBLL = new BookBLL();
            dgvBooks.DataSource = bookBLL.GetAllBooks();

            if (dgvBooks.Columns.Count > 0)
                dgvBooks.Columns[0].Visible = false;

            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ReadOnly = true;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ClearInputs()
        {
            txtISBN.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPublisher.Clear();
            txtYear.Clear();
            txtStock.Clear();

            selectedBookId = 0;

            if (_userRole != "User")
                btnAddBook.Enabled = true;
        }

        // 🔹 EKLE
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                BookBLL bll = new BookBLL();
                bll.AddBook(
                    txtISBN.Text,
                    txtTitle.Text,
                    txtAuthor.Text,
                    txtPublisher.Text,
                    txtYear.Text,
                    txtStock.Text
                );

                MessageBox.Show("Kitap eklendi.");
                LoadBooks();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 🔹 SİL
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek kitabı seçin.");
                return;
            }

            int id = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells[0].Value);
            BookBLL bll = new BookBLL();
            bll.DeleteBook(id);

            MessageBox.Show("Kitap silindi.");
            LoadBooks();
            ClearInputs();
        }

        // 🔹 GÜNCELLE
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (selectedBookId == 0)
            {
                MessageBox.Show("Güncellenecek kitabı seçin.");
                return;
            }

            try
            {
                BookBLL bll = new BookBLL();
                bll.UpdateBook(
                    selectedBookId,
                    txtISBN.Text,
                    txtTitle.Text,
                    txtAuthor.Text,
                    txtPublisher.Text,
                    txtYear.Text,
                    txtStock.Text
                );

                MessageBox.Show("Kitap güncellendi.");
                LoadBooks();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //  GRID SEÇİM
        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedBookId = Convert.ToInt32(dgvBooks.Rows[e.RowIndex].Cells[0].Value);

            txtISBN.Text = dgvBooks.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTitle.Text = dgvBooks.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAuthor.Text = dgvBooks.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPublisher.Text = dgvBooks.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtYear.Text = dgvBooks.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtStock.Text = dgvBooks.Rows[e.RowIndex].Cells[6].Value.ToString();

            if (_userRole != "User")
                btnAddBook.Enabled = false;
        }
        //  STOKTA AZALAN KİTAPLAR
        private void btnLowStock_Click(object sender, EventArgs e)
        {
            BookBLL bll = new BookBLL();
            dgvBooks.DataSource = bll.GetLowStockBooks();
        }
        private void btnListBooks_Click(object sender, EventArgs e)
        {
            LoadBooks();
            ClearInputs();
        }



    }
}
