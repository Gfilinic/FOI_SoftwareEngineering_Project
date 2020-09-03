using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase;
using DiscountSettingsClass;
using Custom_pizza.HelpForms;

namespace Custom_pizza
{
    public partial class frmDiscountMenu : Form
    {
        public frmDiscountMenu()
        {
            InitializeComponent();
            
            ShowDiscounts();
            dgvDiscount.Columns[0].Visible = false;
            dgvDiscount.Columns[1].HeaderText = "Discount Name";
            dgvDiscount.Columns[2].Visible = false;
            dgvDiscount.Columns[3].HeaderText = "Description";
            dgvDiscount.Columns[4].HeaderText = "Begins";
            dgvDiscount.Columns[5].HeaderText = "Ends";
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

       

        DiscountRepository discountRepository = new DiscountRepository();

        Thread threadRegister, threadApp;

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            threadRegister = new Thread(OpenAddNewDiscount);
            threadRegister.SetApartmentState(ApartmentState.STA);
            threadRegister.Start();
        }

        private void OpenAddNewDiscount()
        {
            Application.Run(new frmAddNewDiscount());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowDiscounts();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            threadRegister = new Thread(OpenModDiscount);
            threadRegister.SetApartmentState(ApartmentState.STA);
            threadRegister.Start();
        }

        private void OpenModDiscount()
        {
            if (dgvDiscount.CurrentRow != null)
            {
                Discount discount = dgvDiscount.CurrentRow.DataBoundItem as Discount;
                Application.Run(new frmModDiscount(discount));
            }
            else
            {
                MessageBox.Show("Please select a row", "Warning Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Run(new frmDiscountMenu());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDiscount.CurrentRow != null)
            {
                discountRepository.DeleteDiscount(dgvDiscount.CurrentRow.DataBoundItem as Discount);
            }
            else
            {
                MessageBox.Show("Please select a row", "Warning Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ShowDiscounts();
        }

        private void frmDiscountMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmHelp_DiscountMenu frmHelp = new frmHelp_DiscountMenu();
                frmHelp.ShowDialog();

            }
        }

        private void ShowDiscounts()
        {
            List<Discount> List = new List<Discount>();
            List = discountRepository.GetAllDiscounts();

            dgvDiscount.DataSource = List;
            
        }
    }
}
