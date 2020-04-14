using _03._Composite_Pattern.Models;
using System;

namespace _03._Composite_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Rahul = new Employee { EmployeeId = 1, Name = "Rahul" };

            Employee Amit = new Employee { EmployeeId = 2, Name = "Amit" };
            Employee Mohan = new Employee { EmployeeId = 3, Name = "Mohan" };

            Rahul.AddSubordinate(Amit);
            Rahul.AddSubordinate(Mohan);

            Employee Rita = new Employee { EmployeeId = 4, Name = "Rita" };
            Employee Hari = new Employee { EmployeeId = 5, Name = "Hari" };

            Amit.AddSubordinate(Rita);
            Amit.AddSubordinate(Hari);

            Employee Kamal = new Employee { EmployeeId = 6, Name = "Kamal" };
            Employee Raj = new Employee { EmployeeId = 7, Name = "Raj" };

            Contractor Sam = new Contractor { EmployeeId = 8, Name = "Sam" };
            Contractor tim = new Contractor { EmployeeId = 9, Name = "Tim" };

            Mohan.AddSubordinate(Kamal);
            Mohan.AddSubordinate(Raj);
            Mohan.AddSubordinate(Sam);
            Mohan.AddSubordinate(tim);

            Console.WriteLine("EmpID={0}, Name={1}", Rahul.EmployeeId, Rahul.Name);

            foreach (Employee manager in Rahul)
            {
                Console.WriteLine("   EmpID={0}, Name={1}", manager.EmployeeId, manager.Name);

                foreach (var employee in manager)
                {
                    Console.WriteLine(" \t EmpID={0}, Name={1}", employee.EmployeeId, employee.Name);
                }
            }
            Console.ReadKey();
        }
    }
}
