using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using UberCalendarWebService.Data;

namespace UberCalendarWebService.Controllers
{
    public class UberCalendarController : ApiController
    {
        SqlDataHandler dataHandler = new SqlDataHandler(ConfigurationManager.ConnectionStrings["GCPMySqlDB"].ConnectionString);
        JavaScriptSerializer serializer = new JavaScriptSerializer();

        [HttpPost]
        public CalendarUser GetUser([FromBody]string json)
        {
            CalendarUserCredentials credentials = serializer.Deserialize<CalendarUserCredentials>(json);
            CalendarUser user = new CalendarUser();
            dataHandler.CredentialsCheck(credentials, out user);
            return user;
        }

        [HttpGet]
        public List<CalendarEvent> GetEventsForUser(string date, int userId)
        {
            return dataHandler.GetEvents(Convert.ToDateTime(date), userId);
        }

        [HttpPost]
        public void RegisterUser([FromBody] string userJson)
        {
            UserToRegister userToRegister = serializer.Deserialize<UserToRegister>(userJson);
            CalendarUser user = new CalendarUser();
            CalendarUserCredentials credentials = new CalendarUserCredentials();
            user.Name = userToRegister.Name;
            user.Surname = userToRegister.Surname;
            user.DateOfBirth = userToRegister.DateOfBirth;
            user.UserID = userToRegister.UserID;

            credentials.Email = userToRegister.Email;
            credentials.Password = userToRegister.Password;

            dataHandler.RegisterUser(user,credentials);
        }

        [HttpPost]
        public void PostEvent([FromBody] string eventJson)
        {
            CalendarEvent calendarEvent = serializer.Deserialize<CalendarEvent>(eventJson); 
            dataHandler.AddEvent(calendarEvent);
        }
    }
}
