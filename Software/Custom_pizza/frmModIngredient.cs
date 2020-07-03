using DataBase;
using IngredientSettingsClass;
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

namespace frmAddIngredient
{
    public partial class frmModIngredient : Form
    {
        IngredientRepository ingredientRepository = new IngredientRepository();
        string Imagepath;
        Ingredient ingredient;

        public frmModIngredient(Ingredient Ingredient)
        {
            InitializeComponent();
            ingredient = Ingredient;
            ShowMeasurement();
            Load_Ingredient(ingredient);

        }


        private void ShowMeasurement()
        {
            string SQLcommand = $"SELECT measurement FROM [Measurement];";
            List<string> tmp = new List<string>();

            DataBaseI.Instance.Connect();
            IDataReader dataReader = DataBaseI.Instance.GetDataReader(SQLcommand);
            while (dataReader.Read())
            {
                tmp.Add(dataReader["measurement"].ToString());

            }
            lbMeasurement.DataSource = tmp;
            dataReader.Close();
            DataBaseI.Instance.Disconnect();

        }
        private void Load_Ingredient(Ingredient ingredient)
        {
            MemoryStream ms = new MemoryStream(ingredient.IngredientImage.Image_);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);

            tbName.Text = ingredient.Name;
            tbSelling_price_per_unit.Text = ingredient.Selling_price_per_unit.ToString();
            tbUnit_number.Text = ingredient.Unit_numbers.ToString();
            pbIngredient.Image = returnImage;
            lbMeasurement.SelectedIndex = ingredient.Measurement.Id_measurement - 1;
            tbStock.Text = ingredient.Stock.ToString();

        }

        void GoToMenu()
        {
            this.Close();
        }

        void OpenMenu()
        {
            Application.Run(new frmMenuIngredients());
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            GoToMenu();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (tbSelling_price_per_unit.Text != "")
            {
                if (tbUnit_number.Text != "")
                {
                    if (Imagepath != "")
                    {
                        if (lbMeasurement.SelectedItem.ToString() != "")
                        {
                            ingredientRepository.ModIngredientToDatabase(tbName.Text, decimal.Parse(tbSelling_price_per_unit.Text), int.Parse(tbUnit_number.Text), Imagepath, ingredientRepository.GetIdMeasurement(lbMeasurement.SelectedItem.ToString()), int.Parse(tbStock.Text));
                            GoToMenu();
                        }
                        else
                        {
                            MessageBox.Show("Please select a measurement", "Warning Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select an image with upload button", "Warning Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please write an unit number", "Warning Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please write a selling price per unit", "Warning Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                dialog.Title = "Select image";

                DialogResult dr = dialog.ShowDialog();

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    Imagepath = dialog.FileName.ToString();
                    pbIngredient.ImageLocation = Imagepath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
