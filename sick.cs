using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hospital_Management_System_1
{
    class sick
    {

        DB db = new DB();

        //create a function to add a new doctor to the database
        public bool insertMgonjwa(string fname, string lname, string gender, DateTime dob, string pnum, string addrs, MemoryStream picture, string cntry, string city, string email, string psp, string disease, string dname)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `mgonjwa`(`First_Name`, `Last_Name`, `Gender`, `Date_Of_Birth`, `Phone_Number`, `Address`, `Picture`, `Country`, `City`, `Email`, `Passport`, `Disease`, `Doctors_Name`) VALUES(@fname, @lname, @gender, @dob, @pnum, @addrs, @pic, @cntry, @city, @email, @psp, @disease, @dname)", db.GetConnection());

            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@dob", MySqlDbType.Date).Value = dob;
            command.Parameters.Add("@pnum", MySqlDbType.VarChar).Value = pnum;
            command.Parameters.Add("@addrs", MySqlDbType.VarChar).Value = addrs;
            command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray();
            command.Parameters.Add("@cntry", MySqlDbType.VarChar).Value = cntry;
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@psp", MySqlDbType.VarChar).Value = psp;
            command.Parameters.Add("@disease", MySqlDbType.VarChar).Value = disease;
            command.Parameters.Add("@dname", MySqlDbType.VarChar).Value = dname;

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

        // craeate a function to return a table of nurses list
        public DataTable getMgonjwa(MySqlCommand command)
        {
            command.Connection = db.GetConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }


        //create a function to update the Patient information
        public bool updateMgonjwa(int id, string fname, string lname, string gender, DateTime dob, string pnum, string addrs, MemoryStream picture, string cntry, string city, string email, string psp, string disease, string dname)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `mgonjwa` SET `First_Name`=@fname,`Last_Name`=@lname,`Gender`=@gender,`Date_Of_Birth`=@dob,`Phone_Number`=@pnum,`Address`=@addrs,`Picture`=@pic,`Country`=@cntry,`City`=@city,`Email`=@email,`Passport`=@psp,`Disease`=@disease,`Doctors_Name`=@dname WHERE `id`=@ID", db.GetConnection());


            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@dob", MySqlDbType.Date).Value = dob;
            command.Parameters.Add("@pnum", MySqlDbType.VarChar).Value = pnum;
            command.Parameters.Add("@addrs", MySqlDbType.VarChar).Value = addrs;
            command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray();
            command.Parameters.Add("@cntry", MySqlDbType.VarChar).Value = cntry;
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@psp", MySqlDbType.VarChar).Value = psp;
            command.Parameters.Add("@disease", MySqlDbType.VarChar).Value = disease;
            command.Parameters.Add("@dname", MySqlDbType.VarChar).Value = dname;

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
        public bool deleteMgonjwa(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `mgonjwa` WHERE `id`=@patientID", db.GetConnection());


            command.Parameters.Add("@patientID", MySqlDbType.Int32).Value = id;

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
