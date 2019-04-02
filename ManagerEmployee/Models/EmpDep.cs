using System;
using System.Collections.Generic;

namespace ManagerEmployee.Models
{
    public partial class EmpDep
    {
        public string IdEmployee { get; set; }
        public string IdDepartment { get; set; }

        public Department IdDepartmentNavigation { get; set; }
        public Employee IdEmployeeNavigation { get; set; }
    }
}
