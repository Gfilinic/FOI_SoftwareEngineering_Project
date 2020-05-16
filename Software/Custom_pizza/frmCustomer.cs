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
    public partial class frmCustomer : Form
    {
        bool logOutExpanded;
        private User currentUser;
        public frmCustomer(User user)
        {
            InitializeComponent();
            logOutExpanded = false;
            currentUser = user;
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            if (logOutExpanded == false)
            {
                logOutExpanded = true;
                pnlShutDown.Height += 200;
            }
            else
            {
                logOutExpanded = false;
                pnlShutDown.Height -= 200;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //to be implemented
        }
    }
}
