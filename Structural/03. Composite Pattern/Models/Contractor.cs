using _03._Composite_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Composite_Pattern.Models
{
    public class Contractor : IEmployee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public void PrintHierarchy()
        {
            Console.WriteLine("  EmpID={0}, Name={1}", EmployeeId, Name);
        }
    }
}
