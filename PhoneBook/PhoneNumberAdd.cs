using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneNumberAdd : PhoneBookData
    {
        public static void Add()
        {
            Console.WriteLine("Lütfen isim giriniz             : ");
            string name = Console.ReadLine();

            Console.WriteLine("Lütfen soyisim giriniz          : ");
            string surname = Console.ReadLine();

            Console.WriteLine("Lütfen telefon numarası giriniz : ");
            string phoneNumber = Console.ReadLine();

            Person.Add(new PhoneBook() { Name = name, Surname = surname, PhoneNumber = phoneNumber });

            Console.WriteLine("Yeni kişi eklenmiştir.");
            Console.ReadKey();
        }
    }
}
