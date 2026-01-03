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

namespace libraryControlSystem2.UI
{
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            try
            {
                MemberBLL memberBLL = new MemberBLL();

                memberBLL.AddMember(
                    txtFirstName.Text,
                    txtLastName.Text,
                    txtPhone.Text,
                    txtEmail.Text
                );

                MessageBox.Show("Üye başarıyla eklendi.");

                // Listeyi güncelle
                dgvMembers.DataSource = memberBLL.GetAllMembers();

                // Inputları temizle
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

        private void btnListMembers_Click(object sender, EventArgs e)
        {
            MemberBLL memberBLL = new MemberBLL();

            dgvMembers.DataSource = memberBLL.GetAllMembers();

            dgvMembers.Columns[0].Visible = false; // MemberID gizle
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.ReadOnly = true;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

    }
}
