using System;

namespace FactoryMethod
{
    public class Camaro : ICarro
    {
        public void ShowDetails()
        {
            Console.WriteLine("This is a Camaro");
        }
    }
}
