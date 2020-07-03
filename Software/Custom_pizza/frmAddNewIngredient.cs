
using DataBase;
using frmAddIngredient;
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

    public partial class frmAddNewIngredient : Form
    {
        IngredientRepository ingredientRepository = new IngredientRepository();
        string Imagepath;

        public frmAddNewIngredient()
        {
            InitializeComponent();
            ShowMeasurement();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            GoToMenu();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                if (tbSelling_price_per_unit.Text != "")
                {
                    if (tbUnit_number.Text != "")
                    {
                        if (Imagepath != "")
                        {
                            if (lbMeasurement.SelectedItem.ToString() != "")
                            {
                                if (tbStock.Text != "")
                                {
                                    ingredientRepository.AddNewIngredientToDatabase(tbName.Text, decimal.Parse(tbSelling_price_per_unit.Text), int.Parse(tbUnit_number.Text), Imagepath, ingredientRepository.GetIdMeasurement(lbMeasurement.SelectedItem.ToString()), int.Parse(tbStock.Text));
                                    GoToMenu();
                                }
                                else
                                {
                                    MessageBox.Show("Please write a stock number", "Warning Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
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
            else
            {
                MessageBox.Show("Please write a name", "Warning Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                dialog.Title = "Select image";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Imagepath = dialog.FileName;
                    pbIngredient.ImageLocation = Imagepath;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error ocurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        void GoToMenu()
        {
            this.Close();
        }

        void OpenMenu()
        {
            Application.Run(new frmMenuIngredients());
        }


    }
}
