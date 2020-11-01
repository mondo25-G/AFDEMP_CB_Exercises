using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayAppVol3
{
    class BirthdayEntriesList
    {

        //field
        private List<BirthdayEntry> birthDayEntryList;
        //property
        public string ListName { get; set; }


        //constructors
        public BirthdayEntriesList()
        {
            this.birthDayEntryList = new List<BirthdayEntry>();
        }
        public BirthdayEntriesList(string listName)
        {
            this.ListName = listName;
            this.birthDayEntryList = new List<BirthdayEntry>();
        }

        //some methods
        public void AddBirthDayEntry(BirthdayEntry birthdayEntry)
        {
            this.birthDayEntryList.Add(birthdayEntry);
        }

        public void RemoveBirthDayEntry(BirthdayEntry birthdayEntry)
        {
            this.birthDayEntryList.Remove(birthdayEntry);
        }




        public void PrintBirthdayEntriesList()
        {
            foreach (BirthdayEntry birthdayEntry in this.birthDayEntryList)
            {
                Console.WriteLine(birthdayEntry.ToString()); //calls override ToString() of BirthdayEntry class
            }
        }

    }
}
