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
    public partial class frmOptions : Form
    {
        private UserRepository userRepository;
        User currentUser;
        public frmOptions(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            if (currentUser.UserType != User_Type.admin)
            {
                btnChangeDefault.Visible = false;
            }
        }

        private void btnChangeUserSettings_Click(object sender, EventArgs e)
        {
            frmUserSettings frmUserSettings = new frmUserSettings(currentUser);
            frmUserSettings.ShowDialog();
            userRepository = new UserRepository();
            currentUser = userRepository.GetUser(currentUser.Id);
        }

        private void btnChangeDefault_Click(object sender, EventArgs e)
        {
            frmChangeDefaultImages frmChangeDefaultImages = new frmChangeDefaultImages();
            frmChangeDefaultImages.ShowDialog();
        }
    }
}
