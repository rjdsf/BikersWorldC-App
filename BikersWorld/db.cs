using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace BikersWorld
{
    public class db
    {
        //db connection variables
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        // default constructor
        public db() {
            Initialize();

        }

        //build connection to db
        private void Initialize()
        {
            server = "localhost";
            database = "bikersworld";
            uid = "root";
            password = "usbw";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }


        //open connection to db
        private bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to the server, please contact your network administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username / password please try again");
                        break;
                }
                return false;
            }
        }

        // close connection to db
        private bool closeConnection()
        {
            try  {
                connection.Close();
                return true;
                    
            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        //query db to see if entered credentials exist within db
        private List<String>[] login (string username, string password)
        {
            string hashedPassword = getMD5Hash(password);
                       
            string query = "SELECT * FROM login WHERE (username = '" + username + "' AND password = '" + hashedPassword + "');";
            

            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["login_id"] + "");
                    list[1].Add(dataReader["username"] + "");
                    list[2].Add(dataReader["password"] + "");
                }

                dataReader.Close();
                this.closeConnection();
                return list;


            }
            else {
                return list;

            }


        }


        //Authenticate users login credentials
        public bool authenticate(string username, string password)
        {
            List<String>[] users = new List<string>[3];
            users = login(username, password);
            //if returning list contains a user then the login is authenticated
            if (users.Any())
            {
                MessageBox.Show("Authenicated");
            }

            return true;


        }

        
        // take a string value and return it as a MD5 hashed string
        private string getMD5Hash(string strPassword) {

            byte[] encodedPassword = new UTF8Encoding().GetBytes(strPassword);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

            string encoded = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
            return encoded; 

        }







    }
}
