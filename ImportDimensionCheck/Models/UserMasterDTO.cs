using System;
using System.Collections.Generic;

namespace ImportDimensionCheck.Models
{
    public partial class UserMasterDTO
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string UserGroupId { get; set; }
        public string Dept { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? RegisterDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public bool? ActiveSts { get; set; }
        public string Remark { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ChangeBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string SapUser { get; set; }
        public string SapPassword { get; set; }
        public string Ipaddress { get; set; }
        public DateTime? NotInFromDate { get; set; }
        public DateTime? NotInToDate { get; set; }
        public bool? ActiveNotIn { get; set; }
        public string Email { get; set; }
        public string ComputerName { get; set; }
        public string Lang { get; set; }
        public string UserType { get; set; }
        public string PlanGroup { get; set; }
        public string QueryAcb { get; set; }
        public string PlantAcb { get; set; }
        public string Whacb { get; set; }
        public string Wcacb { get; set; }
    }
}
