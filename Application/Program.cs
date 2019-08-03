using Application.BehavioralDesignPatterns.Observer;
using Application.BehavioralDesignPatterns.State;
using Application.BehavioralDesignPatterns.Strategy;
using Application.CreationalDesignPatterns.AbstractFactory;
using Application.CreationalDesignPatterns.FactoryMethod;
using Application.CreationalDesignPatterns.Singleton;
using Application.StructuralDesignPatterns.Adapter;
using Application.StructuralDesignPatterns.Bridge;
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

            Console.WriteLine("---");
            Console.WriteLine(">> Builder");
            Console.WriteLine("---");

            Console.WriteLine("---");
            Console.WriteLine(">> Adapter");
            Console.WriteLine("With out using Adapter:");
            WithOutAdapter.Run();
            Console.WriteLine("Using Adapter:");
            WithAdapter.Run();
            Console.WriteLine("---");

            Console.WriteLine("---");
            Console.WriteLine(">> Bridge");
            BridgeProgram.Run();
            Console.WriteLine("---");

            Console.WriteLine("---");
            Console.WriteLine(">> Observer");
            ObserverProgram.Run();
            Console.WriteLine("---");

            Console.WriteLine("---");
            Console.WriteLine(">> State");
            StateProgram.Run();
            Console.WriteLine("---");

            Console.WriteLine("---");
            Console.WriteLine(">> Strategy");
            StrategyProgram.Run();
            Console.WriteLine("---");

            Console.ReadKey();
        }
    }
}
