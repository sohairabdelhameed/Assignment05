using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee
    {
        public string Fname { get; set; } = null!;
        public string? Lname { get; set; } = null;

        public Employee() {
    
        }
    }

    class Department
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }
}
