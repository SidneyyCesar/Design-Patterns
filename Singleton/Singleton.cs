using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();

                    Console.WriteLine("Object instanced");
                }
                else
                {
                    Console.WriteLine("Object already instanced");
                }

                return instance;
            }
        }
    }
}
