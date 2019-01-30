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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private IDataHandler dataHandler;
        public LogInForm(IDataHandler dataHandler)
        {
            InitializeComponent();
            this.dataHandler = dataHandler;
        }

        private void registerBTN_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm(dataHandler, this);
            register.Show();
            this.Hide();
        }

        private void logInBTN_Click(object sender, EventArgs e)
        {
            CalendarUser user = new CalendarUser();
            if (dataHandler.CredentialsCheck(emailTB.Text, passwordTB.Text, out user))
            {
                CalendarForm calendar = new CalendarForm(dataHandler, user);
                calendar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect login details");
            }
        }
    }
}
