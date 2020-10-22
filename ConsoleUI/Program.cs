using DemoLibrary;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IManager accountingVP = ClassInstanceGenerator.CreateManager();

            accountingVP.FirstName = "Mary";
            accountingVP.LastName = "Daley";
            accountingVP.CalculatePerHourRate(4);

            IManaged emp = ClassInstanceGenerator.CreateManagedEmployee();

            emp.FirstName = "John";
            emp.LastName = "Doe";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");


            Console.ReadLine();
        }
    }
}
