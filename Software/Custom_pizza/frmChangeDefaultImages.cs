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
    public partial class frmChangeDefaultImages : Form
    {
        private UserRepository userRepository;
        private string pathUser = "old", pathPizza = "old", pathIngredient = "old", pathDiscount = "old";
        public frmChangeDefaultImages()
        {
            InitializeComponent();
        }

        private void frmChangeDefaultImages_Load(object sender, EventArgs e)
        {
            userRepository = new UserRepository();
            picDeffUser.Image = Image.FromStream(userRepository.GetImageMemoryByID(1));
            picDeffUser.SizeMode = PictureBoxSizeMode.StretchImage;
            picDefPizza.Image = Image.FromStream(userRepository.GetImageMemoryByID(2));
            picDefPizza.SizeMode = PictureBoxSizeMode.StretchImage;
            picDeffIngredient.Image = Image.FromStream(userRepository.GetImageMemoryByID(3));
            picDeffIngredient.SizeMode = PictureBoxSizeMode.StretchImage;
            picDeffDiscount.Image = Image.FromStream(userRepository.GetImageMemoryByID(4));
            picDeffDiscount.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            pathUser = ChangeImage(picDeffUser);
            picDeffUser.ImageLocation = pathUser;
        }

        private void btnChangePizza_Click(object sender, EventArgs e)
        {
            pathPizza = ChangeImage(picDefPizza);
            picDefPizza.ImageLocation = pathPizza;
        }

        private void btnChangeIngredient_Click(object sender, EventArgs e)
        {
            pathIngredient = ChangeImage(picDeffIngredient);
            picDeffIngredient.ImageLocation = pathIngredient;
        }

        private void btnChangeDiscount_Click(object sender, EventArgs e)
        {
            pathDiscount = ChangeImage(picDeffDiscount);
            picDeffDiscount.ImageLocation = pathDiscount;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            userRepository = new UserRepository();
            userRepository.UpdateDefaultImages(pathUser, pathPizza, pathIngredient, pathDiscount);
            MessageBox.Show("Sucess! Changes will be visible upon restarting the application!");
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string ChangeImage(PictureBox picture)
        {
            string imagePath="";
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "PNG Files(*.png)|*.png|JPG Files (*.jpg)|*.jpg|All Files (*.*)|*.*";
                fileDialog.Title = "Select Image";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = fileDialog.FileName.ToString();
                    picture.ImageLocation = imagePath;
                }
                return imagePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
