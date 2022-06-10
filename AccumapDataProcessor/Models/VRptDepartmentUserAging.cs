using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VRptDepartmentUserAging
    {
        public string? SiteName { get; set; }
        public string? DepartmentName { get; set; }
        public string? UserName { get; set; }
        public int? DaysCountOfInvCurrent { get; set; }
        public int? DaysWith3060 { get; set; }
        public int? DaysWith6090 { get; set; }
        public int? Over90Days { get; set; }
        public int? InvoiceCountCurrent { get; set; }
        public int? TotalCountOfInvDays { get; set; }
        public double? InvAmtCurrent { get; set; }
        public double? InvAmt3060Days { get; set; }
        public double? InvAmt6090Days { get; set; }
        public double? InvAmtOver90Days { get; set; }
        public double? InvoiceTotal { get; set; }
    }
}
