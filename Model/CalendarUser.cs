using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class CalendarUser
    {
        public CalendarUser()
        {

        }

        public CalendarUser(int ID, string name, string surname, DateTime dateOfBirth)
        {
            this.UserID = ID;
            this.Name = name;
            this.Surname = surname;
            this.DateOfBirth = dateOfBirth;
        }

        public int UserID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }
    }


}
