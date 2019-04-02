using System;
using System.Collections.Generic;

namespace ManagerEmployee.Models
{
    public partial class Employee
    {
        public Employee()
        {
            EmpDep = new HashSet<EmpDep>();
            UserLogin = new HashSet<UserLogin>();
        }

        public string IdEmployee { get; set; }
        public string IdPosition { get; set; }
        public string FullName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }

        public Position IdPositionNavigation { get; set; }
        public ICollection<EmpDep> EmpDep { get; set; }
        public ICollection<UserLogin> UserLogin { get; set; }
    }
}
