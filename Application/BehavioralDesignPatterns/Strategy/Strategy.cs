using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BehavioralDesignPatterns.Strategy
{
    interface IStrategy
    {
        void Solve();
    }

    abstract class StrategySolution : IStrategy
    {
        public void Solve()
        {
            Start();
            while (!IsSolution() && NextTry()) { }
            Stop();
        }

        public abstract void Start();
        public abstract void Stop();
        public abstract bool IsSolution();
        public abstract bool NextTry();
    }

    class SolutionOne : StrategySolution
    {
        private int _State = 1;

        public override bool IsSolution()
        {
            Console.Write("IsSolution-" + (_State == 3) + " ");
            return _State == 3;
        }

        public override bool NextTry()
        {
            Console.Write("NextTry-" + (_State++) + " ");
            return true;
        }

        public override void Start()
        {
            Console.Write("Start ");
        }

        public override void Stop()
        {
            Console.Write("Stop ");
            Console.WriteLine("");
        }
    }
}
