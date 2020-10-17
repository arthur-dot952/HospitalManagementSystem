 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hospital_Management_System_1
{

   

    class DB
    {
       private MySqlConnection Connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hospital_users_db");


        public void OpenConnection()
        {

            if (Connection.State == ConnectionState.Closed)
            {

                Connection.Open();
            }
        }
        public void CloseConnection()
        {

            if (Connection.State == ConnectionState.Open)
            {

                Connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {

            return Connection;
        }
    }

}
