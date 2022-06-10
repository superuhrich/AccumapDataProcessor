using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TSiteviewSvtSvjobafe
    {
        public string Idsite { get; set; } = null!;
        public string? Idrecparent { get; set; }
        public string Idrec { get; set; } = null!;
        public string? Projectname { get; set; }
        public string? Projectrefnumber { get; set; }
        public string? Idrecloc { get; set; }
        public string? Idrecloctk { get; set; }
        public string? Refno { get; set; }
        public string? Costcenternum { get; set; }
        public string? Typ { get; set; }
        public double? Wi { get; set; }
        public DateTime? Dttmafe { get; set; }
        public string? Idrecwelljob { get; set; }
        public string? Idrecwelljobtk { get; set; }
        public string? Approvedby { get; set; }
        public DateTime? Dttmapproved { get; set; }
        public string? Status { get; set; }
        public DateTime? Dttmexpired { get; set; }
        public double? Allocation { get; set; }
        public string? Afenumbersupp { get; set; }
        public string? Com { get; set; }
        public string? Usertxt1 { get; set; }
        public string? Usertxt2 { get; set; }
        public DateTime? Userdttm1 { get; set; }
        public short? Syslockmeui { get; set; }
        public short? Syslockchildrenui { get; set; }
        public short? Syslockme { get; set; }
        public short? Syslockchildren { get; set; }
        public DateTime? Syslockdate { get; set; }
        public DateTime? Sysmoddate { get; set; }
        public string? Sysmoduser { get; set; }
        public DateTime? Syscreatedate { get; set; }
        public string? Syscreateuser { get; set; }
        public string? Systag { get; set; }
    }
}
