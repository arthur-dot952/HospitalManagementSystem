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
    public partial class Mgonjwaa : Form
    {
        public Mgonjwaa()
        {
            InitializeComponent();
        }

        private void Mgonjwa_Load(object sender, EventArgs e)
        {

        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            // browse images from your computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // add new patient
            
            sick sick = new sick();

            string fname = textBoxFirstName.Text;
            string lname = textBoxLastName.Text;
            DateTime dob = dateTimePicker1.Value;
            string pnum = textBoxPhoneNumber.Text;
            string addrs = textBoxAddress.Text;
            string cntry = textBoxCountry.Text;
            string city = textBoxCity.Text;
            string email = textBoxEmail.Text;
            string psp = textBoxPassport.Text;
            string disease = textBoxDisease.Text;
            string dname = textBoxDoctorsName.Text;
            string gender = "Male";

            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();

            // we need to check the age of the doctors
            // the doctors age must be between 10-100
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 1) || ((this_year - born_year) > 100))
            {

                MessageBox.Show("The Patients age must be between 1 and 100", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                pictureBoxImage.Image.Save(pic, pictureBoxImage.Image.RawFormat);

                if (sick.insertMgonjwa(fname, lname, gender, dob, pnum, addrs, pic, cntry, city, email, psp, disease,dname))
                {
                    MessageBox.Show("New Patient Added", "Add Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Patient", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




        }

        // create a function to verify data
        bool verif()
        {

            if ((textBoxFirstName.Text.Trim() == "") ||
                (textBoxLastName.Text.Trim() == "") ||
                (textBoxPhoneNumber.Text.Trim() == "") ||
                (textBoxAddress.Text.Trim() == "") ||
                (pictureBoxImage.Image == null) ||
                (textBoxCountry.Text.Trim() == "") ||
                (textBoxCity.Text.Trim() == "") ||
                 (textBoxEmail.Text.Trim() == "") ||
                 (textBoxPassport.Text.Trim() == "") ||
                  (textBoxDisease.Text.Trim() == "") ||
                   (textBoxDoctorsName.Text.Trim() == ""))
               

            {
                return false;
            }
            else
            {
                return true;
            }


        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Nurse nurse = new Add_Nurse();
            nurse.Show();


        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxAddress.Text = "";
            pictureBoxImage.Image = null;
            textBoxCountry.Text = "";
            textBoxCity.Text = "";
            textBoxEmail.Text = "";
            textBoxPassport.Text = "";
            textBoxDisease.Text = "";
            textBoxDoctorsName.Text = "";
        }
    }
}
