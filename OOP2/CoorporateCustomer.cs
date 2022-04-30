using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
    //inheritance = :Customer
{
    class CoorporateCustomer:Customer
    {
     
        public string OrganizationName { get; set; }
        public string TaxNo { get; set; }
    }
}
