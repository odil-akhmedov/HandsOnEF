using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandsOnEF.Models
{
    public class Timesheet
    {
        public int TimesheetId { get; set; }
        public DateTime Date { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public int EmployeeId { get; set; }
        //Navigation properties
        public virtual Employee Employee { get; set; }

    }
}