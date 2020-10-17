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
    public partial class EditRemove_Mgonjwa : Form
    {
        public EditRemove_Mgonjwa()
        {
            InitializeComponent();
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            // browse images from your computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        bool verif()
        {

            if ((textBoxFirstName.Text.Trim() == "") ||
                (textBoxLastName.Text.Trim() == "") ||
                (textBoxPhoneNumber.Text.Trim() == "") ||
                (textBoxAddress.Text.Trim() == "") ||
                (pictureBox1.Image == null) ||
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


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //update the patient information
            // add new nurse
            try
            {
                sick sick = new sick();

                int id = Convert.ToInt32(textBoxID.Text);
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

                // we need to check the age of the nurse
                // the nurses age must be between 10-100
                int born_year = dateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;

                if (((this_year - born_year) < 1) || ((this_year - born_year) > 100))
                {

                    MessageBox.Show("The Nurse age must be between 1 and 100", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);

                    if (sick.updateMgonjwa(id, fname, lname, gender, dob, pnum, addrs, pic, cntry, city, email, psp, disease, dname))
                    {
                        MessageBox.Show("Patient Information Updated", "Update Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Update Patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Empty Fields", "Update Patient", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch 
            {
                MessageBox.Show("Enter a Valid Patient ID", "Update Patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            //remove the selected Nurse from the database
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                sick sick = new sick();

                //show a confirmation before deleting the nurse
                if (MessageBox.Show("Are You Sure You Want To Delete This Patient", "Delete Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (sick.deleteMgonjwa(id))
                    {
                        MessageBox.Show("Patient Deleted", "Delete Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clear fields
                        textBoxID.Text = "";
                        textBoxFirstName.Text = "";
                        textBoxLastName.Text = "";
                        textBoxAddress.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        textBoxPhoneNumber.Text = "";
                        textBoxCountry.Text = "";
                        textBoxCity.Text = "";
                        textBoxEmail.Text = "";
                        textBoxPassport.Text = "";
                        textBoxDisease.Text = "";
                        textBoxDoctorsName.Text = "";
                        pictureBox1.Image = null;

                    }
                    else
                    {
                        MessageBox.Show("Patient Not Deleted", "Delete Patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Enter a Valid Patient ID", "Delete Patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        

        private void buttonFind_Click(object sender, EventArgs e)
        {
            
            sick sick = new sick();
            //search nurse by id
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                MySqlCommand command = new MySqlCommand("SELECT `id`, `First_Name`, `Last_Name`, `Gender`, `Date_Of_Birth`, `Phone_Number`, `Address`, `Picture`, `Country`, `City`, `Email`, `Passport`, `Disease`, `Doctors_Name` FROM `mgonjwa` WHERE `id`=" + id);


                DataTable table = sick.getMgonjwa(command);

                if (table.Rows.Count > 0)
                {
                    textBoxFirstName.Text = table.Rows[0]["First_Name"].ToString();
                    textBoxLastName.Text = table.Rows[0]["Last_Name"].ToString();

                    //gender
                    if (table.Rows[0]["Gender"].ToString() == "Female")
                    {
                        radioButtonFemale.Checked = true;
                    }
                    else
                    {
                        radioButtonMale.Checked = true;
                    }
                    dateTimePicker1.Value = (DateTime)table.Rows[0]["Date_Of_Birth"];
                    textBoxPhoneNumber.Text = table.Rows[0]["Phone_Number"].ToString();
                    textBoxAddress.Text = table.Rows[0]["Address"].ToString();

                    //image
                    byte[] pic = (byte[])table.Rows[0]["Picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBox1.Image = Image.FromStream(picture);

                    textBoxCountry.Text = table.Rows[0]["Country"].ToString();
                    textBoxCity.Text = table.Rows[0]["City"].ToString();
                    textBoxEmail.Text = table.Rows[0]["Email"].ToString();
                    textBoxPassport.Text = table.Rows[0]["Passport"].ToString();
                    textBoxDisease.Text = table.Rows[0]["Disease"].ToString();
                    textBoxDoctorsName.Text = table.Rows[0]["Doctors_Name"].ToString();

                }
            }
            catch 
            {
                MessageBox.Show("Enter a Valid Patient ID", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Add_Nurse add_Nurse = new Add_Nurse();
            add_Nurse.Show();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxAddress.Text = "";
            pictureBox1.Image = null;
            textBoxCountry.Text = "";
            textBoxCity.Text = "";
            textBoxEmail.Text = "";
            textBoxPassport.Text = "";
            textBoxDisease.Text = "";
            textBoxDoctorsName.Text = "";
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow only numbers on keypress
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
