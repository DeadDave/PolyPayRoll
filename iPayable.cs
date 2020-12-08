using System;
using System.Collections.Generic;
using System.Text;

namespace PolyPayroll
{
    interface IPayable
    {

        decimal GetPayableAmount { get; }


    }
}
