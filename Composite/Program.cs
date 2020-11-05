using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Raul = new Employee { EmployeeID = 1, EmployeeName = "Raul" };
            Employee Ana = new Employee { EmployeeID = 2, EmployeeName = "Ana" };
            Employee Thomas = new Employee { EmployeeID = 3, EmployeeName = "Thomas" };

            Raul.AddSubordinate(Ana);
            Raul.AddSubordinate(Thomas);

            Employee Rita = new Employee { EmployeeID = 4, EmployeeName = "Rita" };
            Employee Helena = new Employee { EmployeeID = 5, EmployeeName = "Helena" };

            Ana.AddSubordinate(Rita);
            Ana.AddSubordinate(Helena);

            Employee Kevin = new Employee { EmployeeID = 6, EmployeeName = "Kevin" };
            Employee Rosario = new Employee { EmployeeID = 7, EmployeeName = "Rosario" };

            Contractor Samuel = new Contractor { EmployeeID = 8, EmployeeName = "Samuel" };
            Contractor Jose = new Contractor { EmployeeID = 9, EmployeeName = "José" };

            Thomas.AddSubordinate(Kevin);
            Thomas.AddSubordinate(Rosario);
            Thomas.AddSubordinate(Samuel);
            Thomas.AddSubordinate(Jose);

            Console.WriteLine("ID = {0}, Nombre = {1}", Raul.EmployeeID, Raul.EmployeeName);

            foreach (Employee manager in Raul)
            {
                Console.WriteLine("\n ID = {0}, Nombre = {1}", manager.EmployeeID, manager.EmployeeName);

                foreach (var employee in manager)
                {
                    Console.WriteLine(" \t ID = {0}, Nombre = {1}", employee.EmployeeID, employee.EmployeeName);
                }
            }
            Console.ReadKey();
        }
    }
    
}
