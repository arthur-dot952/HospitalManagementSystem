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
    public partial class Shalom_Hospital_Management_System : Form
    {
        public Shalom_Hospital_Management_System()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimise_Click(object sender, EventArgs e)
        {
            
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            Panel panel = new Panel();
            panel.Show();          
           
            dataGridView1.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cONTACTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Shalom_Hospital_Management_System_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonExit_BackColorChanged(object sender, EventArgs e)
        {
            buttonExit.ForeColor = Color.White;
        }
    }
}
