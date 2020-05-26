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
    public partial class frmWorkerMenu : Form
    {
        public frmWorkerMenu()
        {
            InitializeComponent();
        }

        private void ChangeCursor(int coordinateY)
        {
            picCursor.Location = new Point(picCursor.Location.X, coordinateY);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ChangeCursor(btnHome.Location.Y + 22);

        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            ChangeCursor(btnBills.Location.Y + 20);

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            ChangeCursor(btnAbout.Location.Y + 20);

        }
    }
}
