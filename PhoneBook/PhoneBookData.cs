using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneBookData
    {
        public static List<PhoneBook> Person = new List<PhoneBook>();

        public static void CreatPhoneBook()
        {    
            Person.Add(new PhoneBook() { Name = "Ali", Surname = "Kaya", PhoneNumber = "05354789658" });
            Person.Add(new PhoneBook() { Name = "Ali", Surname = "Aslan", PhoneNumber = "05451233445" });
            Person.Add(new PhoneBook() { Name = "Mehmet", Surname = "Koçak", PhoneNumber = "05345546574" });
            Person.Add(new PhoneBook() { Name = "Ayşe", Surname = "Yılmaz", PhoneNumber = "05411457899" });
            Person.Add(new PhoneBook() { Name = "Veli", Surname = "Ozan", PhoneNumber = "05523456849" });

        }
    }
}
