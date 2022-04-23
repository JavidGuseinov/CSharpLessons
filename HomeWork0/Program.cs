using System;

namespace HomeWork0
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductCategory = "Tshirts";
            product1.ProductColor = "Red";
            product1.ProductPrice = 50;
            product1.ProductName = "Nike Tshirt";

            Product product2 = new Product();
            product2.Id = 2;
            product2.ProductCategory = "Shoes";
            product2.ProductColor = "Yellow";
            product2.ProductPrice = 60;
            product2.ProductName = "Adidas";

            Product product3 = new Product();
            product3.Id = 3;
            product3.ProductCategory = "Trousers";
            product3.ProductColor = "Blue";
            product3.ProductPrice = 80;
            product3.ProductName = "Bershka";

            Product[] products = new Product[] { product1, product2, product3 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName + " : " + products[i].ProductPrice);
            }

            Console.WriteLine("for end");

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName + " : " + product.ProductPrice);
            }

            Console.WriteLine("foreach end");

            int j = 0;
            while (j < products.Length)
            {
                Console.WriteLine(products[j].ProductName + " : " + products[j].ProductPrice);
                j++;
            }


        }
    }

    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductColor { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductCategory { get; set; }
    }
}
