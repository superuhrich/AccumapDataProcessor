using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TPvtPvfacility
    {
        public string Idflownet { get; set; } = null!;
        public string Idrec { get; set; } = null!;
        public string? Name { get; set; }
        public string? Idpa { get; set; }
        public string? Facilityida { get; set; }
        public string? Facilityidb { get; set; }
        public string? Facilityidc { get; set; }
        public string? Facilityidd { get; set; }
        public string? Typ1 { get; set; }
        public string? Typ2 { get; set; }
        public string? Typregulatory { get; set; }
        public string? Typpa { get; set; }
        public string? Idrecunitprimary { get; set; }
        public string? Idrecunitprimarytk { get; set; }
        public DateTime? Dttmstart { get; set; }
        public DateTime? Dttmend { get; set; }
        public DateTime? Dttmhide { get; set; }
        public short? Hidefacrev { get; set; }
        public short? Treathcliquidasgas { get; set; }
        public string? Idrecresp1 { get; set; }
        public string? Idrecresp1tk { get; set; }
        public string? Idrecresp2 { get; set; }
        public string? Idrecresp2tk { get; set; }
        public string? Permanentid { get; set; }
        public string? Usertxt1 { get; set; }
        public string? Usertxt2 { get; set; }
        public string? Usertxt3 { get; set; }
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
