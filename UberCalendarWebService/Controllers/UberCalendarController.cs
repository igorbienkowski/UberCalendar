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

        [HttpGet]
        public CalendarUser GetUser(string email, string password)
        {
            CalendarUser user = new CalendarUser();
            dataHandler.CredentialsCheck(email, password, out user);
            return user;
        }

        [HttpGet]
        public List<CalendarEvent> GetEventsForUser(string date, int userId)
        {
            return dataHandler.GetEvents(Convert.ToDateTime(date), userId);
        }

        [HttpPost]
        public string RegisterUser([FromBody] CalendarUser userJson)
        {
            return dataHandler.RegisterUser(userJson);
        }

        [HttpPost]
        public string PostEvent([FromBody] CalendarEvent eventJson)
        {
            return dataHandler.AddEvent(eventJson);
        }
    }
}
