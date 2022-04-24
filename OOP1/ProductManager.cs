using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Added.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Updated.");
        }

        public int Collect(int number1, int number2)
        {
            return number1 + number2;
        }

        public void Collect2(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }
    }
}
