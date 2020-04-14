using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Composite_Pattern.Interface
{
    public interface IEmployee
    {
        int EmployeeId { get; set; }
        string Name { get; set; }
        void PrintHierarchy();
    }
}
