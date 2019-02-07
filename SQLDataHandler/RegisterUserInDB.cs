using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SQLDataHandler
{
    public class RegisterUserInDb
    {
        public void RegisterUserInDB(string name, string surname, DateTime dob, CalendarUserCredentials credentials, string connectionString)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO users (FirstName, LastName, DateOfBirth) VALUES (@FirstName, @LastName, @DateOfBirth)";
                command.Parameters.AddWithValue("@FirstName", name);
                command.Parameters.AddWithValue("@LastName", surname);
                command.Parameters.AddWithValue("@DateOfBirth", dob);
                connection.Open();

                MySqlTransaction transaction = connection.BeginTransaction();
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO user_credentials (userId, Email, Password) VALUES (last_insert_id(), @Email, @Password)";
                command.Parameters.AddWithValue("@Email", credentials.Email);
                command.Parameters.AddWithValue("@Password", credentials.Password);
                command.ExecuteNonQuery();
                transaction.Commit();
            }
        }
    }
}
