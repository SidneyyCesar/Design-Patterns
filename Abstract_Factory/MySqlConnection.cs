using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class MySqlConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("The connection is open to MySql Server");
        }
    }
}
