using System;
using System.Collections.Generic;

namespace ManagerEmployee.Models
{
    public partial class Position
    {
        public Position()
        {
            Employee = new HashSet<Employee>();
        }

        public string IdPosition { get; set; }
        public string NamePosition { get; set; }
        public decimal Salary { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
