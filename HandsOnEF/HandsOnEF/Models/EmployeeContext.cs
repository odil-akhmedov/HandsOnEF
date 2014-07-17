﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HandsOnEF.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Timesheet> Timesheets { get; set; }
        public DbSet<Department> Deparments { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}