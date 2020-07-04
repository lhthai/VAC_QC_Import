using System;
using System.Collections.Generic;

namespace ImportDimensionCheck.Models
{
    public partial class MachineDTO
    {
        public string Machine { get; set; }
        public string MachineName { get; set; }
        public string WH { get; set; }
        public string WC { get; set; }
        public string MachineGroup { get; set; }
        public double? SetupTime { get; set; }
        public double? CapPerHour { get; set; }
        public bool? DefaultCapacity { get; set; }
        public double? MinQty { get; set; }
        public double? OHRate { get; set; }
        public string MachineMgr { get; set; }
        public bool? AvailableSts { get; set; }
        public string ItemBindType { get; set; }
        public string ItemColorType { get; set; }
        public string ItemTurnType { get; set; }
        public string ItemPart { get; set; }
        public string ItemSize { get; set; }
        public string Remark { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ChangeBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public double? MoveTime { get; set; }
        public string RouteMethod { get; set; }
        public string DLBACC { get; set; }
        public string DOHACC { get; set; }
        public string IRMACC { get; set; }
        public string ILBACC { get; set; }
        public string IOHACC { get; set; }
        public string CostCenter { get; set; }
        public double? NewCost { get; set; }
        public double? DLB { get; set; }
        public double? DOH { get; set; }
        public double? IRM { get; set; }
        public double? ILB { get; set; }
        public double? IOH { get; set; }
        public double? CostWgt { get; set; }
        public double? BGRate { get; set; }
        public string IsPlan { get; set; }
        public double? FixCost { get; set; }
        public double? VariableCost { get; set; }
        public double? ConcurrentApply { get; set; }
        public DateTime? LastStartTime { get; set; }
        public string Zone { get; set; }
        public string Area { get; set; }
        public string Station { get; set; }
        public string PMStaffs { get; set; }
        public string CC2 { get; set; }
        public string CC3 { get; set; }
        public string CC4 { get; set; }
        public string CC5 { get; set; }
        public string IsParallel { get; set; }
        public string ParallelCond { get; set; }
    }
}
