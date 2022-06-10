using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TSiteviewSvtSvjobreport
    {
        public string Idsite { get; set; } = null!;
        public string? Idrecparent { get; set; }
        public string Idrec { get; set; } = null!;
        public DateTime? Dttmstart { get; set; }
        public DateTime? Dttmend { get; set; }
        public string? Condroad { get; set; }
        public string? Condlease { get; set; }
        public string? Condweather { get; set; }
        public string? Condwind { get; set; }
        public string? Condwave { get; set; }
        public double? Temphigh { get; set; }
        public double? Templow { get; set; }
        public string? Groundcond { get; set; }
        public string? Idreccontact { get; set; }
        public string? Idreccontacttk { get; set; }
        public string? Activitystatus { get; set; }
        public string? Summary { get; set; }
        public string? Plannxtactivity { get; set; }
        public string? Usertxt1 { get; set; }
        public double? Usernum1 { get; set; }
        public short? Userboolean1 { get; set; }
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
