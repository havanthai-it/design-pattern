using Application.AbstractFactory;
using Application.FactoryMethod;
using Application.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">> Program started!");

            Console.WriteLine("---");
            Console.WriteLine(">> Singleton");
            SingletonProgram.Run();
            Console.WriteLine("---");

            Console.WriteLine("---");
            Console.WriteLine(">> Abstract Factory");
            AbstractFactoryProgram.Run();
            Console.WriteLine("---");

            Console.WriteLine("---");
            Console.WriteLine(">> Factory Method");
            FactoryMethodProgram.Run();
            Console.WriteLine("---");

            Console.ReadKey();
        }
    }
}
