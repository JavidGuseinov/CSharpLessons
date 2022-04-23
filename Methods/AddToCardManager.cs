using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class AddToCardManager
    {
        //convention - naming
        public void Add(Product product) 
        {
            Console.WriteLine("Added To Cart : " + product.Name); 
        }
        public void Add2(string productName, string details, double price)
        {

        }
        
       
    }
}
