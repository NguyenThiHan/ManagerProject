using System;
using System.Collections.Generic;

namespace ManagerEmployee.Models
{
    public partial class Department
    {
        public Department()
        {
            EmpDep = new HashSet<EmpDep>();
        }

        public string IdDepartment { get; set; }
        public string NameDepartment { get; set; }

        public ICollection<EmpDep> EmpDep { get; set; }
    }
}
