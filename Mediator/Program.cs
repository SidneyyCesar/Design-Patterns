using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var mediator = new ConcreteMediator();

                mediator.Colleague1 = new ConcreteColleagueA(mediator);

                mediator.Colleague2 = new ConcreteColleagueB(mediator);

                mediator.SendMessage(mediator.Colleague1, " Olá - eu sou a msg 1");

                mediator.SendMessage(mediator.Colleague2, " Olá - eu sou a msg 2");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
