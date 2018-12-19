using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    //'Leaf' class - will be leaf node in tree structure
    public class Employee : IEmployee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }

        public void PerformanceSummary()
        {
            Console.WriteLine("Performance summary of employee: {0} is {1} out 0f 5", Name, Rating);
        }
    }
}