using IngredientSettingsClass;
using System;
using DataBase;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using UserSettingsClass;
using BillSettingsClass;

namespace CustomPizza
{
    
    public partial class fmrCustomPizza : Form
    {
        IngredientRepository ingredientRepository = new IngredientRepository();
        List<Ingredient> ingredient = new List<Ingredient>();
        User currentUser;
        UserRepository userRepository;
        int currentBill;
        int nb = 1;

        public fmrCustomPizza(User currentUser, int currentBill)
        {
            InitializeComponent();
            ShowIngredients();
            this.currentUser = currentUser;
            userRepository = new UserRepository();
            this.currentBill = currentBill;
        }


        void ShowIngredients()
        {
            List<Ingredient> List = new List<Ingredient>();
            List = ingredientRepository.GetAllIngredient(List);
            dgvIngredient.DataSource = List;
            dgvIngredient.Columns[0].Visible = false;
            dgvIngredient.Columns[2].Visible = false;
            dgvIngredient.Columns[4].Visible = false;

        }
        void ShowIngredientsInPizza_1()
        {
            decimal Sum = 0;
            dgvIngredientInPizza.DataSource = null;
            dgvIngredientInPizza.DataSource = ingredient;
            dgvIngredientInPizza.Columns[0].Visible = false;
            dgvIngredientInPizza.Columns[2].Visible = false;
            dgvIngredientInPizza.Columns[4].Visible = false;
            foreach (var ing in ingredient)
            {
                Sum += ing.Selling_price_per_unit;
            }
            Sum = Sum * nb;
            lbTotalPrice.Text = $"Total price : {Sum} HRK";
        }

        private void DgvIngredient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ingredient.Add(dgvIngredient.CurrentRow.DataBoundItem as Ingredient);
            ShowIngredientsInPizza_1();
        }

        private void DgvIngredientInPizza_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ingredient.Remove(dgvIngredientInPizza.CurrentRow.DataBoundItem as Ingredient);
            Console.WriteLine("oui");
            ShowIngredientsInPizza_1();
            pbIngredientPizza.Image = null;
            lbMeasurementPizza.Text = "";
            lbMeasurementPizza.Text = "";
            lbUnitNumberPizza.Text = "";
            lbSellingPricePerUnitPizza.Text = "";
            lbNamePizza.Text = "";
        }

        private void DgvIngredient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ingredient tmp = dgvIngredient.CurrentRow.DataBoundItem as Ingredient;
            lbName.Text = tmp.Name;
            lbMeasurement.Text = tmp.Measurement.measurement1;
            lbUnitNumber.Text = tmp.Unit_numbers.ToString();
            lbSellingPricePerUnit.Text = tmp.Selling_price_per_unit.ToString();

            MemoryStream ms = new MemoryStream(tmp.IngredientImage.Image_);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            pbIngredient.Image = returnImage;

        }

        private void DgvIngredientInPizza_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ingredient tmp = dgvIngredientInPizza.CurrentRow.DataBoundItem as Ingredient;
            lbNamePizza.Text = tmp.Name;
            lbMeasurementPizza.Text = tmp.Measurement.measurement1;
            lbUnitNumberPizza.Text = tmp.Unit_numbers.ToString();
            lbSellingPricePerUnitPizza.Text = tmp.Selling_price_per_unit.ToString();

            MemoryStream ms = new MemoryStream(tmp.IngredientImage.Image_);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            pbIngredientPizza.Image = returnImage;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int idPizza = 0;
            string SQLcommand1 = $"INSERT INTO [Pizza] (name, description, id_image, admin_added) VALUES ('Custom Pizza','Custom Pizza','83','0');";
            string SQLcommand2 = $"SELECT MAX(id_Pizza) FROM [Pizza];";

            DataBaseI.Instance.Connect();
            DataBaseI.Instance.ExecuteCommand(SQLcommand1);
            idPizza = int.Parse(DataBaseI.Instance.GetValue(SQLcommand2).ToString());

            foreach(var ing in ingredient)
            {
                string SQLcommand3 = $"INSERT INTO [Pizza_items] (id_ingredient, id_pizza) VALUES ('{ing.Id_ingredient}','{idPizza}');";
                DataBaseI.Instance.ExecuteCommand(SQLcommand3);
            }

            string SQLcommand4 = $"INSERT INTO [Pizza_bill] (id_bill, id_pizza, quantity) VALUES ('{currentBill}','{idPizza}','{nb}');";
            DataBaseI.Instance.ExecuteCommand(SQLcommand4);

            DataBaseI.Instance.Disconnect();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Btnplus_Click(object sender, EventArgs e)
        {
            nb++;
            lbNb.Text = $"Number of copies : {nb}";
            ShowIngredientsInPizza_1();
        }

        private void BtnMoins_Click(object sender, EventArgs e)
        {
            if(nb>1)
            {
                nb--;
                lbNb.Text = $"Number of copies : {nb}";
            }
            ShowIngredientsInPizza_1();
        }   
    }
}
