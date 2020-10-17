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
    public partial class EditRemove_Doctor : Form
    {
        public EditRemove_Doctor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
                pictureBox2.Image = Image.FromFile(opf.FileName);
            }
        }


        bool verif()
        {

            if ((textBoxFirstName.Text.Trim() == "") ||
                (textBoxLastName.Text.Trim() == "") ||
                (textBoxPhoneNumber.Text.Trim() == "") ||
                (textBoxAddress.Text.Trim() == "") ||
                (pictureBox2.Image == null) ||
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //update Staff
            try
            {
                Staff daktari = new Staff();

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
                string aut = comboBoxAuthentication.Text;

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

                if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                {

                    MessageBox.Show("The Staffs age must be between 10 and 100", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    pictureBox2.Image.Save(pic, pictureBox2.Image.RawFormat);

                    if (daktari.updateDaktari(id, fname, lname, gender, dob, pnum, addrs, pic, cntry, city, email, psp, aut))
                    {
                        MessageBox.Show("Staff Information Updated", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Empty Fields", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch 
            {
                MessageBox.Show("Enter a Valid Staff ID", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                Staff daktari = new Staff();

                //show a confirmation before deleting the nurse
                if (MessageBox.Show("Are You Sure You Want To Delete This Staff", "Delete Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (daktari.deleteDaktari(id))
                    {
                        MessageBox.Show("Staff Deleted", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        comboBoxAuthentication.Text = "";
                        pictureBox2.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Staff Not Deleted", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch 
            {
                MessageBox.Show("Enter a Valid Staff ID", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
          
            Staff daktari = new Staff();
            //search nurse by id
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                MySqlCommand command = new MySqlCommand("SELECT `id`, `first name`, `last name`, `gender`, `date of birth`, `phone number`, `address`, `picture`, `country`, `city`, `email`, `ID/Passport`, `Authentication` FROM `daktari` WHERE `id`=" + id);


                DataTable table = daktari.getDaktari(command);

                if (table.Rows.Count > 0)
                {
                    textBoxFirstName.Text = table.Rows[0]["first name"].ToString();
                    textBoxLastName.Text = table.Rows[0]["last name"].ToString();

                    //gender
                    if (table.Rows[0]["gender"].ToString() == "Female")
                    {
                        radioButtonFemale.Checked = true;
                    }
                    else
                    {
                        radioButtonMale.Checked = true;
                    }
                    dateTimePicker1.Value = (DateTime)table.Rows[0]["date of birth"];
                    textBoxPhoneNumber.Text = table.Rows[0]["phone number"].ToString();
                    textBoxAddress.Text = table.Rows[0]["address"].ToString();

                    //image
                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBox2.Image = Image.FromStream(picture);

                    textBoxCountry.Text = table.Rows[0]["country"].ToString();
                    textBoxCity.Text = table.Rows[0]["city"].ToString();
                    textBoxEmail.Text = table.Rows[0]["email"].ToString();
                    textBoxPassport.Text = table.Rows[0]["ID/Passport"].ToString();
                    comboBoxAuthentication.Text = table.Rows[0]["Authentication"].ToString();
                }
            
            }
            catch
            {
                MessageBox.Show("Enter a Valid Staff ID", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxAddress.Text = "";
            pictureBox2.Image = null;
            textBoxCountry.Text = "";
            textBoxCity.Text = "";
            textBoxEmail.Text = "";
            textBoxPassport.Text = "";
            comboBoxAuthentication.Text = "";
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow only numbers on keypress
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EditRemove_Doctor_Load(object sender, EventArgs e)
        {

        }
    }
}
