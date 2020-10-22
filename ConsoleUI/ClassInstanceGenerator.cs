using DemoLibrary;

namespace ConsoleUI
{
    public static class ClassInstanceGenerator
    {
        public static IManager CreateManager()
        {
            return new Manager();
        }

        public static IManaged CreateManagedEmployee()
        {
            return new Employee();
        }
    }
}
