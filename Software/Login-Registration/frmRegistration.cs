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
using System.IO;

namespace Login_Registration
{
    public partial class frmRegistration : Form
    {
        private Thread threadLogin;
        private Register register;
        private string imagePath=null;

        public frmRegistration()
        {
            InitializeComponent();
            try
            {
                if (threadLogin.ThreadState == ThreadState.Running)
                    threadLogin.Abort();
            }
            catch (NullReferenceException)
            { }
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            register = new Register();
            picUserImage.Image = Image.FromStream(register.GetDefaultImage());
            picUserImage.SizeMode = PictureBoxSizeMode.StretchImage;
            txtUsername.MaxLength = 25;
            txtEmail.MaxLength = 25;
            txtPassword.MaxLength = 25;
            txtPassword.PasswordChar = '*';
            txtRepeatPassword.MaxLength = 25;
            txtRepeatPassword.PasswordChar = '*';
            txtName.MaxLength = 30;
            txtSurname.MaxLength = 50;
            txtZipcode.MaxLength = 10;
            txtCity.MaxLength = 40;
            txtAddress.MaxLength = 60;
        }

        private void txtZipcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 9 && chr != 25 && chr != 27 && chr != 0x2E) //8->Backspace, 9->Tab, 25->Left button, 27->Right button, 2E-->delete
            {
                e.Handled = true;
                e = null;
            }
        }

        private void btnResetImage_Click(object sender, EventArgs e)
        {
            picUserImage.Image = Image.FromStream(register.GetDefaultImage());
            imagePath = null;
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "PNG Files(*.png)|*.png|JPG Files (*.jpg)|*.jpg|All Files (*.*)|*.*";
                fileDialog.Title = "Select Image";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = fileDialog.FileName.ToString();
                    picUserImage.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            GoToLogin();
        }

        private void GoToLogin()
        {
            Close();
            threadLogin = new Thread(OpenLogin);
            threadLogin.SetApartmentState(ApartmentState.STA);
            threadLogin.Start();
        }

        private void OpenLogin()
        {
            Application.Run(new frmLogin());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            register = new Register();
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string repeatPassword = txtRepeatPassword.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            int zipcode = 0;
            Int32.TryParse(txtZipcode.Text, out zipcode);
            string city = txtCity.Text;
            string adress = txtAddress.Text;
            string endResult=register.AddNewUser(name, surname, username, password, repeatPassword, email, city, zipcode, adress, imagePath);
            MessageBox.Show(endResult);
            if (endResult == "Success! You have successfully made an account for Custom Pizza!")
                GoToLogin();
        }
    }
}
