using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SqlConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("The connection is open to Sql Server");
        }
    }
}
