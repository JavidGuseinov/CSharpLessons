using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class HousingCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Payment plan of Housing Credit calculated");


        }

        public void DoSomething()
        {
            throw new NotImplementedException();

        }
    }
}
