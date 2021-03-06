﻿using IngredientSettingsClass;
using DataBase;
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
using Custom_pizza.HelpForms;

namespace frmAddIngredient
{
    public partial class frmMenuIngredients : Form
    {
        IngredientRepository ingredientRepository = new IngredientRepository();

        Thread threadRegister, threadApp;

        public frmMenuIngredients()
        {
            InitializeComponent();
            ShowIngredients();

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
        private void BtnAdd_Click_1(object sender, EventArgs e)
        {

            threadRegister = new Thread(OpenAddNewIngredient);
            threadRegister.SetApartmentState(ApartmentState.STA);
            threadRegister.Start();
        }
        private void BtnModify_Click_1(object sender, EventArgs e)
        {

            threadRegister = new Thread(OpenModIngredient);
            threadRegister.SetApartmentState(ApartmentState.STA);
            threadRegister.Start();
        }

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvIngredient.CurrentRow != null)
            {
                ingredientRepository.DeleteIngredient(dgvIngredient.CurrentRow.DataBoundItem as Ingredient);
            }
            else
            {
                MessageBox.Show("Please select a row", "Warning Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ShowIngredients();
        }

        void ShowIngredients()
        {
            List<Ingredient> List = new List<Ingredient>();
            List = ingredientRepository.GetAllIngredient();

            dgvIngredient.DataSource = List;

        }

        private void OpenAddNewIngredient()
        {
            Application.Run(new frmAddNewIngredient());
        }

        private void BtnRefresh_Click_1(object sender, EventArgs e)
        {
            ShowIngredients();
        }

        private void frmMenuIngredients_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmHelp_MenuIngredients frmHelp = new frmHelp_MenuIngredients();
                frmHelp.ShowDialog();

            }
        }

        private void OpenModIngredient()
        {
            if (dgvIngredient.CurrentRow != null)
            {
                Ingredient ingredient = dgvIngredient.CurrentRow.DataBoundItem as Ingredient;
                Application.Run(new frmModIngredient(ingredient));
            }
            else
            {
                MessageBox.Show("Please select a row", "Warning Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Run(new frmMenuIngredients());
            }

        }
    }
}
