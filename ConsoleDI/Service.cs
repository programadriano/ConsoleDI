using System;

namespace ConsoleDI
{
    public class Service : IService
    {
        public void Test()
        {
            Console.WriteLine("Testing DI with a simple project");
            Console.ReadLine();
        }
    }
}
