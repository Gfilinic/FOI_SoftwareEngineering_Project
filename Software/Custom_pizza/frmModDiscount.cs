using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase;
using DiscountSettingsClass;

namespace Custom_pizza
{
    public partial class frmModDiscount : Form
    {
        DiscountRepository discountRepository = new DiscountRepository();
        string imagePath;
        Discount discount;
        public frmModDiscount(Discount Discount)
        {
            InitializeComponent();
            discount = Discount;
            Load_Discount(discount);

        }
        private void Load_Discount(Discount discount)
        {
            MemoryStream ms = new MemoryStream(discount.DiscountImage.Image_);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);

            txtName.Text = discount.Name;
            dtp_begins.Value = discount.Date_Time_Begins;
            dtp_ends.Value = discount.Date_Time_Ends;
            rtbDescription.Text = discount.Description;
            pbDiscount.Image = returnImage;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoToMenu();
        }

        private void GoToMenu()
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if (rtbDescription.Text != "")
                {
                    if (imagePath != "")
                    {
                        if (dtp_begins.Value < dtp_ends.Value)
                        {
                            discountRepository.ModDiscountToDatabase(txtName.Text, rtbDescription.Text, dtp_begins.Value, dtp_ends.Value, imagePath);
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
    }
}
