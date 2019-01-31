using System;
using System.Collections.Generic;
using System.Text;
using Model;
using MySql.Data.MySqlClient;

namespace SQLDataHandler
{
    public class GetUserFromDB : DBQuery
    {
        private CalendarUser user;

        CalendarUserCredentials credentials;

        public GetUserFromDB(string connectionString) : base(connectionString)
        {
        }

        public CalendarUser GetUser(CalendarUserCredentials credentials)
        {
            user = new CalendarUser();
            this.credentials = credentials;
            Execute();
            return user;
        }

        public override void ExecuteCommand()
        {
            command.CommandText = "SELECT * FROM users a LEFT JOIN user_credentials b ON a.ID = b.userId WHERE email = @Email AND password = @Password LIMIT 1;";
            command.Parameters.AddWithValue("@Email", credentials.Email);
            command.Parameters.AddWithValue("@Password", credentials.Password);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    user.UserID = (int)reader["ID"];
                    user.Name = (string)reader["FirstName"];
                    user.Surname = (string)reader["LastName"];
                    user.DateOfBirth = (DateTime)reader["DateOfBirth"];
                }
            }
        }
    }
}
