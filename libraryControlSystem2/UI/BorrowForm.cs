using libraryControlSystem2.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace libraryControlSystem2.UI
{
    public partial class BorrowForm : Form
    {
        public BorrowForm()
        {
            InitializeComponent();
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
            LoadBooks();
            LoadBorrows();
        }

        // Üyeleri doldur
        private void LoadMembers()
        {
            MemberBLL bll = new MemberBLL();
            DataTable dt = bll.GetAllMembers();

            cmbMembers.DataSource = dt;
            cmbMembers.DisplayMember = "FirstName"; // güvenli kullanım
            cmbMembers.ValueMember = "MemberID";
        }

        // Kitapları doldur
        private void LoadBooks()
        {
            BookBLL bll = new BookBLL();
            cmbBooks.DataSource = bll.GetAllBooks();
            cmbBooks.DisplayMember = "Title";
            cmbBooks.ValueMember = "BookID";
        }

        // Aktif ödünçleri listele
        private void LoadBorrows()
        {
            BorrowBLL bll = new BorrowBLL();
            dgvBorrows.DataSource = bll.GetActiveBorrows();

            dgvBorrows.Columns["BorrowID"].Visible = false;
            dgvBorrows.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrows.ReadOnly = true;
            dgvBorrows.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // ÖDÜNÇ VER
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                BorrowBLL bll = new BorrowBLL();

                bll.BorrowBook(
                    Convert.ToInt32(cmbBooks.SelectedValue),
                    Convert.ToInt32(cmbMembers.SelectedValue),
                    dtpDueDate.Value
                );

                MessageBox.Show("Kitap ödünç verildi.");
                LoadBorrows();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // İADE AL
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvBorrows.SelectedRows.Count == 0)
            {
                MessageBox.Show("İade edilecek kaydı seçin.");
                return;
            }

            int borrowId = Convert.ToInt32(
                dgvBorrows.SelectedRows[0].Cells["BorrowID"].Value
            );

            BorrowBLL bll = new BorrowBLL();
            bll.ReturnBook(borrowId);

            MessageBox.Show("Kitap iade edildi.");
            LoadBorrows();
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("CLICK GELDİ ");
        }
    }
}
