using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberCalendarUI.Data
{
    public interface IDataHandler
    {
        List<CalendarEvent> GetEvents(DateTime dateForEvents, CalendarUser userForEvents);

        string AddEvent(CalendarEvent @event);

        string RegisterUser(CalendarUser user);

        bool CredentialsCheck(string email, string password, out CalendarUser loggedInUser);
    }
}
