﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMVC.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }

        public bool IsRetired { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
