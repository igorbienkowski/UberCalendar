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
            wc.BaseAddress = "http://localhost:8080/UltimateCalendarDefault/";
        }


        public bool CredentialsCheck(string email, string password, out CalendarUser loggedInUser)
        {
            string message = wc.DownloadString($"{wc.BaseAddress}GetUser?email={email}&password={password}");
            loggedInUser = serializer.Deserialize<CalendarUser>(message);
            return true;
        }

        public List<CalendarEvent> GetEvents(DateTime dateForEvents, CalendarUser loggedInUser)
        {
            string message = wc.DownloadString($"{wc.BaseAddress}GetEventsForUser?date={dateForEvents}&userId={loggedInUser.UserID}");
            events.Clear();
            events = serializer.Deserialize<List<CalendarEvent>>(message);
            return events;
        }

        public string RegisterUser(CalendarUser user)
        {

            wc.Headers.Add("Content-Type", "application/json");
            wc.Headers.Add("Data-Type", "application/json");
            string userJson = serializer.Serialize(user);
            try
            {
                return wc.UploadString(wc.BaseAddress + "RegisterUser", "Post", userJson);
            }
            catch (Exception ex)
            {
                return "Couldn't register user. " + ex.Message;
            }
        }

        public string AddEvent(CalendarEvent eventToPost)
        {

            wc.Headers.Add("Content-Type", "application/json");
            wc.Headers.Add("Data-Type", "application/json");
            string eventJson = serializer.Serialize(eventToPost);
            try
            {
                return wc.UploadString(wc.BaseAddress + "PostEvent", "Post", eventJson);
            }
            catch (Exception ex)
            {
                return "Couldn't add the event. " + ex.Message;
            }
        }
    }
}
