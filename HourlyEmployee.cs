using System;
using System.Collections.Generic;
using System.Text;

namespace PolyPayroll
{
    class HourlyEmployee : Employee
    {
        public decimal HourlyWage { get; set; }
        public decimal HoursWorked { get; set; }
        public new decimal Earnings
        {
            get;
            set;
        }
    }
}
