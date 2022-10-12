using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneNumberUpdate : PhoneBookData
    {
        public static void Update()
        {
            List<PhoneBook> Person1 = new List<PhoneBook>();
            Console.WriteLine("Güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string input = Console.ReadLine();
            int count = 0;

            foreach (var item in Person)
            {
                if (input == item.Name || input == item.Surname)
                {
                    Console.WriteLine("İsim : " + item.Name);
                    Console.WriteLine("Soyisim : " + item.Surname);
                    Console.WriteLine("Telefon Numarası : " + item.PhoneNumber);
                    Console.WriteLine();
                    Console.Write("Yeni isim gir : ");
                    string name = Console.ReadLine();
                    Console.Write("Yeni soyisim gir : ");
                    string surname = Console.ReadLine();
                    Console.Write("Yeni numara gir : ");
                    string phoneNumber = Console.ReadLine();
                    Person1.Add(new PhoneBook() { Name = name, Surname = surname, PhoneNumber = phoneNumber });
                    Console.WriteLine("Başarı ile güncellendi.");
                    count++;
                }

                else
                {
                    Person1.Add(new PhoneBook() { Name = item.Name, Surname = item.Surname, PhoneNumber = item.PhoneNumber });
                }

                Person = Person1;

            }

            

            if (count == 0)
            {
                Console.WriteLine("\nAradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("Yeniden denemek için : (2)");
                var choice = Console.ReadLine();
                if (choice == "1")
                {
                    return;
                }

                else if (choice == "2")
                {
                    Update();
                }
            }

            Console.ReadKey();

        }
    }
}
