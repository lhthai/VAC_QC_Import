using System;
using System.Collections.Generic;

namespace ImportDimensionCheck.Models
{
    public partial class Employee
    {
        public string Employee1 { get; set; }
        public string WC { get; set; }
        public string EmployeeName { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ChangeBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string EmpGroup { get; set; }
        public string EmployeePWD { get; set; }
        public string IsMA { get; set; }
        public string IsQC { get; set; }
        public double? RateA { get; set; }
        public double? RateB { get; set; }
        public double? RateC { get; set; }
        public double? RateD { get; set; }
    }
}
