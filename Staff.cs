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
    class Staff
    {
        DB db = new DB();

        //create a function to add a new doctor to the database

        public bool insertDaktari(string fname, string lname, string gender, DateTime dob, string pnum, string addrs, MemoryStream picture, string cntry, string city, string email, string psp, string aut)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `daktari`( `first name`, `last name`, `gender`, `date of birth`, `phone number`, `address`, `picture`, `country`, `city`, `email`, `ID/Passport`, `Authentication`) VALUES (@fname, @lname, @gender, @dob, @pnum, @addrs, @pic, @cntry, @city, @email, @psp, @aut)", db.GetConnection());

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
            command.Parameters.Add("@aut", MySqlDbType.VarChar).Value = aut;

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
        // craeate a function to return a table of doctors list
        public DataTable getDaktari(MySqlCommand command)
        {
            command.Connection = db.GetConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        //create a function to update doctors infomation
        public bool updateDaktari(int id, string fname, string lname, string gender, DateTime dob, string pnum, string addrs, MemoryStream picture, string cntry, string city, string email, string psp, string aut)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `daktari` SET `first name`=@fname,`last name`=@lname,`gender`=@gender,`date of birth`=@dob,`phone number`=@pnum,`address`=@addrs,`picture`=@pic,`country`=@cntry,`city`=@city,`email`=@email,`ID/Passport`=@psp,`Authentication`=@aut WHERE `id`=@ID", db.GetConnection());


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
            command.Parameters.Add("@aut", MySqlDbType.VarChar).Value = aut;

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

        //create a function to delete the selected nurse
        public bool deleteDaktari(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `daktari` WHERE `id`=@doctorID", db.GetConnection());


            command.Parameters.Add("@doctorID", MySqlDbType.Int32).Value = id;

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
