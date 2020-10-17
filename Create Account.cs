using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hospital_Management_System_1
{
    public partial class Create_Account : Form
    {
        public Create_Account()
        {
            InitializeComponent();
        }
        private void Create_Account_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }
        private void textBoxFirstName_Enter(object sender, EventArgs e)
        {
            String fname = textBoxFirstName.Text;
            if (fname.Equals("First Name"))

            {

                textBoxFirstName.Text = "";
                textBoxFirstName.ForeColor = Color.Black;
            }
        }

        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            String fname = textBoxFirstName.Text;
            if (fname.ToLower().Trim().Equals("First Name") || fname.Trim().Equals(""))
            {

                textBoxFirstName.Text = "First Name";
                textBoxFirstName.ForeColor = Color.Gray;
            }

        }

        private void textBoxLastName_Enter(object sender, EventArgs e)
        {

            String lname = textBoxLastName.Text;
            if (lname.Equals("Last Name"))

            {

                textBoxLastName.Text = "";
                textBoxLastName.ForeColor = Color.Black;
            }
        }


        private void textBoxLastName_Leave(object sender, EventArgs e)
        {
            
                String lname = textBoxLastName.Text;
                if (lname.ToLower().Trim().Equals("Last Name") || lname.Trim().Equals(""))
                {

                    textBoxLastName.Text = "Last Name";
                    textBoxLastName.ForeColor = Color.Gray;
                }
            }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.Equals("Email"))

            {

                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("Email") || email.Trim().Equals(""))
            {

                textBoxEmail.Text = "Email";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            if (username.Equals("Username"))

            {

                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            if (username.ToLower().Trim().Equals("Username") || username.Trim().Equals(""))
            {

                textBoxUsername.Text = "Username";
                textBoxUsername.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.Equals("Password"))

            {

                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("Password") || password.Trim().Equals(""))
            {

                textBoxPassword.Text = "Password";
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxConfirmPassword_Enter(object sender, EventArgs e)
        {
            String cpassword = textBoxConfirmPassword.Text;
            if (cpassword.Equals("Confirm Password"))

            {

                textBoxConfirmPassword.Text = "";
                textBoxConfirmPassword.UseSystemPasswordChar = true;
                textBoxConfirmPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxConfirmPassword_Leave(object sender, EventArgs e)
        {
            String cpassword = textBoxConfirmPassword.Text;
            if (cpassword.ToLower().Trim().Equals("Confirm Password") ||
                cpassword.ToLower().Trim().Equals("Confirm Password") || cpassword.Trim().Equals(""))

            {

                textBoxConfirmPassword.Text = "Confirm Password";
                textBoxConfirmPassword.UseSystemPasswordChar = false;
                textBoxConfirmPassword.ForeColor = Color.Gray;
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin admin = new Admin();
            admin.Show();
            
        }

        private void labelClose_Enter(object sender, EventArgs e)
        {
           
        }

        private void labelClose_Leave(object sender, EventArgs e)
        {
           
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `user`(`FirstName`, `LastName`, `Email`, `username`, `password`,'authentication') VALUES (@fn, @ln, @email, @usn, @pass,@au)", db.GetConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textBoxFirstName.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = textBoxLastName.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;
            command.Parameters.Add("@au", MySqlDbType.VarChar).Value = comboBox1.Text;

            //open connection
            db.OpenConnection();

            //Check if the textboxes contain the default values
            if(!checkTextBoxesValues())
            {
                //check if the password equals the confirm password
                if(textBoxPassword.Text.Equals(textBoxConfirmPassword.Text))
                {

                    //check if this username already exist
                    if (checkUsername())
                    {
                        MessageBox.Show("This Username Already Exist, Select a Different One", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    }
                    else
                    {
                        //execute the qeuery
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your Account has been Created","Account Created", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ERROR");

                        }

                    }

                }
               else
                {
                    MessageBox.Show("Password Do Not Match","Password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
            
            else
            {
                MessageBox.Show("Enter Your Details First","Empty Data",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }


            //close connection
            db.CloseConnection();
        }

        //check if the username already exist
        public Boolean checkUsername()
        {
            DB db = new DB();
            string username = textBoxUsername.Text;
            string authentication = comboBox1.Text;


            DataTable table = new DataTable();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            MySqlCommand Command = new MySqlCommand("SELECT * FROM `user` WHERE `username` = @usn and 'authentication'= @au", db.GetConnection());

            Command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            Command.Parameters.Add("@au", MySqlDbType.VarChar).Value = authentication;


            Adapter.SelectCommand = Command;
            Adapter.Fill(table);

            if (table.Rows.Count > 0)
            {

                return true;
            }

            else
            {

                return false;
            }

           
        }
        //check if the textboxes contain a default value
        public Boolean checkTextBoxesValues()
        {
            string fname = textBoxFirstName.Text;
            string lname = textBoxLastName.Text;
            string email = textBoxEmail.Text;
            string uname = textBoxUsername.Text;
            string pass = textBoxPassword.Text;
            string au = comboBox1.Text;

            if (fname.Equals("First Name") || lname.Equals("Last Name") || email.Equals("Email") ||
                uname.Equals("Username") || pass.Equals("Password")|| au.Equals("authentication"))
            {

                return true;
            }else
            {
                return false;
            }


        }

        private void labelGoToLogin_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void labelGoToLogin_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void labelGoToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            comboBox1.Items.Add("Doc");
            comboBox1.Items.Add("Nurse");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
  }
    
