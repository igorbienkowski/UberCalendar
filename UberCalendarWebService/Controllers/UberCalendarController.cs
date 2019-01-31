using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UberCalendarWebService.Data;

namespace UberCalendarWebService.Controllers
{
    public class UberCalendarController : ApiController
    {
        SqlDataHandler dataHandler = new SqlDataHandler(ConfigurationManager.ConnectionStrings["GCPMySqlDB"].ConnectionString);

        [HttpPost]
        public CalendarUser GetUser([FromBody]CalendarUserCredentials credentials)
        {
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
        public void RegisterUser([FromBody] UserToRegister userJson)
        {
            CalendarUser user = new CalendarUser();
            CalendarUserCredentials credentials = new CalendarUserCredentials();
            user.Name = userJson.Name;
            user.Surname = userJson.Surname;
            user.DateOfBirth = userJson.DateOfBirth;
            user.UserID = userJson.UserID;

            credentials.Email = userJson.Email;
            credentials.Password = userJson.Password;

            dataHandler.RegisterUser(user,credentials);
        }

        [HttpPost]
        public void PostEvent([FromBody] CalendarEvent eventJson)
        {
            dataHandler.AddEvent(eventJson);
        }
    }
}
