using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBookData.CreatPhoneBook();
            string input = "";
            while (input != "0")
            {
                Console.Clear();
                Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz :");
                Console.WriteLine("\n*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "1":
                        PhoneNumberAdd.Add();
                        break;

                    case "2":
                        PhoneNumberDelete.Delete();
                        break;

                    case "3":
                        PhoneNumberUpdate.Update();
                        break;

                    case "4":
                        PhoneBookList.List();
                        break;

                    case "5":
                        PhoneNumberSearch.Search();
                        break;

                    case "0": 
                        continue;

                    default:
                        Console.WriteLine("1 ile 5 arası seçimini yapınız ya da 0 ile çıkınız.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
