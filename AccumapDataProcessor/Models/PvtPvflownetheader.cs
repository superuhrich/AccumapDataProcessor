using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class PvtPvflownetheader
    {
        public string Idflownet { get; set; } = null!;
        public string? Name { get; set; }
        public string? Typ { get; set; }
        public string? Idrecunitprimary { get; set; }
        public string? Idrecunitprimarytk { get; set; }
        public string? Idrecfacilityprimary { get; set; }
        public string? Idrecfacilityprimarytk { get; set; }
        public string? Com { get; set; }
        public string? Idrecresp1 { get; set; }
        public string? Idrecresp1tk { get; set; }
        public string? Idrecresp2 { get; set; }
        public string? Idrecresp2tk { get; set; }
        public short? Rptgatheredcalcs { get; set; }
        public short? Rptallocations { get; set; }
        public short? Rptdispositions { get; set; }
        public short? Rptcomponentdispositions { get; set; }
        public short? Rptnodecalculations { get; set; }
        public DateTime? Dttmallocprocessbegan { get; set; }
        public DateTime? Dttmstart { get; set; }
        public DateTime? Dttmend { get; set; }
        public DateTime? Dttmlastallocprocess { get; set; }
        public string? Userlastallocprocess { get; set; }
        public string? Usertxt1 { get; set; }
        public string? Usertxt2 { get; set; }
        public string? Usertxt3 { get; set; }
        public string? Usertxt4 { get; set; }
        public string? Usertxt5 { get; set; }
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
        public DateTime? Sysmoddatedb { get; set; }
        public string? Sysmoduserdb { get; set; }
        public string? Syssecuritytyp { get; set; }
        public DateTime? Syslockdatemaster { get; set; }
    }
}
