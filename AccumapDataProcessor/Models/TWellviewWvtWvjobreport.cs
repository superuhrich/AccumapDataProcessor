using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TWellviewWvtWvjobreport
    {
        public string Idwell { get; set; } = null!;
        public string? Idrecparent { get; set; }
        public string Idrec { get; set; } = null!;
        public string? Condhole { get; set; }
        public string? Condlease { get; set; }
        public string? Condroad { get; set; }
        public double? Condtemp { get; set; }
        public string? Condwave { get; set; }
        public string? Condweather { get; set; }
        public string? Condwind { get; set; }
        public string? Depthtvdendprojmethod { get; set; }
        public DateTime? Dttmend { get; set; }
        public DateTime? Dttmstart { get; set; }
        public double? Durationsinceltinc { get; set; }
        public double? Durationsincerptinc { get; set; }
        public double? Gasbackgroundavg { get; set; }
        public double? Gasbackgroundmax { get; set; }
        public double? Gasconnectionavg { get; set; }
        public double? Gasconnectionmax { get; set; }
        public double? Gasdrillavg { get; set; }
        public double? Gasdrillmax { get; set; }
        public double? Gastripavg { get; set; }
        public double? Gastripmax { get; set; }
        public double? H2smax { get; set; }
        public string? Idrecnextcas { get; set; }
        public string? Idrecnextcastk { get; set; }
        public string? Plannextrptops { get; set; }
        public string? Remarks { get; set; }
        public double? Rigtime { get; set; }
        public string? Rpttmactops { get; set; }
        public string? Statusend { get; set; }
        public string? Summaryops { get; set; }
        public short? Userboolean1 { get; set; }
        public short? Userboolean2 { get; set; }
        public double? Usernum1 { get; set; }
        public double? Usernum2 { get; set; }
        public double? Usernum3 { get; set; }
        public double? Usernum4 { get; set; }
        public double? Usernum5 { get; set; }
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
    }
}
