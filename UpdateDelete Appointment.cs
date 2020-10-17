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
using MySql.Data.MySqlClient;

namespace Hospital_Management_System_1
{
    public partial class UpdateDelete_Appointment : Form
    {
        public UpdateDelete_Appointment()
        {
            InitializeComponent();
        }


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
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // add a new patient appointment

            try {
                Appointments app = new Appointments();

                int id = Convert.ToInt32(textBox1.Text);
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
                    (textBoxFirstName.Text == "") ||
                    (textBoxLastName.Text == "") ||
                    (comboBoxCaseType.Text == "") ||
                    (ComboBoxAppointmentType.Text == "") ||
                    (TextBoxDoctorsName.Text == "") ||
                    (TextBoxPassport.Text == ""))
                {
                    MessageBox.Show("Empty Fields", "Insert Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    if (app.updateAppointment(id, pID, fname, lname, ctype, bdate, atype, dname, psp))
                    {
                        MessageBox.Show("Appointment Updated", "Update Appointment Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Update Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Update Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch 
            {
                MessageBox.Show("Enter a Valid Appointment ID", "Update Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonADD_Click(object sender, EventArgs e)
        {
            //remove the selected Appointment from the database
            try
            {
                int id = Convert.ToInt32(textBox1.Text);
               Appointments app = new Appointments();
                

                //show a confirmation before deleting the nurse
                if (MessageBox.Show("Are You Sure You Want To Delete This Appointment", "Delete Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (app.deleteAppointment(id))
                    {
                        MessageBox.Show("Appointment Deleted", "Delete Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clear fields
                        textBox1.Text = "";
                        textBoxPatientID.Text = "";
                        textBoxFirstName.Text = "";
                        textBoxLastName.Text = "";
                        comboBoxCaseType.Text = "";
                        DateTimePicker1.Value = DateTime.Now;
                        ComboBoxAppointmentType.Text = "";
                        TextBoxDoctorsName.Text = "";
                        TextBoxPassport.Text = "";
                       

                    }
                    else
                    {
                        MessageBox.Show("Appointment Not Deleted", "Delete Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Enter a Valid Appointment ID", "Delete Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {        
            //search Appointment by id
            try
            {
                Appointments app = new Appointments();
                int id = Convert.ToInt32(textBox1.Text);
                MySqlCommand command = new MySqlCommand("SELECT `id`, `Patient_ID`, `First_Name`, `Last_Name`, `Case_Type`, `Date`, `Appointment_Type`, `Doctors_Name`, `Passport` FROM `appointment` WHERE `id`=" + id);


                DataTable table = app.getAppointment(command);

                if (table.Rows.Count > 0)
                {
                    textBoxPatientID.Text = table.Rows[0]["Patient_ID"].ToString();
                    textBoxFirstName.Text = table.Rows[0]["First_Name"].ToString();
                    textBoxLastName.Text = table.Rows[0]["Last_Name"].ToString();
                    comboBoxCaseType.Text = table.Rows[0]["Case_Type"].ToString();
                    DateTimePicker1.Value = (DateTime)table.Rows[0]["Date"];
                    ComboBoxAppointmentType.Text = table.Rows[0]["Appointment_Type"].ToString();
                    TextBoxDoctorsName.Text = table.Rows[0]["Doctors_Name"].ToString();
                    TextBoxPassport.Text = table.Rows[0]["Passport"].ToString();

                }
            }
            catch 
            {
                MessageBox.Show("Enter a Valid Appointment ID", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow only numbers on keypress
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBoxPatientID.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            comboBoxCaseType.Text = "";
            ComboBoxAppointmentType.Text = "";
            TextBoxDoctorsName.Text = "";
            TextBoxPassport.Text = "";
            
        }
    }
}
