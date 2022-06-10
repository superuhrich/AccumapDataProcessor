using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TPvtPvunitnodeflowto
    {
        public string Idflownet { get; set; } = null!;
        public string? Idrecparent { get; set; }
        public string Idrec { get; set; } = null!;
        public DateTime? Dttmstart { get; set; }
        public DateTime? Dttmend { get; set; }
        public string? Idrecinlet { get; set; }
        public string? Idrecinlettk { get; set; }
        public string? Idrecinletunitcalc { get; set; }
        public string? Idrecinletunitcalctk { get; set; }
        public string? Idrecoutletcalc { get; set; }
        public string? Idrecoutletcalctk { get; set; }
        public string? Idrecoutletunitcalc { get; set; }
        public string? Idrecoutletunitcalctk { get; set; }
        public short? Recircflow { get; set; }
        public string? Com { get; set; }
        public int? Sysseq { get; set; }
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
