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
using PizzaSettingsClass;
using PizzaItemSettingsClass;
using PizzaBillSettingsClass;

namespace CustomPizza
{

    public partial class fmrCustomPizza : Form
    {
        IngredientRepository ingredientRepository;
        UserRepository userRepository;
        PizzaRepository pizzaRepository;
        PizzaItemRepository pizzaItemSettings;
        PizzaBillRepository pizzaBillRepository;

        List<Ingredient> ingredient = new List<Ingredient>();
        List<Ingredient> reservedList = new List<Ingredient>();
        User currentUser;

        int currentBill;
        int nb = 1;

        public fmrCustomPizza(User currentUser, int currentBill)
        {
            InitializeComponent();

            userRepository = new UserRepository();
            ingredientRepository = new IngredientRepository();
            pizzaRepository = new PizzaRepository();
            pizzaBillRepository = new PizzaBillRepository();
            pizzaItemSettings = new PizzaItemRepository();

            ShowIngredients();
            this.currentUser = currentUser;
            this.currentBill = currentBill;
        }


        void ShowIngredients()
        {
            List<Ingredient> List = new List<Ingredient>();
            List = ingredientRepository.GetAllIngredient();

            if (List.Count != 0)
            {
                dgvIngredient.DataSource = List;
                dgvIngredient.Columns[0].Visible = false;
                dgvIngredient.Columns[2].Visible = false;
                dgvIngredient.Columns[4].Visible = false;
                dgvIngredient.Columns[6].Visible = false;
            }

            foreach (DataGridViewRow row in dgvIngredient.Rows)
            {
                if ((int)row.Cells[5].Value <= (int)row.Cells[6].Value)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
        void ShowIngredientsInPizza_1()
        {
            decimal Sum = 0;
            dgvIngredientInPizza.DataSource = null;
            dgvIngredientInPizza.DataSource = ingredient;
            dgvIngredientInPizza.Columns[0].Visible = false;
            dgvIngredientInPizza.Columns[2].Visible = false;
            dgvIngredientInPizza.Columns[4].Visible = false;
            dgvIngredientInPizza.Columns[6].Visible = false;
            foreach (var ing in ingredient)
            {
                Sum += ing.Selling_price_per_unit;
            }
            Sum = Sum * nb;
            lbTotalPrice.Text = $"Total price : {Sum} HRK";
        }

        private void DgvIngredient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int tmp;
            tmp = ingredientRepository.ReserveIngredient(dgvIngredient.CurrentRow.DataBoundItem as Ingredient, 1);
            if (tmp == 1)
            {
                ingredient.Add(dgvIngredient.CurrentRow.DataBoundItem as Ingredient);
                ShowIngredientsInPizza_1();
                ShowIngredients();
            }
            else
            {
                MessageBox.Show($"This ingredient is out of stock", "Warning Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DgvIngredientInPizza_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Ingredient tmp = dgvIngredientInPizza.CurrentRow.DataBoundItem as Ingredient;
            ingredientRepository.FreeIngredient(tmp, 1);
            ingredient.Remove(tmp);
            ShowIngredients();
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
            if (ingredient.Count > 0)
            {
                int idPizza = 0;
                idPizza = pizzaRepository.AddPizzaInDB();
                pizzaItemSettings.AddPizzaItemsInDB(ingredient, idPizza);
                pizzaBillRepository.AddPizzaBillInDB(currentBill, idPizza, nb);
                ingredient.Clear();
                nb = 1;
                ShowIngredientsInPizza_1();
                pbIngredientPizza.Image = null;
                lbMeasurementPizza.Text = "";
                lbMeasurementPizza.Text = "";
                lbUnitNumberPizza.Text = "";
                lbSellingPricePerUnitPizza.Text = "";
                lbNamePizza.Text = "";
                lbNb.Text = $"Number of copies : {nb}";
                MessageBox.Show($"Your order has been added to your bill", "Warning Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Please select at least 1 ingredient", "Warning Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Btnplus_Click(object sender, EventArgs e)
        {
            int tmp;
            reservedList = new List<Ingredient>();
            foreach (var ing in ingredient)
            {
                ingredientRepository.FreeIngredient(ing, nb);
            }
            nb++;
            foreach (var ing in ingredient)
            {
                tmp = ingredientRepository.ReserveIngredient(ing, nb);
                if (tmp == 0)
                {
                    Reset();
                    break;
                }
                reservedList.Add(ing);
            }

            lbNb.Text = $"Number of copies : {nb}";
            ShowIngredients();
            ShowIngredientsInPizza_1();
        }

        private void BtnMoins_Click(object sender, EventArgs e)
        {
            if (nb > 1)
            {
                foreach (var ing in ingredient)
                {
                    ingredientRepository.FreeIngredient(ing, nb);
                }
                nb--;
                foreach (var ing in ingredient)
                {
                    ingredientRepository.ReserveIngredient(ing, nb);
                }
                lbNb.Text = $"Number of copies : {nb}";
            }
            ShowIngredients();
            ShowIngredientsInPizza_1();
        }

        private void BtnAbort_Click(object sender, EventArgs e)
        {
            Reset();
        }

        void Reset()
        {
            if (reservedList.Count == 0)
            {
                foreach (var ing in ingredient)
                {
                    ingredientRepository.FreeIngredient(ing, nb);
                }
            }
            else
            {
                foreach (var ing in reservedList)
                {
                    ingredientRepository.FreeIngredient(ing, nb);
                }
            }

            ingredient.Clear();
            reservedList.Clear();
            nb = 1;
            ShowIngredientsInPizza_1();
            ShowIngredients();
            pbIngredientPizza.Image = null;
            lbMeasurementPizza.Text = "";
            lbMeasurementPizza.Text = "";
            lbUnitNumberPizza.Text = "";
            lbSellingPricePerUnitPizza.Text = "";
            lbNamePizza.Text = "";
            lbNb.Text = $"Number of copies : {nb}";
            MessageBox.Show($"Your command has been reset", "Warning Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void FmrCustomPizza_Load(object sender, EventArgs e)
        {
            ShowIngredients();
        }
    }
}
