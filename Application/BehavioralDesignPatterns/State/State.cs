
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BehavioralDesignPatterns.State
{
    abstract class State
    {
        public abstract void Pull(CeilingFanPullChain ceilingFanPullChain);
    }

    class Off : State
    {
        public override void Pull(CeilingFanPullChain ceilingFanPullChain)
        {
            ceilingFanPullChain.CurrentState = new Low();
            Console.WriteLine("Low speed");
        }
    }

    class Low : State
    {
        public override void Pull(CeilingFanPullChain ceilingFanPullChain)
        {
            ceilingFanPullChain.CurrentState = new Medium();
            Console.WriteLine("Medium speed");
        }
    }

    class Medium : State
    {
        public override void Pull(CeilingFanPullChain ceilingFanPullChain)
        {
            ceilingFanPullChain.CurrentState = new High();
            Console.WriteLine("High speed");
        }
    }

    class High : State
    {
        public override void Pull(CeilingFanPullChain ceilingFanPullChain)
        {
            ceilingFanPullChain.CurrentState = new Off();
            Console.WriteLine("Off");
        }
    }

    class CeilingFanPullChain
    {
        public State CurrentState { get; set; }

        public CeilingFanPullChain()
        {
            CurrentState = new Off();
        }

        public void Pull()
        {
            CurrentState.Pull(this);
        }
    }
}
