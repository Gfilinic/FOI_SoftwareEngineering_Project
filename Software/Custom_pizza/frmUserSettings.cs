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
    public partial class frmUserSettings : Form
    {
        private string imagePath;
        User currentUser;
        private UserRepository userRepository;
        private RegisterUpdate update;
        public frmUserSettings(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            userRepository = new UserRepository();
            imagePath = "old";
        }

        private void frmUserSettings_Load(object sender, EventArgs e)
        {
            txtUsername.Text = currentUser.Username;
            txtEmail.Text = currentUser.Email;
            txtPassword.PasswordChar = '*';
            txtPassword.Text = currentUser.Password;
            txtRepeatPassword.PasswordChar = '*';
            txtRepeatPassword.Text = currentUser.Password;
            txtName.Text = currentUser.Name;
            txtSurname.Text = currentUser.Surname;
            txtZipcode.Text = currentUser.ZipCode.ToString();
            txtCity.Text = currentUser.City;
            txtAddress.Text = currentUser.Adress;
            picUserImage.Image = Image.FromStream(userRepository.GetImageMemoryByID(currentUser.UserImage.Id_image));
            picUserImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            update = new RegisterUpdate();
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
            string endResult = update.UpdateUser(currentUser, name, surname, username, password, repeatPassword, email, city, zipcode, adress, imagePath);
            MessageBox.Show(endResult);
            if (endResult == "Success! You have successfully made change/s on your account for Custom Pizza! Changes will take affect once you get out of option menu!")
                Close();
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
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
    }
}
