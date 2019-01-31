using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SQLDataHandler;
using PasswordEncrypter;
using PasswordDecrypter;

namespace UberCalendarWebService.Data
{
    public class SqlDataHandler
    {
        string connectionString;

        public SqlDataHandler(string connectionString)
        {
            this.connectionString = connectionString;

        }

        public string AddEvent(CalendarEvent @event)
        {
            AddEventToDB addNewEvent = new AddEventToDB(connectionString);
            return addNewEvent.Add(@event);
        }

        public CalendarUser CredentialsCheck(CalendarUserCredentials credentials, out CalendarUser loggedInUser)
        {
            GetUserFromDB getUser = new GetUserFromDB(connectionString);
            loggedInUser = getUser.GetUser(credentials);
            return loggedInUser;
        }

        public List<CalendarEvent> GetEvents(DateTime dateForEvents, int userId)
        {
            GetEventsFromDB getEvents = new GetEventsFromDB(connectionString);
            return getEvents.Get(dateForEvents, userId);
        }

        public void RegisterUser(CalendarUser user,CalendarUserCredentials credentials)
        {
            RegisterUserInDb register = new RegisterUserInDb();
            register.RegisterUserInDB(user.Name, user.Surname, user.DateOfBirth, credentials , connectionString);
        }
    }
}