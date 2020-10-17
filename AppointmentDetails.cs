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
    public partial class AppointmentDetails : Form
    {
        public AppointmentDetails()
        {
            InitializeComponent();
        }
      
        Appointments app = new Appointments();
        private void AppointmentDetails_Load(object sender, EventArgs e)
        {
            // populate the datagridview with Appointment data
            MySqlCommand command = new MySqlCommand("SELECT * FROM `appointment`");
            dataGridView2.ReadOnly = true;
            DataGridViewImageColumn piCol = new DataGridViewImageColumn();
            dataGridView2.RowTemplate.Height = 70;
            dataGridView2.DataSource = app.getAppointment(command);
            dataGridView2.AllowUserToAddRows = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            // refresh the datagridview data
            MySqlCommand command = new MySqlCommand("SELECT * FROM `appointment`");
            dataGridView2.ReadOnly = true;
            DataGridViewImageColumn piCol = new DataGridViewImageColumn();
            dataGridView2.RowTemplate.Height = 70;
            dataGridView2.DataSource = app.getAppointment(command);
            dataGridView2.AllowUserToAddRows = false;
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            // dispalay the selected Appointment form
            UpdateDelete_Appointment edit = new UpdateDelete_Appointment();
            edit.textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            edit.textBoxPatientID.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            edit.textBoxFirstName.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            edit.textBoxLastName.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            edit.comboBoxCaseType.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            edit.DateTimePicker1.Value = (DateTime)dataGridView2.CurrentRow.Cells[5].Value;
            edit.ComboBoxAppointmentType.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            edit.TextBoxDoctorsName.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            edit.TextBoxPassport.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();


            edit.Show();


        }
    }
}
