using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class PvtPvunitcompdowntm
    {
        public string Idflownet { get; set; } = null!;
        public string? Idrecparent { get; set; }
        public string Idrec { get; set; } = null!;
        public string? Typdowntm { get; set; }
        public DateTime? Dttmstart { get; set; }
        public double? Durdownstartday { get; set; }
        public string? Codedowntm1 { get; set; }
        public string? Codedowntm2 { get; set; }
        public string? Codedowntm3 { get; set; }
        public DateTime? Dttmend { get; set; }
        public double? Durdownendday { get; set; }
        public double? Durdowncalc { get; set; }
        public DateTime? Dttmplanend { get; set; }
        public double? Durdownplanend { get; set; }
        public string? Com { get; set; }
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
