using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BehavioralDesignPatterns.State
{
    class StateProgram
    {
        public static void Run()
        {
            CeilingFanPullChain ceilingFanPullChain = new CeilingFanPullChain();
            for (int i = 0; i < 10; i++)
            {
                ceilingFanPullChain.Pull();
            }
        }
    }
}
