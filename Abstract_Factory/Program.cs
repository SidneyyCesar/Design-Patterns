using AbstractFactory;
using System;

namespace AbstractFactory_DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //abstract classes
                DbFactory db;
                DbCommand cmd;
                DbConnection con;

                //Create a "fake" connection with a sql server
                db = new SqlFactory();

                con = db.CreateConnection();
                con.Open();

                cmd = db.CreateCommand();
                cmd.Execute();

                //Now the connection is with a MySql Server
                db = new MySqlFactory();

                con = db.CreateConnection();
                con.Open();

                cmd = db.CreateCommand();
                cmd.Execute();

                Console.ReadLine();
            }
            finally
            {
                Console.ReadKey();
            }
        }        
    }

}