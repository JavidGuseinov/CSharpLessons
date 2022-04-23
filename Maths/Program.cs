using System;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            FourTransactions fourTransactions = new FourTransactions();
            fourTransactions.Collect(5, 6);

            fourTransactions.Collect(6, 9);
        }
    }
}
