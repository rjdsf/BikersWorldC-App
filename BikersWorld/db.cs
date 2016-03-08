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


        //globally accessible sql connection string builder
        

        //default construct
        public db()
        {
        }

        // create connection string for database

        public static string getConnectionString()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "usbw";
            builder.Database = "bikersworld";
            string connectionString = builder.ToString();
            return connectionString;

        }

       

        //Attempt to login to system
        public void login(string strUsername, string strPassword)
        {
            try
            {
                // take users password input and apply md5 hash
                string hashedPassword = getMD5Hash(strPassword);
                MySqlConnection Connection = new MySqlConnection(getConnectionString());

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM login WHERE (username = '@name' AND password = '@pass');", Connection);
                cmd.Parameters.AddWithValue("@name", strUsername);
                cmd.Parameters.AddWithValue("@pass", hashedPassword);

                Connection.Open();
           
                MySqlDataReader reader = cmd.ExecuteReader();
                int count = 0;
                while (reader.Read()) { count += 1; }
                if (count == 1) { MessageBox.Show("Test"); }
                    Connection.Close();

               
               

             
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message);
            }


            /////


            
            
        }


        // take a string value and return it as a MD5 hashed string
        public static String getMD5Hash(string strPassword) {

            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] textToHash = Encoding.Default.GetBytes(strPassword);
            byte[] result = md5.ComputeHash(textToHash);

            return System.BitConverter.ToString(result);

        }







    }
}
