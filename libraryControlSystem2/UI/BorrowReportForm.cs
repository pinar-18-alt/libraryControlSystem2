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


        private void BorrowReportForm_Load(object sender, EventArgs e)
        {
            BorrowBLL borrowBLL = new BorrowBLL();

            dgvDueSoon.DataSource = borrowBLL.GetDueSoonBorrows();

            dgvDueSoon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDueSoon.ReadOnly = true;
            dgvDueSoon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvDueSoon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // Önce default rengi sıfırla
            dgvDueSoon.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;

            DateTime dueDate = Convert.ToDateTime(
                dgvDueSoon.Rows[e.RowIndex].Cells["DueDate"].Value
            );

            int daysDiff = (dueDate.Date - DateTime.Today).Days;

            // GECİKMİŞ
            if (daysDiff < 0)
            {
                dgvDueSoon.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
            }
            // YAKLAŞAN (3 gün ve altı)
            else if (daysDiff <= 3)
            {
                dgvDueSoon.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Khaki;
            }
        }


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

            dgvDueSoon.DataSource = bll.GetDueSoonBorrows();
        }
    }
}
