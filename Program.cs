using System;

namespace PolyPayroll
{
    class Program
    {
        static void Main(string[] args)
        {
        

            while (true)
            {

                Console.Clear();
                Console.WriteLine("    Welcome to PolyPayroll");
                Console.WriteLine("Add a (S)alaried Employee");
                Console.WriteLine("Add an (H)ourly Employee");
                Console.WriteLine("Add an (I)nvoice");
                Console.WriteLine("(G)enerate Invoice Payouts");
                Console.WriteLine("E(x)it");

                ConsoleKeyInfo theKey = Console.ReadKey();
                Console.WriteLine();

                if (theKey.Key == ConsoleKey.S)
                {
                    Console.WriteLine("    Add a Salaried Employee");
                    Console.WriteLine("");
                    Console.WriteLine("Please Enter First Name");
                    string FirstName = Console.ReadLine();
                    Console.WriteLine("First Name, " + FirstName + " Added");

                    Console.WriteLine("Please Enter Last Name");
                    string LastName = Console.ReadLine();
                    Console.WriteLine("Last Name, " + LastName + " Added");

                    Console.WriteLine("Please Enter Social Security Number correctly or I will crash and die.");
                    int SSN = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Social Security Number " + SSN + " Added");

                    Console.WriteLine("Please Enter Weekly Salary");
                    decimal WeeklySalary = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Weekly Salary of " + WeeklySalary + " Added");

                    Console.WriteLine("Please Verify Salaried Employee Information to Submit:");
                    Console.WriteLine("      Adding " + FirstName + ", " + LastName);
                    Console.WriteLine("With SS#" + SSN + " Earning " + WeeklySalary + " (weekly)");
                    Console.WriteLine("");
                    Console.WriteLine("Press Any key to continue or (X) to cancel");

                    ConsoleKeyInfo theSKey = Console.ReadKey();
                    Console.WriteLine();

                    if (theSKey.Key == ConsoleKey.X)
                    {
                        break;
                    }
                    SalariedEmployee newemployee = new SalariedEmployee
                    {
                    FirstName = FirstName, LastName = LastName, SSN = SSN, 
                    WeeklySalary = WeeklySalary
                    };
                    Console.WriteLine();
                    Console.WriteLine(FirstName + ", " + LastName + " Added");
                    Console.WriteLine("Any Key to Continue");
                    Console.ReadKey();

                }
                if (theKey.Key == ConsoleKey.H)
                {
                    Console.WriteLine("Add an Hourly Employee");
                    Console.WriteLine("");
                    Console.WriteLine("Please Enter First Name");
                    string FirstName = Console.ReadLine();
                    Console.WriteLine("First Name, " + FirstName + " Added");

                    Console.WriteLine("Please Enter Last Name");
                    string LastName = Console.ReadLine();
                    Console.WriteLine("Last Name, " + LastName + " Added");

                    Console.WriteLine("Please Enter Social Security Number correctly or I will crash and die.");
                    int SSN = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Social Security Number " + SSN + " Added");

                    Console.WriteLine("Please Enter Hourly Wage");
                    decimal HourlyWage = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Hourly Wage of " + HourlyWage + " Added");
                    
                    Console.WriteLine("Please Verify Hourly Employee Information to Submit:");
                    Console.WriteLine("      Adding " + FirstName + ", " + LastName);
                    Console.WriteLine("With SS#" + SSN + " Earning " + HourlyWage + " (hourly)");
                    Console.WriteLine("");
                    Console.WriteLine("Press Any key to continue or (X) to cancel");

                    ConsoleKeyInfo theSKey = Console.ReadKey();
                    Console.WriteLine();

                    if (theSKey.Key == ConsoleKey.X)
                    {
                        break;
                    }
                    HourlyEmployee newemployee = new HourlyEmployee
                    {
                        FirstName = FirstName,
                        LastName = LastName,
                        SSN = SSN,
                        HourlyWage = HourlyWage,
                        // PayrollType = 0
                    };
                    Console.WriteLine();
                    Console.WriteLine(FirstName + ", " + LastName + " Added");
                    Console.WriteLine("Any Key to Continue");
                    Console.ReadKey();

                }
                if (theKey.Key == ConsoleKey.I)
                {
                    Console.WriteLine("Add an Invoice");
                    Console.WriteLine("");
                    Console.WriteLine("Please Enter Part Description");
                    string PartDescription = Console.ReadLine();
                    Console.WriteLine(PartDescription + " Added");

                    Console.WriteLine("Please Enter Per-Unit Price");
                    decimal UnitPrice = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Price: $" + UnitPrice + " Added");

                    Console.WriteLine("Please Enter Quantity");
                    decimal Quantity = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please Verify Addition of Invoice#: ");
                    Console.WriteLine("");
                    Console.WriteLine("Adding a total of " + Quantity + " " + PartDescription + " at a per-unit cost of " + UnitPrice);
                    Console.WriteLine("For an invoice total of ");
                    Console.WriteLine("Press Any key to continue or (X) to cancel");

                    ConsoleKeyInfo theSKey = Console.ReadKey();
                    Console.WriteLine();

                    if (theSKey.Key == ConsoleKey.X)
                    {
                        break;
                    }
                    Invoice newinvoice = new Invoice
                    {
                        PartDescription = PartDescription,
                        UnitPrice = UnitPrice,
                        Quantity = Quantity
                    };
                    Console.WriteLine();
                    Console.WriteLine(Quantity + PartDescription + " Added");
                    Console.WriteLine("Any Key to Continue");
                    Console.ReadKey();


                }
                if (theKey.Key == ConsoleKey.G)
                {
                    Console.WriteLine("Generate Invoices");

                    Console.WriteLine("Any Key to Continue");
                    Console.ReadKey();
                }
                if (theKey.Key == ConsoleKey.X)
                {
                   break;
                }
            }
        }
    }
}

