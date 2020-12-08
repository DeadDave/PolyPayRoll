using System;
using System.Collections.Generic;
using System.Text;

namespace PolyPayroll
{
    class Invoice
    {
        public string PartDescription{ get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ExtendedPrice {
            //MATH ExtendedPrice = UnitPrice x Quantity
            get; set; }
        public decimal Quantity { get; set; }
                

    }
}
