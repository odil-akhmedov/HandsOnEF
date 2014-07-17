using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandsOnEF.Models
{
    public class Position
    {
        public int PositionId { get; set; }
        public string PositionTitle { get; set; }
        //Navigation properties

        public virtual ICollection<Employee> Employees { get; set; }

     }
}