using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayAppVol3
{
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayEntriesList friendsFromWork = new BirthdayEntriesList("Friends From Work");

            BirthdayEntry JohnB = new BirthdayEntry("John", "Bosko", "444444444", "25/12/1984");

            friendsFromWork.AddBirthDayEntry(JohnB);
            BirthdayEntry NickF = new BirthdayEntry("Nick", "Moretti", "89898989", "02/01/1987");
            friendsFromWork.AddBirthDayEntry(NickF);



            friendsFromWork.PrintBirthdayEntriesList();

            friendsFromWork.RemoveBirthDayEntry(NickF);

            friendsFromWork.PrintBirthdayEntriesList();
            friendsFromWork.PrintBirthdayEntriesList();

        }
    }
}
