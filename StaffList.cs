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
    public partial class StaffList : Form
    {
        public StaffList()
        {
            InitializeComponent();
        }

        Staff daktari = new Staff();
        private void Doctors_Load(object sender, EventArgs e)
        {

            // populate the datagridview with nurse data
            MySqlCommand command = new MySqlCommand("SELECT * FROM `daktari");
            dataGridView2.ReadOnly = true;
            DataGridViewImageColumn piCol = new DataGridViewImageColumn();
            dataGridView2.RowTemplate.Height = 80;
            dataGridView2.DataSource = daktari.getDaktari(command);
            piCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView2.AllowUserToAddRows = false;

        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            //// dispalay the selected doctor in a new form to edit/remove
            // dispalay the selected nurse in a new form to edit/remove
          
            EditRemove_Doctor edit = new EditRemove_Doctor();
            edit.textBoxID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            edit.textBoxFirstName.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            edit.textBoxLastName.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();

            //gender
            if (dataGridView2.CurrentRow.Cells[3].Value.ToString() == "Female")
            {
                edit.radioButtonFemale.Checked = true;
            }

            edit.dateTimePicker1.Value = (DateTime)dataGridView2.CurrentRow.Cells[4].Value;
            edit.textBoxPhoneNumber.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            edit.textBoxAddress.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();

            //the image
            byte[] pic;
            pic = (byte[])dataGridView2.CurrentRow.Cells[7].Value;
            MemoryStream Picture = new MemoryStream(pic);
            edit.pictureBox2.Image = Image.FromStream(Picture);

            edit.textBoxCountry.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
            edit.textBoxCity.Text = dataGridView2.CurrentRow.Cells[9].Value.ToString();
            edit.textBoxEmail.Text = dataGridView2.CurrentRow.Cells[10].Value.ToString();
            edit.textBoxPassport.Text = dataGridView2.CurrentRow.Cells[11].Value.ToString();
            edit.comboBoxAuthentication.Text = dataGridView2.CurrentRow.Cells[12].Value.ToString();

            edit.Show();
        

    }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            // refresh the datagridview data
            MySqlCommand command = new MySqlCommand("SELECT * FROM `daktari");
            dataGridView2.ReadOnly = true;
            DataGridViewImageColumn piCol = new DataGridViewImageColumn();
            dataGridView2.RowTemplate.Height = 70;
            dataGridView2.DataSource = daktari.getDaktari(command);
            piCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView2.AllowUserToAddRows = false;
        }
    }
}
