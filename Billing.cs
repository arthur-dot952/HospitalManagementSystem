using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hospital_Management_System_1
{
    class Billing
    {
        DB db = new DB();
        // create a function to add bill

        public bool insertBilling(string pID,string fname, string lname, string psp,  string assd, string charges, string tamount, string pamount, string bal)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `billing`( `Patient_ID`, `First_Name`, `Last_Name`, `ID_Passport`, `Assigned_Doctor_ID`, `Service_Charges`, `Total_Amount`, `Amount_Paid`, `Balance`) VALUES (@pID, @fname, @lname, @psp, @assd, @charges, @tamount, @pamount, @bal)", db.GetConnection());

            command.Parameters.Add("@pID", MySqlDbType.VarChar).Value = pID;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@psp", MySqlDbType.VarChar).Value = psp;
            command.Parameters.Add("@assd", MySqlDbType.VarChar).Value = assd;
            command.Parameters.Add("@charges", MySqlDbType.VarChar).Value = charges;
            command.Parameters.Add("@tamount", MySqlDbType.VarChar).Value = tamount;
            command.Parameters.Add("@pamount", MySqlDbType.VarChar).Value = pamount;
            command.Parameters.Add("@bal", MySqlDbType.VarChar).Value = bal;
         

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {

                db.CloseConnection();
                return true;
            }
            else
            {
                db.CloseConnection();
                return false;
            }
        }

    }
}
