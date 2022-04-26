using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> dictionaries = new MyDictionary<string>();
            dictionaries.Add("Javid");
            Console.WriteLine(dictionaries.Length);
            dictionaries.Add("Ali");
            Console.WriteLine(dictionaries.Length);
            foreach (var dictionary in dictionaries.Items)
            {
                Console.WriteLine(dictionary);
            }
        }       

    }
}
