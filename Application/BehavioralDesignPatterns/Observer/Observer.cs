using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BehavioralDesignPatterns.Observer
{
    abstract class Observer
    {
        protected Subject Subject;

        public Observer(Subject subject)
        {
            Subject = subject;
        }

        public abstract void Update();
    }

    class Subject
    {
        private List<Observer> _Observers = new List<Observer>();
        private int _State;

        public int State
        {
            get
            {
                return _State;
            }
            set
            {
                _State = value;
                Execute();
            }
        }

        public void AddObserver(Observer observer)
        {
            _Observers.Add(observer);
        }

        public void Execute()
        {
            foreach(var observer in _Observers)
            {
                observer.Update();
            }
        }
    }

    class HexObserver : Observer
    {
        public HexObserver(Subject subject) : base(subject)
        {
            Subject.AddObserver(this);
        }

        public override void Update()
        {
            Console.WriteLine("HexObserver: " + Convert.ToString(Subject.State, 16));
        }
    }

    class BinObserver : Observer
    {
        public BinObserver(Subject subject) : base(subject)
        {
            Subject.AddObserver(this);
        }

        public override void Update()
        {
            Console.WriteLine("BinObserver: " + Convert.ToString(Subject.State, 2));
        }
    }
}
