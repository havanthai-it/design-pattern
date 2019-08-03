using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BehavioralDesignPatterns.Observer
{
    class ObserverProgram
    {
        public static void Run()
        {
            Subject subject = new Subject();
            Observer hexObserver = new HexObserver(subject);
            Observer binObserver = new BinObserver(subject);

            Console.WriteLine("Change state = 215");
            subject.State = 215;
            Console.WriteLine("Change state = 666");
            subject.State = 666;
        }
    }
}
