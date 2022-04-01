using System;
using ClassLibrary;
namespace _1Aprel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many product do you want to add");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            Library newLibrary = new Library();

            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine("Write your bookname:");
                string bookName = Console.ReadLine();
                Console.WriteLine("Write book price:");
                double bookPrice = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Write author:");
                string bookAuthor = Console.ReadLine();

                Console.WriteLine("Write your journal name:");
                string journalName = Console.ReadLine();
                Console.WriteLine("Write journal price:");
                double journalPrice = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Write journal company:");
                string journalCompany = Console.ReadLine();

                
                newLibrary.Products  = new Product[]
                {
                    

                    new Book 
                    {
                              Name = bookName,
                              Price = bookPrice,
                              Author= bookAuthor
                    },
                    
                    new Journal{Name= journalName,
                                Price = journalPrice,
                                Company = journalCompany
                    },
                    

                };
                newLibrary.AddProduct(newLibrary.Products[i]);

                
            }

           
            Console.WriteLine("Set your Min and Max price");
            double minPrice = Convert.ToDouble(Console.ReadLine());
            double maxPrice = Convert.ToDouble(Console.ReadLine());
            Product[] checkPrice = newLibrary.GetProductsByPrice(minPrice, maxPrice);
            foreach (var item in checkPrice)
            {
                item.GetInfo();
            }

            Console.WriteLine("Set your Name");
            string name = Console.ReadLine();
            Product[] checkName = newLibrary.GetProductsByName(name);
            foreach (var item in checkName)
            {
                item.GetInfo();
            }










        }
    }
}
