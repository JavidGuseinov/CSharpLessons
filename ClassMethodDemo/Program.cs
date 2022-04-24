using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           Customer customer1 = new Customer();
            customer1.CustomerId = 789;
            customer1.CustomerName = "Javid";
            customer1.CustomerLastname = "Guseinov";
            customer1.CustomerBankAccount = 123456789;

            Customer customer2 = new Customer();
            customer2.CustomerId = 123;
            customer2.CustomerName = "Ali";
            customer2.CustomerLastname = "Guseinov";
            customer2.CustomerBankAccount = 1827456387;

            Customer customer3 = new Customer();
            customer3.CustomerId = 456;
            customer3.CustomerName = "Gokhan";
            customer3.CustomerLastname = "Akdeniz";
            customer3.CustomerBankAccount = 1876544362;

            Customer customer4 = new Customer();
            customer4.CustomerId = 678;
            customer4.CustomerName = "Konstantin";
            customer4.CustomerLastname = "Ivanov";
            customer4.CustomerBankAccount = 1287467583;

           
            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            foreach (var customer in customers)
            {
                Console.WriteLine("Customers in the System" + " " +customer.CustomerName);
            }

            Console.WriteLine("-------------------");

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            Console.ReadLine();

            
        }
    }
}
