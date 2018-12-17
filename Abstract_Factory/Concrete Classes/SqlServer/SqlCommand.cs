using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SqlCommand : DbCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Executing sql command");
        }
    }
}
