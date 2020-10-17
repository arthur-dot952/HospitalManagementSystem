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
    public partial class Billing_Form : Form
    {
        public Billing_Form()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Add_Nurse add_Nurse = new Add_Nurse();
            add_Nurse.Show();
        }

        private void ButtonAddBill_Click(object sender, EventArgs e)
        {
            // add new bills
            Billing bills = new Billing();

            string pID = TextBoxPatientID.Text;
            string fname = TextBoxFirstName.Text;
            string lname = textBoxLastName.Text;
            string psp = textBoxPassport.Text;
            string assd = TextBoxAssignedDoctorID.Text;
            string charges = TextBoxServicesCharges.Text;
            string tamount = TextBoxTotal.Text;
            string pamount = TextBoxAmount.Text;
            string bal = TextBoxBalance.Text;

            MemoryStream pic = new MemoryStream();

            if ((TextBoxPatientID.Text == "") ||
                (TextBoxFirstName.Text == "") ||
                (textBoxLastName.Text == "") ||
                (textBoxPassport.Text == "") ||
                (TextBoxAssignedDoctorID.Text == "") ||
                (TextBoxServicesCharges.Text == "") ||
                (TextBoxTotal.Text == "") ||
                (TextBoxAmount.Text == "") ||
                (TextBoxBalance.Text == ""))
            {
                MessageBox.Show("Empty Fields", "Insert Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                if (bills.insertBilling(pID,fname, lname, psp, assd, charges, tamount, pamount,bal))
                {
                    MessageBox.Show("Bill Added", "Add  Bill Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Bill", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Bill", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }

        // create a fucntion to verify data

        bool verif()
        {

            if ((TextBoxFirstName.Text.Trim() == "") ||
                (textBoxLastName.Text.Trim() == "") ||
                (textBoxPassport.Text.Trim() == "") ||
                (TextBoxAssignedDoctorID.Text.Trim() == "") ||
                (TextBoxServicesCharges.Text.Trim() == "") ||
                (TextBoxTotal.Text.Trim() == "") ||
                (TextBoxAmount.Text.Trim() == "") ||
                (TextBoxBalance.Text.Trim() == ""))


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
            TextBoxPatientID.Text = "";
            TextBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPassport.Text = "";
            TextBoxAssignedDoctorID.Text = "";
            TextBoxServicesCharges.Text = "";
            TextBoxTotal.Text = "";
            TextBoxAmount.Text ="";
            TextBoxBalance.Text = "";
        }

        private void TextBoxAmount_TextChanged(object sender, EventArgs e)
        {
            Billing bills = new Billing();
            NewMethod();
        }

        private void NewMethod()
        {
            if (TextBoxTotal.Text != "" && TextBoxAmount.Text != "")
            {
                decimal balance = Convert.ToInt32(TextBoxTotal.Text) - Convert.ToInt32(TextBoxAmount.Text);
                TextBoxBalance.Text = balance.ToString();
            }
            else
            {
                TextBoxBalance.Text = "0";
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonPview_Click(object sender, EventArgs e)
        {
           
        }

        private void TextBoxTotal_TextChanged(object sender, EventArgs e)
        {
            NewMethod();
        }
    }
}
