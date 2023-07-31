using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Google
{
    class Conn
    {
        private String username;
        private String password;
        private String server;
        private String database;
        public MySqlConnection connection;

        public Conn()
        {
            server = "localhost";
            database = "book_store";
            username = "root";
            password = "";

            String connectionString = "SERVER = " + server + ";" + "DATABASE = " + database + ";" + "USER ID = " + username + ";" + "PASSWORD = " + password + ";";
            connection = new MySqlConnection(connectionString);

        }

        //Creating Connection
        public bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }

            catch(MySqlException e)
            {
                switch(e.Number)
            {
                case 0:
                    MessageBox.Show("Server could not be reached. Contact the system administrator");
                    break;

                case 1045:
                    MessageBox.Show("Invalid Username or Password. Please Try Again.");
                    break;
            }
            return false;
            }
        }

        //Close Connection
        public bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }

            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
