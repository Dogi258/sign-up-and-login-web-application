using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace Assignment_4
{
    public class SqlLogic
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["c432019fa02martinezd2ConnectionString"].ConnectionString);

        public bool GetLogin(string user, string pass)
        {
            // define SQL SELECT query with parameters
            string selectSQLCommand = "SELECT username, password FROM users WHERE username = @username and password = @password";
            try
            {
                // create a command object
                SqlCommand command = new SqlCommand(selectSQLCommand, connection);
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = user;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = pass;
                // open connection, execute SELECT, close connection
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                string readUsername = null;
                string readPassword = null;
                while (reader.Read())
                {
                    readUsername = reader.GetValue(0).ToString();
                    readPassword = reader.GetValue(1).ToString();
                }
                reader.Close();
                command.Dispose();
                connection.Close();
                if ((user == readUsername) && (pass == readPassword))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        public bool SignUp(string username, string password, string lastName, string firstName, string address, string DOB, string phone)
        {
            // define INSERT SQL command with parameters
            string insertSQLCommand = "INSERT INTO Users (username, password, lastName, firstName, address, birthDate, phone)" +
                "VALUES (@username, @password, @lastname, @firstname, @address, @birthdate, @phone)";
            try
            {
                // create command
                SqlCommand command = new SqlCommand(insertSQLCommand, connection);
                // define parameters and their values
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                command.Parameters.Add("@lastname", SqlDbType.VarChar).Value = lastName;
                command.Parameters.Add("@firstname", SqlDbType.VarChar).Value = firstName;
                command.Parameters.Add("@address", SqlDbType.VarChar).Value = address;
                command.Parameters.Add("@birthdate", SqlDbType.VarChar).Value = DOB;
                command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
                // open connection, execute INSERT, close connection
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CheckUsername(string username)
        {
            string selectSQLCommand = "SELECT username FROM users WHERE username = @username";
            try
            {
                // create a command object
                SqlCommand command = new SqlCommand(selectSQLCommand, connection);
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                // open connection, execute SELECT, close connection
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                string readUsername = null;
                while (reader.Read())
                {
                    readUsername = reader.GetValue(0).ToString();
                }
                reader.Close();
                command.Dispose();
                connection.Close();
                if (username == readUsername)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        public string[] GetLoginInfo(string username)
        {
            // define SQL SELECT query with parameters
            string selectSQLCommand = "SELECT *FROM  users where username = @username";
            try
            {
                // create a command object
                SqlCommand command = new SqlCommand(selectSQLCommand, connection);
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                // open connection, execute SELECT, close connection
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                string[] info = new string[7];

                while (reader.Read())
                {
                    info[0] = reader.GetValue(0).ToString();
                    info[1] = reader.GetValue(1).ToString();
                    info[2] = reader.GetValue(2).ToString();
                    info[3] = reader.GetValue(3).ToString();
                    info[4] = reader.GetValue(4).ToString();
                    info[5] = reader.GetValue(5).ToString();
                    info[6] = reader.GetValue(6).ToString();
                }
                reader.Close();
                command.Dispose();
                connection.Close();
                return info;
            }
            catch
            {
                return null;
            }
        }

        public bool UpdatePassword(string username, string password)
        {
            // define UPDATE SQL command with parameters
            string updateSQLCommand = "Update Users SET password = @newPassword WHERE username = @username";
            try
            {
                // create connection and command
                SqlCommand command = new SqlCommand(updateSQLCommand, connection);
                // define parameters and their values
                command.Parameters.Add("@newPassword", SqlDbType.VarChar).Value = password;
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;

                // open connection, execute UPDATE, close connection
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateFirstName(string username, string firstName)
        {
            // define UPDATE SQL command with parameters
            string updateSQLCommand = "Update Users SET firstName = @newFirstName WHERE username = @username";
            try
            {
                // create connection and command
                SqlCommand command = new SqlCommand(updateSQLCommand, connection);
                // define parameters and their values
                command.Parameters.Add("@newFirstName", SqlDbType.VarChar).Value = firstName;
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;

                // open connection, execute UPDATE, close connection
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateLastName(string username, string lastName)
        {
            // define UPDATE SQL command with parameters
            string updateSQLCommand = "Update Users SET lastName = @newLastName WHERE username = @username";
            try
            {
                // create connection and command
                SqlCommand command = new SqlCommand(updateSQLCommand, connection);
                // define parameters and their values
                command.Parameters.Add("@newLastName", SqlDbType.VarChar).Value = lastName;
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;

                // open connection, execute UPDATE, close connection
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateAddress(string username, string address)
        {
            // define UPDATE SQL command with parameters
            string updateSQLCommand = "Update Users SET address = @newAddress WHERE username = @username";
            try
            {
                // create connection and command
                SqlCommand command = new SqlCommand(updateSQLCommand, connection);
                // define parameters and their values
                command.Parameters.Add("@newAddress", SqlDbType.VarChar).Value = address;
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;

                // open connection, execute UPDATE, close connection
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }


        }

        public bool UpdateDOB(string username, string dob)
        {
            // define UPDATE SQL command with parameters
            string updateSQLCommand = "Update Users SET birthDate = @newDOB WHERE username = @username";
            try
            {
                // create connection and command
                SqlCommand command = new SqlCommand(updateSQLCommand, connection);
                // define parameters and their values
                command.Parameters.Add("@newDOB", SqlDbType.VarChar).Value = dob;
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;

                // open connection, execute UPDATE, close connection
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }


        }

        public bool UpdatePhone(string username, string phone)
        {
            // define UPDATE SQL command with parameters
            string updateSQLCommand = "Update Users SET phone = @newPhone WHERE username = @username";
            try
            {
                // create connection and command
                SqlCommand command = new SqlCommand(updateSQLCommand, connection);
                // define parameters and their values
                command.Parameters.Add("@newPhone", SqlDbType.VarChar).Value = phone;
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;

                // open connection, execute UPDATE, close connection
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }


        }

    }
}