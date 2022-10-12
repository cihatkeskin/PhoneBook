using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneNumberSearch : PhoneBookData
    {
        public static void Search()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine();
            Console.WriteLine("İsim veya soyisim arama yapmak için (1) :");
            Console.WriteLine("Telefon numarasına göre arama yapmak (2) :");
            var selection = Console.ReadLine();
            int count = 0;

            if (selection == "1")
            {
                Console.WriteLine("\nİsim veya soyisim giriniz: ");
                string input = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");
                foreach (var item in Person)
                {
                    if (item.Name == input || item.Surname == input)
                    {
                        Console.WriteLine("İsim : " + item.Name);
                        Console.WriteLine("Soyisim : " + item.Surname);
                        Console.WriteLine("Telefon Numarası : " + item.PhoneNumber);
                        Console.WriteLine("-");
                        count++;
                    }
                }

                if(count == 0)
                {
                    Console.WriteLine("\nBöyle bir kayıt yok.");
                }
                
                Console.ReadKey();

            }

            else if (selection == "2")
            {
                Console.WriteLine("\nTelefon numarası giriniz: ");
                string phonenumber = Console.ReadLine();
                count = 0;

                Console.Clear();
                Console.WriteLine("\nArama Sonuçlarınız:");
                Console.WriteLine("**********************************************");
                foreach (var item in Person)
                {
                    
                    if (item.PhoneNumber == phonenumber)
                    {
                        Console.WriteLine("İsim : " + item.Name);
                        Console.WriteLine("Soyisim : " + item.Surname);
                        Console.WriteLine("Telefon Numarası : " + item.PhoneNumber);
                        Console.WriteLine("-");
                        count++;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine("\nBöyle bir kayıt yok.");
                }

                Console.ReadKey();

            }
        }
    }
}
