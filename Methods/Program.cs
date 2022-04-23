using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //string productName = "Apple";
            //int price = 15;
            //string details = "Red Apple";

            //string[] fruit = new string[] { };

            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Details = "Red Apple";


            Product product2 = new Product();
            product2.Name = "Strawberry";
            product2.Price = 5;
            product2.Details = "Jalilabad Strawberry";

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Details);
                Console.WriteLine("----------------------");
            }


            Console.WriteLine("-------------Methods---------------");
            //instance - example
            //encapsulation - DRY
            AddToCardManager addToCardManager = new AddToCardManager();
            addToCardManager.Add(product1);
            addToCardManager.Add(product2);

            
            






        }
    }
}


//Dont repeat yourself - DRY - Clean Code - Best Practice