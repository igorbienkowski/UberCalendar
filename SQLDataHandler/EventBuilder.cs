using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLDataHandler
{
    class MySqlReaderEventBuilder
    {
        public CalendarEvent Build(MySqlDataReader reader)
        {
            return new CalendarEvent
            {
                Id = (int)reader["eventId"],
                Description = (string)reader["description"],
                UserId = (int)reader["userId"],
                Date = (DateTime)reader["date"],
                Time = (DateTime)reader["time"],
                Type = (string)reader["type"]
            };
        }
    }
}
