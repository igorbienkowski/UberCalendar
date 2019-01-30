using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLDataHandler
{
    public class AddEventToDB : DBQuery
    {

        public AddEventToDB(string connectionString) : base(connectionString)
        {
        }

        CalendarEvent calendarEvent;
        public bool done = false;
        
        public string Add(CalendarEvent calendarEvent)
        {
            try
            {
                this.calendarEvent = calendarEvent;
                Execute();
                return "Event added successfully";
            }
            catch (Exception ex)
            {
                return "Couldn't add the event" + ex.Message;
            }
        }

        public override void ExecuteCommand()
        {
            command.CommandText = "INSERT INTO events (description, userId, date, time, type) VALUES (@description, @userId, @date, @time, @type)";
            command.Parameters.AddWithValue("@description", calendarEvent.Description);
            command.Parameters.AddWithValue("@userId", calendarEvent.UserId);
            command.Parameters.AddWithValue("@date", calendarEvent.Date);
            command.Parameters.AddWithValue("@time", calendarEvent.Time);
            command.Parameters.AddWithValue("@type", calendarEvent.Type.ToString());
            command.ExecuteNonQuery();
            done = true;
        }
    }
}
