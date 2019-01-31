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

        void RegisterUser(UserToRegister user);

        CalendarUser CredentialsCheck(CalendarUserCredentials credentials);
    }
}
