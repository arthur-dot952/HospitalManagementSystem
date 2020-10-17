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
    public partial class Add_New_Doctor : Form
    {
        public Add_New_Doctor()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.Show();
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

        private void buttonADD_Click(object sender, EventArgs e)
        {
            // add new doctor
            Staff daktari = new Staff();

            string fname = textBoxFirstName.Text;
            string lname = textBoxLastName.Text;
            DateTime dob = dateTimePicker1.Value;
            string pnum = textBoxPhoneNumber.Text;
            string addrs = textBoxAddress.Text;
            string cntry = textBoxCountry.Text;
            string city = textBoxCity.Text;
            string email = textBoxEmail.Text;
            string psp = textBoxPassport.Text;
            string aut = comboBoxAuthentication.Text;
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

            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {

                MessageBox.Show("The Staffs age must be between 10 and 100", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                pictureBoxImage.Image.Save(pic, pictureBoxImage.Image.RawFormat);

                if (daktari.insertDaktari(fname, lname, gender, dob, pnum, addrs, pic, cntry, city, email, psp, aut))
                {
                    MessageBox.Show("New Staff Added", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        // create a fucntion to verify the data
        bool verif()
        {

            if ((textBoxFirstName.Text.Trim() == "") ||
                (textBoxLastName.Text.Trim() == "") ||
                (textBoxPhoneNumber.Text.Trim() == "") ||
                (textBoxAddress.Text.Trim() == "") ||
                (pictureBoxImage.Image == null) ||
                (textBoxCountry.Text.Trim() == "") ||
                (textBoxCity.Text.Trim() == "") ||
                 (textBoxPassport.Text.Trim() == "") ||
                  (comboBoxAuthentication.Text.Trim() == "") ||
                (textBoxEmail.Text.Trim() == ""))

            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxAddress.Text = "";
            textBoxCountry.Text = "";
            textBoxCity.Text = "";
            textBoxEmail.Text = "";
            textBoxPassport.Text = "";
            comboBoxAuthentication.Text = "";
            pictureBoxImage.Image = null;
            
        }

       
    }
}
