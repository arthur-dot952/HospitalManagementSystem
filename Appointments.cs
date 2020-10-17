using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hospital_Management_System_1
{
    class Appointments
    {
        // create a fucntion to add a new patient appointment to the database
        DB db = new DB();
        public bool insertAppointment(string pID, string fname, string lname,string ctype, DateTime bdate,string atype,  string dname, string psp)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `appointment`( `Patient_ID`, `First_Name`, `Last_Name`, `Case_Type`, `Date`, `Appointment_Type`, `Doctors_Name`, `Passport`) VALUES (@pID, @fname, @lname, @ctype, @bdate, @atype, @dname, @psp)", db.GetConnection());

            command.Parameters.Add("@pID", MySqlDbType.Int32).Value = pID;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@ctype", MySqlDbType.VarChar).Value = ctype;
            command.Parameters.Add("@bdate", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@atype", MySqlDbType.VarChar).Value = atype;
            command.Parameters.Add("@dname", MySqlDbType.VarChar).Value = dname;
            command.Parameters.Add("@psp", MySqlDbType.VarChar).Value = psp;

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

        // create a function
        // craeate a function to return a table of nurses list
        public DataTable getAppointment(MySqlCommand command)
        {
            command.Connection = db.GetConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        //create a function to update the Patient information
        public bool updateAppointment(int id, string pID,string fname, string lname, string ctype, DateTime bdate, string atype, string dname, string psp)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `appointment` SET `Patient_ID`=@pID,`First_Name`=@fname,`Last_Name`=@lname,`Case_Type`=@ctype,`Date`=@bdate,`Appointment_Type`=@atype,`Doctors_Name`=@dname,`Passport`=@psp WHERE `id` =@ID", db.GetConnection());


            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@pID", MySqlDbType.VarChar).Value = pID;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@ctype", MySqlDbType.VarChar).Value = ctype;
            command.Parameters.Add("@bdate", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@atype", MySqlDbType.VarChar).Value = atype;
            command.Parameters.Add("@dname", MySqlDbType.VarChar).Value = dname;
            command.Parameters.Add("@psp", MySqlDbType.VarChar).Value = psp;
           

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
        //delete the selected patient
        public bool deleteAppointment(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `appointment` WHERE `id`=@TID", db.GetConnection());


            command.Parameters.Add("@TID", MySqlDbType.Int32).Value = id;

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
