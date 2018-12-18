using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Employee fulano = new Employee { EmployeeID = 1, Name = "Fulano", Rating = 3 };
                Employee cicrano = new Employee { EmployeeID = 2, Name = "Cricrano", Rating = 4 };
                Employee bertolano = new Employee { EmployeeID = 3, Name = "Bertolano", Rating = 5 };

                Employee ryu = new Employee { EmployeeID = 1, Name = "Ryu", Rating = 3 };
                Employee ken = new Employee { EmployeeID = 2, Name = "Ken", Rating = 4 };

                Supervisor chefao_1 = new Supervisor { EmployeeID = 7, Name = "Chefão 1", Rating = 3 };
                Supervisor chefao_2 = new Supervisor { EmployeeID = 7, Name = "Chefão 2", Rating = 3 };

                chefao_1.AddSubordinate(fulano);
                chefao_1.AddSubordinate(cicrano);
                chefao_1.AddSubordinate(bertolano);

                chefao_2.AddSubordinate(ryu);
                chefao_2.AddSubordinate(ken);

                Console.WriteLine("--- Employes  --------");
                fulano.PerformanceSummary();
                cicrano.PerformanceSummary();
                bertolano.PerformanceSummary();

                ryu.PerformanceSummary();
                ken.PerformanceSummary();

                Console.WriteLine("--- Superwiser and yours employes -----");

                chefao_1.PerformanceSummary();

                Console.WriteLine("Subordinate s:");
                foreach (Employee employee in chefao_1.ListSubordinates)
                    employee.PerformanceSummary();

                chefao_2.PerformanceSummary();

                Console.WriteLine("Subordinate s:");
                foreach (Employee employee in chefao_2.ListSubordinates)
                    employee.PerformanceSummary();
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
