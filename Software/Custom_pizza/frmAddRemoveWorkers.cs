using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserSettingsClass;

namespace Custom_pizza
{
    public partial class frmAddRemoveWorkers : Form
    {
        private List<User> allUsers;
        private User selectedUser;
        private UserRepository userRepository;
        public frmAddRemoveWorkers()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void frmAddRemoveWorkers_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            txtSearch.Text = "";
            allUsers = userRepository.GetAllUsers();
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = allUsers;
            dgvUsers.Columns[0].Visible = false;
            dgvUsers.Columns[5].Visible = false;
            dgvUsers.Columns[10].Visible = false;
            btnChangeToCustomer.Enabled = false;
            btnChangeToWorker.Enabled = false;
        }

        private void dgvUsers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvUsers.ClearSelection();
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedUser = dgvUsers.CurrentRow.DataBoundItem as User;
            if (selectedUser.UserType == User_Type.customer)
            {
                btnChangeToWorker.Enabled = true;
                btnChangeToCustomer.Enabled = false;
            }
            else
            {
                btnChangeToWorker.Enabled = false;
                btnChangeToCustomer.Enabled = true;
            }
        }

        private void btnChangeToWorker_Click(object sender, EventArgs e)
        {
            selectedUser = dgvUsers.CurrentRow.DataBoundItem as User;
            userRepository.UpdateUserType(selectedUser.Id, User_Type.worker);
            RefreshGrid();
            dgvUsers.ClearSelection();
        }

        private void btnChangeToCustomer_Click(object sender, EventArgs e)
        {
            selectedUser = dgvUsers.CurrentRow.DataBoundItem as User;
            userRepository.UpdateUserType(selectedUser.Id, User_Type.customer);
            RefreshGrid();
            dgvUsers.ClearSelection();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string filter = txtSearch.Text;
            List<User> usersFiltered = new List<User>();
            foreach (var user in allUsers)
            {
                if (user.Name.Contains(filter) || user.Username.Contains(filter) || user.Email.Contains(filter))
                    usersFiltered.Add(user);
            }
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = usersFiltered;
            dgvUsers.Columns[0].Visible = false;
            dgvUsers.Columns[5].Visible = false;
            dgvUsers.Columns[10].Visible = false;
            btnChangeToCustomer.Enabled = false;
            btnChangeToWorker.Enabled = false;
        }
    }
}
