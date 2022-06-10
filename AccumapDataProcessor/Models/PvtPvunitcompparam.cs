using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class PvtPvunitcompparam
    {
        public string Idflownet { get; set; } = null!;
        public string? Idrecparent { get; set; }
        public string Idrec { get; set; } = null!;
        public DateTime? Dttm { get; set; }
        public double? Prestub { get; set; }
        public double? Prescas { get; set; }
        public double? Presline { get; set; }
        public double? Tempwh { get; set; }
        public double? Szchoke { get; set; }
        public double? Presinj { get; set; }
        public double? Preswh { get; set; }
        public double? Presbh { get; set; }
        public double? Tempbh { get; set; }
        public double? Prestubsi { get; set; }
        public double? Prescassi { get; set; }
        public double? Viscdynamic { get; set; }
        public double? Visckinematic { get; set; }
        public double? Ph { get; set; }
        public double? Salinity { get; set; }
        public double? Presuser1 { get; set; }
        public double? Presuser2 { get; set; }
        public double? Presuser3 { get; set; }
        public double? Presuser4 { get; set; }
        public double? Presuser5 { get; set; }
        public double? Tempuser1 { get; set; }
        public double? Tempuser2 { get; set; }
        public double? Tempuser3 { get; set; }
        public double? Tempuser4 { get; set; }
        public double? Tempuser5 { get; set; }
        public string? Usertxt1 { get; set; }
        public string? Usertxt2 { get; set; }
        public string? Usertxt3 { get; set; }
        public string? Usertxt4 { get; set; }
        public string? Usertxt5 { get; set; }
        public double? Usernum1 { get; set; }
        public double? Usernum2 { get; set; }
        public double? Usernum3 { get; set; }
        public double? Usernum4 { get; set; }
        public double? Usernum5 { get; set; }
        public DateTime? Userdttm1 { get; set; }
        public DateTime? Userdttm2 { get; set; }
        public DateTime? Userdttm3 { get; set; }
        public DateTime? Userdttm4 { get; set; }
        public DateTime? Userdttm5 { get; set; }
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
