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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void aDDDOCTORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_New_Doctor add_New_Doctor = new Add_New_Doctor();
            add_New_Doctor.Show();
        }

        private void aDDNURSEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_New_Doctor add_New_Doctor = new Add_New_Doctor();
            add_New_Doctor.Show();
        }

        private void sIGNOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void eDITREMOVEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditRemove_Doctor editRemove_Doctor = new EditRemove_Doctor();
            editRemove_Doctor.Show();
        }

        private void eDITREMOVEDOCTORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditRemove_Doctor editRemove_Doctor = new EditRemove_Doctor();
            editRemove_Doctor.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Application.Exit();
        }

        private void nURSELISTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StaffList doctorsList = new StaffList();
            doctorsList.Show(this);
        }

        private void dOCTORINFORMATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffList doctorsList = new StaffList();
            doctorsList.Show(this);
        }

        private void lISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffList doctorsList = new StaffList();
            doctorsList.Show(this);
        }

        private void aDDNURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDDSTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_New_Doctor add_New_Doctor = new Add_New_Doctor();
            add_New_Doctor.Show();
        }

        private void eDITREMOVESTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditRemove_Doctor editRemove_Doctor = new EditRemove_Doctor();
            editRemove_Doctor.Show();
        }

        private void cREATEACCOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_Account create = new Create_Account();
            create.Show();
        }
    }
}
