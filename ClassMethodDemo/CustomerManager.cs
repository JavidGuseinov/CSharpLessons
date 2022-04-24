using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerLastname + " " + "Successfully added to the system");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerLastname + " " + "Successfully deleted from the system");
        }
        public void BalanceUpdate(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerLastname + " " + "Balance updated");
        }
    }
}
