using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Journal : Product
    {
        public string Company { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Book name-{Name} company-{Company} price-{Price}");
        }
    }
}
