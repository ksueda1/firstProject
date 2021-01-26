using System;
namespace OOP2
{
    //for legal entities
    //inheritence
    class CorporateCustomer:Customer 
    {
        public string CorporateName { get; set; }
        public string TaxNumber { get; set; }
    }
}
