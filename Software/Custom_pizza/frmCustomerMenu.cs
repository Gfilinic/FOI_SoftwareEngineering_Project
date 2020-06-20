using BillSettingsClass;
using CustomPizza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserSettingsClass;

namespace Custom_pizza
{
    public partial class frmCustomerMenu : Form
    {
        frmMainMenu mainMenu;
        User currentUser;
        int idBill;
        public frmCustomerMenu(User currentUser, int idBill)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.idBill = idBill;

        }

        private void ChangeCursor(int coordinateY)
        {
            picCursor.Location = new Point(picCursor.Location.X, coordinateY);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ChangeCursor(btnHome.Location.Y + 20);
        }

        private void btnCustomPizzas_Click(object sender, EventArgs e)
        {
            ChangeCursor(btnCustomPizzas.Location.Y + 20);
            fmrCustomPizza fmrCustomPizza = new fmrCustomPizza(currentUser, idBill);
            mainMenu = ActiveForm as frmMainMenu;
            mainMenu.OpenWorkBoard(fmrCustomPizza);
        }

        private void btnPresetPizzas_Click(object sender, EventArgs e)
        {
            ChangeCursor(btnPresetPizzas.Location.Y + 20);

        }

        private void btnTimeTillDelivery_Click(object sender, EventArgs e)
        {
            ChangeCursor(btnTimeTillDelivery.Location.Y + 20);

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            ChangeCursor(btnAbout.Location.Y + 20);

        }
    }
}
