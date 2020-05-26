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
using DataBase;

namespace Custom_pizza
{
    public partial class frmMainMenu : Form
    {
        private bool logOutExpanded;
        private User currentUser;
        private UserRepository userRepository;
        public frmMainMenu(User user)
        {
            InitializeComponent();
            logOutExpanded = false;
            currentUser = user;
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            userRepository = new UserRepository();
            DataBase.Image userImage = currentUser.UserImage;
            lblWelcome.Text = "Welcome " + currentUser.Name;
            picUser.Image = System.Drawing.Image.FromStream(userRepository.GetImageMemoryByID(userImage.Id_image));
            picUser.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenMenu();
        }

        private void OpenMenu()
        {
            Form menu = null;
            if (currentUser.UserType == User_Type.admin)
                menu = new frmAdminMenu();
            if (currentUser.UserType == User_Type.worker)
                menu = new frmWorkerMenu();
            if (currentUser.UserType == User_Type.customer)
                menu = new frmCustomerMenu();
            menu.TopLevel = false;
            menu.FormBorderStyle = FormBorderStyle.None;
            menu.Dock = DockStyle.Fill;
            pnlOptionsMenu.Controls.Add(menu);
            pnlOptionsMenu.Tag = menu;
            menu.BringToFront();
            menu.Show();
        }

        private Form activeForm = null;

        public void OpenWorkBoard(Form newForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            pnlWorkBoard.Controls.Add(newForm);
            pnlWorkBoard.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();

        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            if (logOutExpanded == false)
            {
                logOutExpanded = true;
                pnlShutDown.Height += 200;
            }
            else
            {
                logOutExpanded = false;
                pnlShutDown.Height -= 200;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //here will come logOut later on
        }

        private void SetCursor(int cordinate)
        {
        }

       
    }
}
