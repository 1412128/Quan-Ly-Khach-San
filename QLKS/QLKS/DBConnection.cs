using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace QLKS
{
    public class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int port;

        private static DBConnection _instance;       

        //Constructor
        private DBConnection()
        {
            Initialize();
        }       
        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "db.quanlykhachsan";
            uid = "root";
            password = "root";
            port = 3306;
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "PORT=" + port + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public static DBConnection getInstance()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }
            return _instance;
        }
      
        //open connection to database
        private bool OpenConnection()
        {
            if (connection.State == ConnectionState.Open)
            {                
                return true;
            }
            else
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return false;
                }
            }            
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {                
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public bool Insert(string query)
        {           
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Execute command
                cmd.ExecuteNonQuery();
                //close connection
                this.CloseConnection();
                return true;
            }

            return false;
        }

        //Update statement
        public bool Update(string query)
        {           
            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;
            
                //Execute query
                cmd.ExecuteNonQuery();
               
                //close connection
                this.CloseConnection();
                return true;
            }
            return false;
        }

        //Delete statement
        public bool Delete(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                return true;
            }
            return false;
        }

        //Select statement
        public List<string[]> Select(string query)
        {
            //Create a list to store the result
            List<string[]> list = new List<string[]>();           

            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    //make string[] the size of the row being returned
                    string[] row = new string[dataReader.FieldCount];
                    //fill sting[] with row data
                    for (int i = 0; i < row.Length; i++)
                        row[i] = dataReader[i].ToString();
                    //add string[] to return list
                    list.Add(row);
                }

                //close stuff
                dataReader.Close();
                CloseConnection();

                //return list to be displayed
                return list;
            }
            else
                return list;
        }

        //Count statement
        public int Count(string query)
        {            
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
    }
}
