using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneBookList : PhoneBookData
    {
        public static void List()
        {
            Console.Clear();
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");

            foreach (var item in Person)
            {
                Console.WriteLine($"İsim             : {item.Name}");
                Console.WriteLine($"Soyisim          : {item.Surname}");
                Console.WriteLine($"Telefon Numarası : {item.PhoneNumber}");
                Console.WriteLine("-");
            }

            Console.ReadKey();

        }

        
    }
}
