using System;
using System.Collections.Generic;

namespace ManagerEmployee.Models
{
    public partial class UserLogin
    {
        public string IdUser { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string IdEmployeee { get; set; }

        public Employee IdEmployeeeNavigation { get; set; }
    }
}
