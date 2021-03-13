using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product + " eklendi");
        }
        public void ChangeName(Product product)
        {
            product.Name = "Masa";
        }

        public void Decrease(int sayi)
        {
            sayi = sayi - 1;
        }
    }
}
