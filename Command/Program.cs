using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Receiver receiver = new Receiver();
                Command command = new ConcreteCommand(receiver);
                Invoker invoker = new Invoker();


                invoker.SetCommand(command);
                invoker.ExecuteCommand();
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
