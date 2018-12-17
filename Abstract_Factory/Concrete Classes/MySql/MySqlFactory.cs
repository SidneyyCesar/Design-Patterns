using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class MySqlFactory: DbFactory
    {
        public override DbConnection CreateConnection()
        {
            return new MySqlConnection();
        }

        public override DbCommand CreateCommand()
        {
            return new MySqlCommand();
        }
    }
}
