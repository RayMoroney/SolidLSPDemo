using DemoLibrary;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IManager accountingVP = EmployeeProcessor.SetupManager();

            IManaged emp = EmployeeProcessor.SetUpManagedEmployee(accountingVP);

            EmployeeProcessor.DisplayEmployee(emp);

            Console.ReadLine();
        }
    }
}
