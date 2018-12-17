using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SqlFactory : DbFactory
    {
        public override DbConnection CreateConnection()
        {
            return new SqlConnection();
        }

        public override DbCommand CreateCommand()
        {
            return new SqlCommand();
        }
    }
}
