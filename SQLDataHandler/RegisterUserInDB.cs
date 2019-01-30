using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SQLDataHandler
{
    public class RegisterUserInDb
    {
        public string RegisterUserInDB(string name, string surname, DateTime dob, string email, string password, string connectionString)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                //command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO users (FirstName, LastName, DateOfBirth, Email, Password) VALUES (@FirstName, @LastName, @DateOfBirth, @Email, @Password)";
                command.Parameters.AddWithValue("@FirstName", name);
                command.Parameters.AddWithValue("@LastName", surname);
                command.Parameters.AddWithValue("@DateOfBirth", dob);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return "Hooray account created !!!";
                }
                catch (Exception ex)
                {
                    return "Something went wrong !" + ex.Message;
                }
            }
        }
    }
}
