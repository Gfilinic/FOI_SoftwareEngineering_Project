using DataBase;
using DiscountSettingsClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Custom_pizza
{
    public partial class frmAddNewDiscount : Form
    {
        DiscountRepository discountRepository = new DiscountRepository();
        string imagePath;
        
        public frmAddNewDiscount()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoToMenu();
        }

        private void GoToMenu()
        {
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                dialog.Title = "Select image";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    pbDiscount.ImageLocation = imagePath;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error ocurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if (rtbDescription.Text != "")
                {
                    if (imagePath != "")
                    {
                        if(dtp_begins.Value < dtp_ends.Value)
                        {
                            discountRepository.AddNewDiscountToDatabase(txtName.Text, rtbDescription.Text, dtp_begins.Value, dtp_ends.Value, imagePath);
                            GoToMenu();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Date, Check if the end date is later than a starting date", "Warning Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select an image with upload button", "Warning Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please describe your discount in the description box", "Warning Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please write a name of a discount", "Warning Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         
        }
   }
}
    

