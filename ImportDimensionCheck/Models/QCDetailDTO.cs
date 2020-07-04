using System;
using System.Collections.Generic;

namespace ImportDimensionCheck.Models
{
    public partial class QCDetailDTO
    {
        public string QCNO { get; set; }
        public string Product { get; set; }
        public string QCCode { get; set; }
        public int QCSeq { get; set; }
        public string Description { get; set; }
        public double? MinValue { get; set; }
        public double? STDValue { get; set; }
        public double? MaxValue { get; set; }
        public double? QCValue { get; set; }
        public bool? QCPass { get; set; }
        public string Note { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ChangeBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string QCGroup { get; set; }
        public string TestMethod { get; set; }
        public bool? IsCOA { get; set; }
        public string BatchCode { get; set; }
        public string SpecType { get; set; }
        public int? Step { get; set; }
        public string InspectType { get; set; }
        public string ToolID { get; set; }
        public string Station { get; set; }
        public double? RSTN1 { get; set; }
        public double? RSTN2 { get; set; }
        public double? RSTN3 { get; set; }
        public string RSTS1 { get; set; }
        public string RSTS2 { get; set; }
        public string RSTS3 { get; set; }
        public double? FMLQCValue { get; set; }
        public string Result { get; set; }
        public string CheckBy { get; set; }
        public DateTime? CheckDate { get; set; }
    }
}
