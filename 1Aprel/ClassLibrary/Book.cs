using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Book : Product
    {
        public string Author { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Book name-{Name} author-{Author} price-{Price}");
        }
    }
}
