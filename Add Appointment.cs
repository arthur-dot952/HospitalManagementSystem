using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System_1
{
    public partial class Add_Appointment : Form
    {
        public Add_Appointment()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Nurse add_Nurse = new Add_Nurse();
            add_Nurse.Show();
        }

        private void ButtonADD_Click(object sender, EventArgs e)
        {
            // add a new patient appointment
            Appointments app = new Appointments();

            string pID = textBoxPatientID.Text;
            string fname = textBoxFirstName.Text;
            string lname = textBoxLastName.Text;
            string ctype = comboBoxCaseType.Text;
            DateTime bdate = DateTimePicker1.Value;
            string atype = ComboBoxAppointmentType.Text;
            string dname = TextBoxDoctorsName.Text;
            string psp = TextBoxPassport.Text;

            MemoryStream pic = new MemoryStream();

            if ((textBoxPatientID.Text == "") ||
                (textBoxFirstName.Text =="")||
                (textBoxLastName.Text == "")||
                (comboBoxCaseType.Text == "")||
                (ComboBoxAppointmentType.Text =="")||
                (TextBoxDoctorsName.Text == "")||
                (TextBoxPassport.Text == ""))
            {
                MessageBox.Show("Empty Fields", "Insert Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (verif())
            {
                if (app.insertAppointment(pID, fname, lname, ctype, bdate, atype, dname, psp))
                {
                    MessageBox.Show("Appointment Added", "Add  Appointment Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


                       
        }

        // create a fucntion to verify data

        bool verif()
        {

            if ((textBoxPatientID.Text.Trim() == "") ||
                (textBoxFirstName.Text.Trim() == "") ||
                (textBoxLastName.Text.Trim() == "") ||
                (comboBoxCaseType.Text.Trim() == "") ||
                (ComboBoxAppointmentType.Text.Trim() == "") ||
                (TextBoxDoctorsName.Text.Trim() == "") ||
                 (TextBoxPassport.Text.Trim() == "")) 


            {
                return false;
            }
            else
            {
                return true;
            }


        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBoxDoctorsName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxAppointmentType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCaseType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPatientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxPassport_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
