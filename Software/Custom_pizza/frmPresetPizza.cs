using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Custom_pizza.HelpForms;


namespace Custom_pizza
{
    public partial class frmPresetPizza : Form
    {
        string totalPrice = "Total Price:";
        decimal total = 0;
        decimal[] articlePrice = new decimal[]{};
        int shopIndex;
       
        public frmPresetPizza()
        {
            InitializeComponent();
            lbShop.Items.Add(totalPrice);
        }

        private void frmPresetPizza_Load(object sender, EventArgs e)
        {

        }

        

        private void countMarg_ValueChanged(object sender, EventArgs e)
        {
            if (countMarg.Value == 0) lblTotal1.Text = "Total Price: ";
            else
                lblTotal1.Text = $"Total Price: {countMarg.Value * 10}$";
        }

        private void countCapri_ValueChanged(object sender, EventArgs e)
        {
            if (countCapri.Value == 0) lblTotal2.Text = "Total Price: ";
            else
                lblTotal2.Text = $"Total Price: {countCapri.Value * 11}$";
        }

        private void countTuna_ValueChanged(object sender, EventArgs e)
        {
            if (countTuna.Value == 0) lblTotal3.Text = "Total Price: ";
            else
                lblTotal3.Text = $"Total Price: {countTuna.Value * 11}$";
        }

        private void countFormaggi_ValueChanged(object sender, EventArgs e)
        {
            if (countFormaggi.Value == 0) lblTotal4.Text = "Total Price: ";
            else
                lblTotal4.Text = $"Total Price: {countFormaggi.Value * 14}$";
        }

        private void countStagioni_ValueChanged(object sender, EventArgs e)
        {
            if (countStagioni.Value == 0) lblTotal5.Text = "Total Price: ";
            else
                lblTotal5.Text = $"Total Price: {countStagioni.Value * 15}$";
        }

        private void btnMarg_Click(object sender, EventArgs e)
        {
            if (countMarg.Value == 0) countMarg.Value = 0;
            else
            {
                int index = lbShop.FindStringExact(totalPrice);
                total += countMarg.Value * 10;
                totalPrice = "Total Price: " + total + "$";
                lbShop.Items.RemoveAt(index);
                lbShop.Items.Add(countMarg.Value + " x Margharita - > " + countMarg.Value * 10 + " $");
                lbShop.Items.Add(totalPrice);
                countMarg.Value = 0;
            }
        }


        private void btnCapri_Click(object sender, EventArgs e)
        {
            if (countCapri.Value == 0) countCapri.Value = 0;
            else
            {
                int index = lbShop.FindStringExact(totalPrice);
                total += countCapri.Value * 11;
                totalPrice = "Total Price: " + total+"$";
                lbShop.Items.RemoveAt(index);
                lbShop.Items.Add(countCapri.Value + " x Capricciosa - > " + countCapri.Value * 11 + " $");
                lbShop.Items.Add(totalPrice);
                countCapri.Value = 0;
            }
        }

        private void btnTuna_Click(object sender, EventArgs e)
        {
            if (countTuna.Value == 0) countTuna.Value = 0;
            else
            {
                int index = lbShop.FindStringExact(totalPrice);
                total += countTuna.Value * 11;
                totalPrice = "Total Price: " + total + "$";
                lbShop.Items.RemoveAt(index);
                lbShop.Items.Add(countTuna.Value + " x Tuna - > " + countTuna.Value * 11 + " $");
                lbShop.Items.Add(totalPrice);
                countTuna.Value = 0;
            }
        }

        private void btnFormaggi_Click(object sender, EventArgs e)
        {
            if (countFormaggi.Value == 0) countFormaggi.Value = 0;
            else
            {
                int index = lbShop.FindStringExact(totalPrice);
                total += countFormaggi.Value * 14;
                totalPrice = "Total Price: " + total + "$";
                lbShop.Items.RemoveAt(index);
                lbShop.Items.Add(countFormaggi.Value + " x Quattro Formaggi - > " + countFormaggi.Value * 11 + " $");
                lbShop.Items.Add(totalPrice);
                countFormaggi.Value = 0;
            }
        }

        private void btnStagioni_Click(object sender, EventArgs e)
        {
            if (countStagioni.Value == 0) countStagioni.Value = 0;
            else
            {
                int index = lbShop.FindStringExact(totalPrice);
                total += countStagioni.Value * 15;
                totalPrice = "Total Price: " + total + "$";
                lbShop.Items.RemoveAt(index);
                lbShop.Items.Add(countStagioni.Value + " x Quattro Stagioni - > " + countStagioni.Value * 15 + " $");
                lbShop.Items.Add(totalPrice);
                countStagioni.Value = 0;
            }
        }

        private void lbShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            shopIndex = lbShop.SelectedIndex;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbShop.SelectedItem.ToString() != totalPrice) 
            {

                int index = lbShop.FindStringExact(totalPrice);
                string selectedString = lbShop.SelectedItem.ToString();
                string[] array = selectedString.Split(' ');

                int articleTotal = int.Parse(array[array.Length - 2].ToString());
                total -= articleTotal;
                totalPrice = "Total Price: " + total + "$";
                lbShop.Items.RemoveAt(index);
                lbShop.Items.RemoveAt(shopIndex);

                lbShop.Items.Add(totalPrice);
            }
        }
        
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (lbShop.Items.Count > 1)
            {
                int margh = 0, capri = 0, tuna = 0, formaggi = 0, stagioni = 0;
                foreach (string item in lbShop.Items)
                {
                    if (item.Contains("Margharita"))
                    {
                        string[] array = item.Split(' ');
                        margh += int.Parse(array[0]);
                    }
                    if (item.Contains("Capricciosa"))
                    {
                        string[] array = item.Split(' ');
                        capri += int.Parse(array[0]);
                    }
                    if (item.Contains("Tuna"))
                    {
                        string[] array = item.Split(' ');
                        tuna += int.Parse(array[0]);
                    }
                    if (item.Contains("Formaggi"))
                    {
                        string[] array = item.Split(' ');
                        formaggi += int.Parse(array[0]);
                    }
                    if (item.Contains("Stagioni"))
                    {
                        string[] array = item.Split(' ');
                        stagioni += int.Parse(array[0]);
                    }

                }
                frmConfirm frmConfirm = new frmConfirm(margh, capri, tuna, formaggi, stagioni, total);
                frmConfirm.ShowDialog();

            }
        }

        private void frmPresetPizza_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FrmHelp_PresetPizza frmHelp = new FrmHelp_PresetPizza();
                frmHelp.Show();

            }
        }
    }
 }

