using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class ProdTWellviewWvtWvjobreportcostgen
    {
        public string Idwell { get; set; } = null!;
        public string? Idrecparent { get; set; }
        public short? Syscarryfwdp { get; set; }
        public string Idrec { get; set; } = null!;
        public string? Code1 { get; set; }
        public string? Code2 { get; set; }
        public string? Code3 { get; set; }
        public string? Code4 { get; set; }
        public string? Code5 { get; set; }
        public string? Code6 { get; set; }
        public double? Cost { get; set; }
        public string? Des { get; set; }
        public string? Idrecafecustom { get; set; }
        public string? Idrecafecustomtk { get; set; }
        public string? Idrecintervalproblemcustom { get; set; }
        public string? Idrecintervalproblemcustomtk { get; set; }
        public string? Idrecphasecustom { get; set; }
        public string? Idrecphasecustomtk { get; set; }
        public double? Intervalproblempct { get; set; }
        public string? Note { get; set; }
        public string? Opscategory { get; set; }
        public string? Polineno { get; set; }
        public string? Pono { get; set; }
        public string? Sn { get; set; }
        public string? Ticketno { get; set; }
        public string? Unschedtyp { get; set; }
        public short? Userboolean1 { get; set; }
        public string? Usertxt1 { get; set; }
        public string? Vendor { get; set; }
        public string? Vendorcode { get; set; }
        public string? Vendorsubcode { get; set; }
        public string? Workorderno { get; set; }
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
