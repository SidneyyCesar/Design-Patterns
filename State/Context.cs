using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Context
    {
        public Context(StateBase state)
        {
            State = state;

            Console.WriteLine("Create object of context class with initial State.");
        }

        public StateBase State { get; set; }

        public void Request()
        {
            State.Change(this);
        }
    }
}
