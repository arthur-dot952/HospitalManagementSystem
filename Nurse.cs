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
    public partial class Add_Nurse : Form
    {
        public Add_Nurse()
        {
            InitializeComponent();
        }

        private void eDITLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDDNURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDDNEWPATIENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           Mgonjwaa mgonjwa = new Mgonjwaa();
            mgonjwa.Show(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void bOOKAPPOINTMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        

        private void bOOKAPPOINTMENTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Appointment add_Appointment = new Add_Appointment();
            add_Appointment.Show();
        }

        private void aPPOINMENTDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            AppointmentDetails details = new AppointmentDetails();
            details.Show();
        }

        private void aDDNURSEToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bILLINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Billing_Form billing_Form = new Billing_Form();
            billing_Form.Show();
        }

        private void sIGNOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void eDITREMOVEPATIENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditRemove_Mgonjwa mgonjwa = new EditRemove_Mgonjwa();
            mgonjwa.Show();
        }

        private void mANAGEPATIENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Mgonjwa_List list = new Mgonjwa_List();
            list.Show(this);
        }
    }
}
