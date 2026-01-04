using libraryControlSystem2.BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace libraryControlSystem2.UI
{
    public partial class BorrowReportForm : Form
    {
        public BorrowReportForm()
        {
            InitializeComponent();
        }

        private string _userRole;

        public BorrowReportForm(string role)
        {
            InitializeComponent();
            _userRole = role;
        }

        private void BorrowReportForm_Load(object sender, EventArgs e)
        {

            if (_userRole != "Admin")
            {
                MessageBox.Show("Bu sayfaya erişim yetkiniz yok.");
                this.Close();
                return;
            }
            BorrowBLL borrowBLL = new BorrowBLL();

            // 🔹 İADESİ YAKLAŞAN KİTAPLAR
            dgvDueSoon.DataSource = borrowBLL.GetDueSoonBorrows();
            dgvDueSoon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDueSoon.ReadOnly = true;
            dgvDueSoon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // 🔹 GECİKEN KİTAPLAR
            dgvLateBorrows.DataSource = borrowBLL.GetLateBorrows();
            dgvLateBorrows.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLateBorrows.ReadOnly = true;
            dgvLateBorrows.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // EN ÇOK ÖDÜNÇ ALINAN KİTAPLAR
            dgvMostBorrowed.DataSource = borrowBLL.GetMostBorrowedBooks();
            dgvMostBorrowed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMostBorrowed.ReadOnly = true;
            dgvMostBorrowed.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            if (dgvMostBorrowed.Rows.Count > 0)
            {
                dgvMostBorrowed.Rows[0].DefaultCellStyle.BackColor = Color.LightGreen;
            }

            // AKTİF ÜYELER
            dgvActiveMembers.DataSource = borrowBLL.GetActiveMembers();
            dgvActiveMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActiveMembers.ReadOnly = true;
            dgvActiveMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            if (dgvActiveMembers.Rows.Count > 0)
            {
                dgvActiveMembers.Rows[0].DefaultCellStyle.BackColor = Color.LightGreen;
            }


        }

        // 🔸 İADE TARİHİNE GÖRE RENKLENDİRME
        private void dgvDueSoon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            dgvDueSoon.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;

            DateTime dueDate = Convert.ToDateTime(
                dgvDueSoon.Rows[e.RowIndex].Cells["DueDate"].Value
            );

            int daysDiff = (dueDate.Date - DateTime.Today).Days;

            if (daysDiff < 0)
            {
                // GECİKMİŞ
                dgvDueSoon.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
            }
            else if (daysDiff <= 3)
            {
                // YAKLAŞAN
                dgvDueSoon.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Khaki;
            }
        }

        // 🔸 GECİKENLER İÇİN EK RENKLENDİRME (7+ gün)
        private void dgvLateBorrows_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int gecikmeGun = Convert.ToInt32(
                dgvLateBorrows.Rows[e.RowIndex].Cells["GecikmeGun"].Value
            );

            if (gecikmeGun >= 7)
            {
                dgvLateBorrows.Rows[e.RowIndex]
                    .DefaultCellStyle.BackColor = Color.LightCoral;
            }
        }

        // 🔹 KİTAP İADE AL
        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (dgvDueSoon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen iade edilecek kaydı seçin.");
                return;
            }

            int borrowId = Convert.ToInt32(
                dgvDueSoon.SelectedRows[0].Cells["BorrowID"].Value
            );

            BorrowBLL bll = new BorrowBLL();
            bll.ReturnBook(borrowId);

            MessageBox.Show("Kitap iade edildi.");

            // Listeleri yenile
            dgvDueSoon.DataSource = bll.GetDueSoonBorrows();
            dgvLateBorrows.DataSource = bll.GetLateBorrows();
        }

        private void dgvLateBorrows_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {

        }
    }
}
