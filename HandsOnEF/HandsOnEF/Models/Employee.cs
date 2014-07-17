using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandsOnEF.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string First { get; set; }
        public string Las { get; set; }
        public int PositionId { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

    }
}