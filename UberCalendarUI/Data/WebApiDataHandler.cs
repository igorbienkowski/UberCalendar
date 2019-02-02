using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace UberCalendarUI.Data
{
    public class WebApiDataHandler : IDataHandler
    {
        List<CalendarEvent> events = new List<CalendarEvent>();
        WebClient wc = new WebClient();

        JavaScriptSerializer serializer = new JavaScriptSerializer();

        public WebApiDataHandler()
        {
            int BaseAdressPort = 8080;
            wc.BaseAddress = $"http://localhost:{BaseAdressPort}/UberCalendar/";
            int testPort = 50925;
            int IISPort = 8080;
        }


        public CalendarUser CredentialsCheck(CalendarUserCredentials credentials)
        {
            wc.Headers.Add("Content-Type", "application/json");
            wc.Headers.Add("Data-Type", "application/json");
            string userJson = serializer.Serialize(credentials);
            string test = wc.BaseAddress + "GetUser" + userJson;
            CalendarUser loggedInUser = serializer.Deserialize<CalendarUser>(wc.UploadString(wc.BaseAddress + "GetUser", "Post", userJson));
            if (loggedInUser.Name != "" && loggedInUser.Surname != "" && loggedInUser.Name != null && loggedInUser.Surname != null)
                return loggedInUser;
            else
                throw new ArgumentException("Incorrect log in details.");
        }

        public List<CalendarEvent> GetEvents(DateTime dateForEvents, CalendarUser loggedInUser)
        {
            string message = wc.DownloadString($"{wc.BaseAddress}GetEventsForUser?date={dateForEvents}&userId={loggedInUser.UserID}");
            events.Clear();
            events = serializer.Deserialize<List<CalendarEvent>>(message);
            return events;
        }

        public void RegisterUser(UserToRegister userToRegister)
        {
            wc.Headers.Add("Content-Type", "application/json");
            wc.Headers.Add("Data-Type", "application/json");
            string userJson = serializer.Serialize(userToRegister);
            wc.UploadString(wc.BaseAddress + "RegisterUser", "Post", userJson);
        }

        public void AddEvent(CalendarEvent eventToPost)
        {
            wc.Headers.Add("Content-Type", "application/json");
            wc.Headers.Add("Data-Type", "application/json");
            string eventJson = serializer.Serialize(eventToPost);
            wc.UploadString(wc.BaseAddress + "PostEvent", "Post", eventJson);
        }
    }
}
