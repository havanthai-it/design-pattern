using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BehavioralDesignPatterns.Strategy
{
    class StrategyProgram
    {
        public static void Run()
        {
            List<IStrategy> strategies = new List<IStrategy>() { new SolutionOne() };

            foreach(var strategy in strategies)
            {
                strategy.Solve();
            }
        }
    }
}
