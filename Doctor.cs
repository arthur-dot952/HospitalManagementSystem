using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System_1
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        private void Home_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void sIGNOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Application.Exit();
        }

        private void pATIENTSINFORMATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mgonjwa_List list = new Mgonjwa_List();
            list.Show(this);
        }

        private void aPPOINTMENTDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            AppointmentDetails details = new AppointmentDetails();
            details.Show();
        }
    }
}
