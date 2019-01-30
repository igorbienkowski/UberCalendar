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
        Encrypter encrypter = new Encrypter();
        Decrypter decrypter = new Decrypter();
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

        public bool CredentialsCheck(string email, string password, out CalendarUser loggedInUser)
        {
            GetUserFromDB getUser = new GetUserFromDB(connectionString);
            loggedInUser = getUser.GetUser(encrypter.Encrypt(password), email);
            if (email != loggedInUser.Email)
            {
                return false;
            }
            if (encrypter.Encrypt(password) != loggedInUser.Password)
            {
                return false;
            }
            return true;
        }

        public List<CalendarEvent> GetEvents(DateTime dateForEvents, int userId)
        {
            GetEventsFromDB getEvents = new GetEventsFromDB(connectionString);
            return getEvents.Get(dateForEvents, userId);
        }

        public string RegisterUser(CalendarUser user)
        {
            RegisterUserInDb register = new RegisterUserInDb();
            return register.RegisterUserInDB(user.Name, user.Surname, user.DateOfBirth, user.Email, encrypter.Encrypt(user.Password), connectionString);
        }
    }
}