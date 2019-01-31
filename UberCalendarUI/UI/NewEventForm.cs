using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberCalendarUI.Data;

namespace UberCalendarUI.UI
{
    public partial class NewEventForm : Form
    {
        public NewEventForm()
        {
            InitializeComponent();
            PopulateEventTypeCB();
        }

        private IDataHandler dataHandler;
        private CalendarUser loggedUser;
        public NewEventForm(IDataHandler dataHandler, CalendarUser loggedUser, DateTime dateForNewEvent)
        {
            InitializeComponent();
            this.dataHandler = dataHandler;
            this.loggedUser = loggedUser;
            PopulateEventTypeCB();
            eventDatePicker.Value = dateForNewEvent;
        }

        private void addEventBTN_Click(object sender, EventArgs e)
        {
            CalendarEvent newEvent = new CalendarEvent();
            newEvent.Date = eventDatePicker.Value;
            newEvent.Time = eventTimePicker.Value;
            newEvent.Description = descriptionTB.Text;
            newEvent.Type = eventTypeCB.Text;
            newEvent.UserId = loggedUser.UserID;
            dataHandler.AddEvent(newEvent);
            Close();
        }

        private void PopulateEventTypeCB()
        {
            foreach (string type in Enum.GetNames(typeof(EventTypeEnum)))
            {
                eventTypeCB.Items.Add(type);
            }
            eventTypeCB.SelectedIndex = 0;
        }
    }
}
