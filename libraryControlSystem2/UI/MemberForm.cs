using System;
using System.Windows.Forms;
using libraryControlSystem2.BLL;

namespace libraryControlSystem2.UI
{
    public partial class MemberForm : Form
    {
        private string _userRole;
        private int selectedMemberId = 0;

        public MemberForm(string role)
        {
            InitializeComponent();
            _userRole = role;
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            if (_userRole == "User")
            {
                MessageBox.Show("Bu sayfaya erişim yetkiniz yok.");
                this.Close();
                return;
            }

            LoadMembers();
            SetupGrid();
        }

        private void LoadMembers()
        {
            MemberBLL bll = new MemberBLL();
            dgvMembers.DataSource = bll.GetAllMembers();

            if (dgvMembers.Columns.Count > 0)
                dgvMembers.Columns[0].Visible = false;
        }

        private void SetupGrid()
        {
            dgvMembers.ReadOnly = true;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.MultiSelect = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedMemberId = Convert.ToInt32(dgvMembers.Rows[e.RowIndex].Cells[0].Value);

            txtFirstName.Text = dgvMembers.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvMembers.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhone.Text = dgvMembers.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmail.Text = dgvMembers.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            MemberBLL bll = new MemberBLL();
            bll.AddMember(
                txtFirstName.Text,
                txtLastName.Text,
                txtPhone.Text,
                txtEmail.Text
            );

            MessageBox.Show("Üye eklendi.");
            LoadMembers();
            ClearInputs();
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            if (selectedMemberId == 0)
            {
                MessageBox.Show("Üye seçin.");
                return;
            }

            MemberBLL bll = new MemberBLL();
            bll.UpdateMember(
                selectedMemberId,
                txtFirstName.Text,
                txtLastName.Text,
                txtPhone.Text,
                txtEmail.Text
            );

            MessageBox.Show("Üye güncellendi.");
            LoadMembers();
            ClearInputs();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (selectedMemberId == 0)
            {
                MessageBox.Show("Üye seçin.");
                return;
            }

            MemberBLL bll = new MemberBLL();
            bll.DeleteMember(selectedMemberId);

            MessageBox.Show("Üye silindi.");
            LoadMembers();
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            selectedMemberId = 0;
        }
    }
}
