using MySql.Data.MySqlClient;
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
    public partial class LoginForm : Form
    {
       
        public LoginForm()
        {
            InitializeComponent();
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.();
            Shalom_Hospital_Management_System shalom_Hospital_ = new Shalom_Hospital_Management_System();
            shalom_Hospital_.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
             DB db = new DB();


            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string authentication = comboBox1.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            MySqlCommand Command = new MySqlCommand("SELECT * FROM `user` WHERE `username`=@usn and `password`=@pass and 'authentication' =@au", db.GetConnection());

            Command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            Command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            Command.Parameters.Add("@au", MySqlDbType.VarChar).Value = authentication;

            Adapter.SelectCommand = Command;
            Adapter.Fill(table);

            if (textBoxUsername.Text == "Doctor" && textBoxPassword.Text == "1234" && comboBox1.Text== "Doc") 
            {
                this.Hide();
                Home_Page home_Page = new Home_Page();
                home_Page.Show();
               
            }else if(textBoxUsername.Text == "Admin" && textBoxPassword.Text == "Admin" && comboBox1.Text=="Admin")
            {
                this.Hide();
                Admin admin = new Admin();
                admin.Show();

            }else if(textBoxUsername.Text == "Nurse" && textBoxPassword.Text == "123456" && comboBox1.Text=="Nurse")
            {
                this.Hide();
                Add_Nurse add_Nurse = new Add_Nurse();
                add_Nurse.Show();
            }

            else
            {
                if(username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username To Login","Empty Username",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (authentication.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Correct Authentication", "Wrong Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Wrong Username Or Password Or Authentication", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            comboBox1.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Create_Account create_Account = new Create_Account();
            create_Account.Show();
        }
    }
}
