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
    public partial class frmAdminMenu : Form
    {
        frmMainMenu mainMenu;
        public frmAdminMenu()
        {
            InitializeComponent();
            ChangeCursor(btnHome.Location.Y+22);
        }


        private void ChangeCursor(int coordinateY)
        {
            picCursor.Location = new Point(picCursor.Location.X, coordinateY);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ChangeCursor(btnHome.Location.Y+22);
        }

        private void btnActions_Click(object sender, EventArgs e)
        {
            ChangeCursor(btnActions.Location.Y+20);

        }

        private void btnIngredients_Click(object sender, EventArgs e)
        {
            ChangeCursor(btnIngredients.Location.Y + 20);

        }

        private void btnPizzaMenu_Click(object sender, EventArgs e)
        {
            ChangeCursor(btnPizzaMenu.Location.Y + 20);

        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            ChangeCursor(btnStatistics.Location.Y + 20);
        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            ChangeCursor(btnWorkers.Location.Y + 20);
            frmAddRemoveWorkers frmAddRemoveWorkers = new frmAddRemoveWorkers();
            mainMenu = ActiveForm as frmMainMenu;
            mainMenu.OpenWorkBoard(frmAddRemoveWorkers);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            ChangeCursor(btnAbout.Location.Y + 20);
        }
    }
}
