using System;
using System.Collections.Generic;

namespace ImportDimensionCheck.Models
{
    public partial class QC
    {
        public string QCNO { get; set; }
        public DateTime? QCDate { get; set; }
        public string QCStatus { get; set; }
        public string QCBy { get; set; }
        public string BatchNo { get; set; }
        public string Product { get; set; }
        public string ProductName { get; set; }
        public string UOM { get; set; }
        public string LotNo { get; set; }
        public string WH { get; set; }
        public string Location { get; set; }
        public double? StockQty { get; set; }
        public double? StockAmount { get; set; }
        public double? UnitCost { get; set; }
        public string RefDoc { get; set; }
        public DateTime? MFRDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string ToWH { get; set; }
        public string Remark { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ChangeBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string Reason { get; set; }
        public string ReasonName { get; set; }
        public double? PassQty { get; set; }
        public double? FailQty { get; set; }
        public double? SamplePass { get; set; }
        public double? SampleFail { get; set; }
        public double? PassRate { get; set; }
        public double? FaultyRate { get; set; }
        public double? QualityRate { get; set; }
        public double? PendingQty { get; set; }
        public bool? IsDone { get; set; }
        public double? Width { get; set; }
        public double? Lenght { get; set; }
        public string Grade { get; set; }
        public double? TotalPenaltyScore { get; set; }
        public double? FPScore { get; set; }
        public string QCType { get; set; }
        public string RefInfo { get; set; }
        public string ProductionLot { get; set; }
        public string QCNote { get; set; }
        public string FPGrade { get; set; }
        public string InspectionDesc { get; set; }
        public string AutoOpenQC { get; set; }
        public string ScreenType { get; set; }
        public string BOMNo { get; set; }
        public int? OprSeq { get; set; }
        public string OperationCode { get; set; }
        public string ProductDesc { get; set; }
    }
}
