using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TPvtPvunitnode
    {
        public string Idflownet { get; set; } = null!;
        public string? Idrecparent { get; set; }
        public string Idrec { get; set; } = null!;
        public string? Name { get; set; }
        public string? Typ { get; set; }
        public DateTime? Dttmstart { get; set; }
        public DateTime? Dttmend { get; set; }
        public string? Component { get; set; }
        public string? Componentphase { get; set; }
        public string? Desfluid { get; set; }
        public string? Keepwhole { get; set; }
        public string? Typfluidbaserestrict { get; set; }
        public int? Sortflowdiag { get; set; }
        public string? Keymigrationsource { get; set; }
        public string? Typmigrationsource { get; set; }
        public string? Otherid { get; set; }
        public string? Correctionid1 { get; set; }
        public string? Correctiontyp1 { get; set; }
        public string? Correctionid2 { get; set; }
        public string? Correctiontyp2 { get; set; }
        public string? Facproductname { get; set; }
        public short? Usevirutalanalysis { get; set; }
        public short? Dispositionpoint { get; set; }
        public string? Dispproductname { get; set; }
        public string? Typdisp1 { get; set; }
        public string? Purchasername { get; set; }
        public string? Purchasercode1 { get; set; }
        public string? Purchasercode2 { get; set; }
        public string? Typdisp2 { get; set; }
        public string? Typdisphcliq { get; set; }
        public string? Dispida { get; set; }
        public string? Dispidb { get; set; }
        public string? Com { get; set; }
        public DateTime? Dttmhide { get; set; }
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
