using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneNumberDelete : PhoneBookData
    {
        public static void Delete()
        {
            Console.WriteLine("\nLütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string input = Console.ReadLine();
            int count = 0;

            foreach (var item in Person)
            {
                if (input == item.Name || input == item.Surname)
                {
                    Console.Write("\n" + item.Name + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                    char check = char.Parse(Console.ReadLine());
                    if (check == 'y')
                    {
                        Person.Remove(item);
                        Console.WriteLine(item.Name + " Başarı ile silindi.");
                        count++;
                        Console.ReadKey();
                        break;
                    }

                    else if (check == 'n')
                    {
                        return;
                    }
                }
            }

            if (count == 0)
            {
                Console.WriteLine("\nAradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("*Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("*Yeniden denemek için      : (2)");
                var choice = Console.ReadLine();

                if (choice == "1")
                {
                    return;
                }

                else if (choice == "2")
                {
                    Delete();
                }

                Console.ReadKey();

            }
        }
    }
}
