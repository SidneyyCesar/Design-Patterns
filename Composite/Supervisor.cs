using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Supervisor : IEmployee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }

        public List<IEmployee> ListSubordinates = new List<IEmployee>();

        public void PerformanceSummary()
        {
            Console.WriteLine("Performance summary of supervisor: {0} is {1} out 0f 5", Name, Rating);
        }

        public void AddSubordinate(IEmployee employee)
        {
            ListSubordinates.Add(employee);
        }
    }
}
