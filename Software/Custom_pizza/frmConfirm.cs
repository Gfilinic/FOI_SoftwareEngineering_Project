using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_pizza
{
    public partial class frmConfirm : Form
    {
        public frmConfirm(int margh, int capri, int tuna, int formaggi, int stagioni, decimal total)
        {
            InitializeComponent();
            if (margh > 0)
            {
                lbConfirm.Items.Add(margh + " x Margherita - > " + margh * 10 + " $");
            }
            if (capri > 0)
            {
                lbConfirm.Items.Add(capri + " x Capricciosa - > " + capri * 11 + " $");
            }
            if (tuna > 0)
            {
                lbConfirm.Items.Add(tuna + " x Al Tonno - > " + tuna * 11 + " $");
            }
            if (formaggi > 0)
            {
                lbConfirm.Items.Add(formaggi + " x Al Tonno - > " + formaggi * 14 + " $");
            }
            if (stagioni > 0)
            {
                lbConfirm.Items.Add(stagioni + " x Al Tonno - > " + stagioni * 15 + " $");
            }
            lblTotal.Text = total.ToString()+"$";
            lblDate.Text = DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Succesful!","Order");
            this.Close();
        }
    }
}
