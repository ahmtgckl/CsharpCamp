using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Tüzel //Customer'de olan tüm özellikler, artık Coorporate'de de kabul edilir.
    internal class CoorporateCustomer:Customer
    {
        
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
