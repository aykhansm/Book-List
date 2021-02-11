using System;
using System.Collections.Generic;
namespace _11022021
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            string name;
            string pagecountStr;
            int pagecount;
            
            EnterAgain:
            EnterNameCorrectly:
                Console.Write("Kitab adi daxil edin: ");
                name = Console.ReadLine();
                name = name.Trim();
            
            if (name.Length < 3)
                goto EnterNameCorrectly;

            bool CanConvert;
            do
            {
                Console.Write("Kitabin sehife sayini daxil edin: ");
                pagecountStr = Console.ReadLine();
                CanConvert = int.TryParse(pagecountStr, out pagecount);
                if (!CanConvert)
                    Console.WriteLine("Duzgun daxil edin!");
                
                else if (pagecount < 10)
                    Console.WriteLine("Sehife sayi 10 dan kicik ola bilmez!");
            
            } while (!CanConvert || pagecount < 10);

            
            
            Book newbook = new Book(name, pagecount);
            books.Add(newbook);
            string YorN;
            
        
            EnterCorrectly:
            Console.WriteLine("Yeni bir kitab elave etmnk isteyirsinizmi? y/n ");
            YorN = Console.ReadLine();
            YorN = YorN.Trim();
            
            if (YorN.ToLower() == "y")
                goto EnterAgain;
            
            else if (YorN.ToLower() == "n")
            {
                int i = 1;
               foreach(Book item in books)
                {
                    Console.WriteLine($"{i}. Kitabin adi: {item.Name}\n{i}. Kitabin sehife sayi: {item.PageCount}\n=========="); ;
                    i++;
                } 
            }

            else
                goto EnterCorrectly;

        }
    }
}