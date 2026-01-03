using System;
using System.Data;
using System.Windows.Forms;
using libraryControlSystem2.BLL;

namespace libraryControlSystem2.UI
{
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }

        // FORM AÇILINCA
        private void MemberForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
            SetupGrid();
        }

        // ÜYELERİ YÜKLE
        private void LoadMembers()
        {
            MemberBLL bll = new MemberBLL();
            dgvMembers.DataSource = bll.GetAllMembers();

            if (dgvMembers.Columns.Count > 0)
                dgvMembers.Columns[0].Visible = false; // MemberID gizle
        }

        // DATAGRID AYARLARI (TEK YERDEN)
        private void SetupGrid()
        {
            dgvMembers.ReadOnly = true;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.MultiSelect = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ÜYE EKLE
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text == "" || txtLastName.Text == "")
                {
                    MessageBox.Show("Ad ve Soyad zorunludur.");
                    return;
                }

                MemberBLL memberBLL = new MemberBLL();

                memberBLL.AddMember(
                    txtFirstName.Text,
                    txtLastName.Text,
                    txtPhone.Text,
                    txtEmail.Text
                );

                MessageBox.Show("Üye başarıyla eklendi 🎉");

                LoadMembers(); // tabloyu yenile

                txtFirstName.Clear();
                txtLastName.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // LİSTELE BUTONU 
        private void btnListMembers_Click(object sender, EventArgs e)
        {
            LoadMembers();
        }
    }
}
