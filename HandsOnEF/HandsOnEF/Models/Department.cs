using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandsOnEF.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentTitle { get; set; }

        //Navigation Properties
        public virtual ICollection<Employee> Employees { get; set; }

    }
}