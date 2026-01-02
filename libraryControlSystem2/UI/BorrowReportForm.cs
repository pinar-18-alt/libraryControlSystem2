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
            if (dgvDueSoon.Rows[e.RowIndex].Cells["DueDate"].Value == null)
                return;

            DateTime dueDate = Convert.ToDateTime(
                dgvDueSoon.Rows[e.RowIndex].Cells["DueDate"].Value
            );

            int daysLeft = (dueDate - DateTime.Now).Days;

            if (daysLeft <= 3)
            {
                dgvDueSoon.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
            }
        }
    }
}

