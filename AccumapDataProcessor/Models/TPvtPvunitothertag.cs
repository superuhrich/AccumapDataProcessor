using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TPvtPvunitothertag
    {
        public string Idflownet { get; set; } = null!;
        public string? Idrecparent { get; set; }
        public string Idrec { get; set; } = null!;
        public DateTime? Dttmstart { get; set; }
        public DateTime? Dttmend { get; set; }
        public string? Typ1 { get; set; }
        public string? Typ2 { get; set; }
        public string? Value { get; set; }
        public string? Idrecitem { get; set; }
        public string? Idrecitemtk { get; set; }
        public string? Com { get; set; }
        public string? Usertxt1 { get; set; }
        public string? Usertxt2 { get; set; }
        public string? Usertxt3 { get; set; }
        public double? Usernum1 { get; set; }
        public double? Usernum2 { get; set; }
        public double? Usernum3 { get; set; }
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
