using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; //import

namespace BirthdayAppVol3
{
    class BirthdayEntry
    {

        //private Class fields not visible to user
        private DateTime _dateOfBirth;

        //public Class properties expose "fields" to user

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }

        public string DateOfBirth // using a property allows me to take input as string store it internally as datetime
                                  //modify it internally as datetime
        {                               //and expose it publicly as a new string .
            get => _dateOfBirth.ToString("D", CultureInfo.CreateSpecificCulture("en-US"));
            set => _dateOfBirth = DateTime.ParseExact(value, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("en-US"));
        }


        //default + some constructors
        public BirthdayEntry()
        {
            this.FirstName = "John";
            this.LastName = "Doe";
            this.Telephone = "0000000000";
            this.DateOfBirth = "01/01/1900";
        }

        public BirthdayEntry(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Telephone = "0000000000";
            this.DateOfBirth = "01/01/1900";
        }


        public BirthdayEntry(string firstName, string lastName,
                             string telephone, string dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Telephone = telephone;
            this.DateOfBirth = dateOfBirth;

        }

        public override string ToString()
        {
            return ($"FirstName: {FirstName}, LastName: {LastName}, " +
                              $" Telephone: {Telephone}, Date Of Birth: {DateOfBirth}");
        }

    }
}
