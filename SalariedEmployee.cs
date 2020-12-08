using System;
using System.Collections.Generic;
using System.Text;

namespace PolyPayroll
{
    class SalariedEmployee : Employee
    {

        public decimal WeeklySalary { get; set; }
        public new decimal Earnings
        {
            get;
            set;
        }
    }
}
