using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Golf : ICarro
    {
        public void ShowDetails()
        {
            Console.WriteLine("This is a Golf");
        }
    }


    public class Jetta : ICarro
    {
        public void ShowDetails()
        {
            Console.WriteLine("This is a Jetta");
        }
    }
}
