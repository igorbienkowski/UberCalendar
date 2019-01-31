using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserToRegister
    {
        public UserToRegister()
        {

        }

        public UserToRegister(int ID, string name, string surname, DateTime dateOfBirth, string Email, string Password)
        {
            this.UserID = ID;
            this.Name = name;
            this.Surname = surname;
            this.DateOfBirth = dateOfBirth;
            this.Email = Email;
            this.Password = Password;
        }

        public UserToRegister Create(CalendarUser user,CalendarUserCredentials credentials)
        {
            return new UserToRegister(user.UserID, user.Name, user.Surname, user.DateOfBirth, credentials.Email, credentials.Password);
        }

        public int UserID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
