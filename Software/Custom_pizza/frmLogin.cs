using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using UserSettingsClass;

namespace Custom_pizza
{
    public partial class frmLogin : Form
    {
        Thread threadRegister, threadApp;
        Login login;
        User user;
        public frmLogin()
        {
            InitializeComponent();
            try
            {
                if (threadRegister.ThreadState == ThreadState.Running)
                    threadRegister.Abort();
                if (threadApp.ThreadState == ThreadState.Running)
                    threadApp.Abort();
            }
            catch (NullReferenceException)
            { }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserNameEmail.MaxLength = 25;
            txtPassword.MaxLength = 25;
            txtPassword.PasswordChar = '*';
            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login = new Login();
            string usernameEmail = txtUserNameEmail.Text;
            string password = txtPassword.Text;
            var message = login.UserLogin(usernameEmail, password);
            if (message is string)
                MessageBox.Show(message.ToString());
            else
            {
                Close();
                user = message as User;
                threadApp = new Thread(() => OpenApp(user));
                threadApp.SetApartmentState(ApartmentState.STA);
                threadApp.Start();
            }
        }

        private void OpenApp(User user)
        {
                Application.Run(new frmMainMenu(user));
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Close();
            threadRegister = new Thread(OpenRegistration);
            threadRegister.SetApartmentState(ApartmentState.STA);
            threadRegister.Start();
        }

        private void OpenRegistration()
        {
            Application.Run(new frmRegistration());
        }

        

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
