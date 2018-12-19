using System;
namespace FactoryMethod
{
    public class Jetta : ICarro
    {
        public void ShowDetails()
        {
            Console.WriteLine("This is a Jetta");
        }
    }
}
