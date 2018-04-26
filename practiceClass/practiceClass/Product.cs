using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practiceClass
{
    class Product
    {
        private string Name;
        private string Description;
        private string Color;
        private float Price;

        public Product(string name, string description, string color, float price)
        {
            Name = name;
            Description = description;
            Color = color;
            Price = price;
        }
        public string OnlyProductName()
        {
            return Name;
        }
      
        public void Print()
        {
            Console.WriteLine("Prekes pavadinimas: {0}, aprasymas {1}, spalva {2}, kaina {3} EUR. ", Name, Description, Color, Price);
        }
    }
}
