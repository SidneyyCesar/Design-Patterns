using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public interface IEmployee
    {
        int EmployeeID { get; set; }
        string Name { get; set; }
        int Rating { get; set; }
        void PerformanceSummary();
    }
}
