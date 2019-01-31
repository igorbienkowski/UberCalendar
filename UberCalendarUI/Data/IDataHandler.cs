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

        void AddEvent(CalendarEvent @event);

        void RegisterUser(CalendarUser user,CalendarUserCredentials credentials);

        CalendarUser CredentialsCheck(CalendarUserCredentials credentials);
    }
}
