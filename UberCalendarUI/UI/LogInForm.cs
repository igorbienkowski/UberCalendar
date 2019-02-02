using Model;
using PasswordEncrypter;
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
            CalendarUserCredentials credentials = new CalendarUserCredentials();
            Encrypter encrypter = new Encrypter();
            credentials.Email = emailTB.Text;
            credentials.Password = encrypter.Encrypt(passwordTB.Text);
            CalendarUser loggedInUser = null;
            try
            { 
                loggedInUser = dataHandler.CredentialsCheck(credentials);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            CalendarForm calendar = new CalendarForm(dataHandler, loggedInUser);
            calendar.Show();
            this.Hide();
        }
    }
}
