using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class PvtPvunitagreemt
    {
        public string Idflownet { get; set; } = null!;
        public string? Idrecparent { get; set; }
        public string Idrec { get; set; } = null!;
        public string? Des { get; set; }
        public string? Typ1 { get; set; }
        public string? Subtyp1 { get; set; }
        public string? Subtyp2 { get; set; }
        public DateTime? Dttmstart { get; set; }
        public DateTime? Dttmend { get; set; }
        public string? Idrecappliesto { get; set; }
        public string? Idrecappliestotk { get; set; }
        public string? Refida { get; set; }
        public string? Refidb { get; set; }
        public string? Refidc { get; set; }
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
