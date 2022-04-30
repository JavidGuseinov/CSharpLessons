using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
    //
{
    class TransportCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Payment plan of Transport Credit calculated");

        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
