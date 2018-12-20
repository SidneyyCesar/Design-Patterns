using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class StateA : StateBase
    {
        public void Change(Context context)
        {
            context.State = new StateB();
            Console.WriteLine("Change state from A to B.");
        }
    }
    public class StateB : StateBase
    {
        public void Change(Context context)
        {
            context.State = new StateC();
            Console.WriteLine("Change state from B to C.");
        }
    }

    public class StateC : StateBase
    {
        public void Change(Context context)
        {
            context.State = new StateA();
            Console.WriteLine("Change state from C to A.");
        }
    }
}
