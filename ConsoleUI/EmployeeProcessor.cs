using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public static class EmployeeProcessor
    {
        public static IManager SetupManager()
        {
            IManager output = ClassInstanceGenerator.CreateManager();

            output.FirstName = "Mary";
            output.LastName = "Daley";
            output.CalculatePerHourRate(4);

            return output;
        }

        public static IManaged SetUpManagedEmployee(IManager manager)
        {
            IManaged output = ClassInstanceGenerator.CreateManagedEmployee();

            output.FirstName = "John";
            output.LastName = "Doe";
            output.AssignManager(manager);
            output.CalculatePerHourRate(2);

            return output;
        }

        public static void DisplayEmployee(IEmployee emp)
        {
            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");
        }
    }
}
