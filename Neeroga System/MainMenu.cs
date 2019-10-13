using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neeroga_System
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void assNewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patient_Registration pg = new Patient_Registration();
            pg.Show();
        }

        private void viewPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Appointment appoint = new Appointment();
            appoint.Show();
        }

        private void consultantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultant consultant = new Consultant();
            consultant.Show();
        }

        private void userManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_User usermanager = new New_User();
            usermanager.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
