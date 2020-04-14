using _03._Composite_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Composite_Pattern.Models
{
    public class Employee : IEmployee
    {
        private List<IEmployee> subordinates = new List<IEmployee>();

        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public void AddSubordinate(IEmployee subordinate)
        {
            subordinates.Add(subordinate);
        }

        public void RemoveSubordinate(IEmployee subordinate)
        {
            subordinates.Remove(subordinate);
        }

        public void PrintHierarchy()
        {
            Console.WriteLine("  EmpID={0}, Name={1}", EmployeeId, Name);

            foreach (IEmployee subordinate in subordinates)
            {
                subordinate.PrintHierarchy();
            }
        }

        public IEnumerator<IEmployee> GetEnumerator()
        {
            foreach (IEmployee subordinate in subordinates)
            {
                yield return subordinate;
            }
        }
    }
}
