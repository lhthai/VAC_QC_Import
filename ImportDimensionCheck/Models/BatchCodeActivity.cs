﻿using System;
using System.Collections.Generic;

namespace ImportDimensionCheck.Models
{
    public partial class BatchCodeActivity
    {
        public string Product { get; set; }
        public string BatchCode { get; set; }
        public int Seq { get; set; }
        public double? Qty { get; set; }
        public string WONO { get; set; }
        public string TransType { get; set; }
        public string ChangeNote { get; set; }
        public DateTime? ChangeTime { get; set; }
        public string MC { get; set; }
        public string Station { get; set; }
        public string Area { get; set; }
        public string EmpCode { get; set; }
        public string EmpName { get; set; }
        public string SysNote { get; set; }
        public string LinkFile { get; set; }
        public string WorkStation { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ChangeBy { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
