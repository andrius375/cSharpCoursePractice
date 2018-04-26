using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practiceClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzduotis: Sukurti klase: Product. Parduotuves prekei apibudinti.
            Product phone = new Product("IPhone", "IPhone X 64GB", "black", 1178.9f);

            phone.Print();
            
            Console.WriteLine(phone.OnlyProductName());
            Console.ReadKey();
        }
    }
}
