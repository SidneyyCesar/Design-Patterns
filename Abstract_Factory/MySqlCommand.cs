using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class MySqlCommand: DbCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Executing mySql command");
        }
    }
}
