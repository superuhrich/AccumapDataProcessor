using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TPvtPvunitdispmonthday
    {
        public string Idflownet { get; set; } = null!;
        public string? Idrecparent { get; set; }
        public string Idrec { get; set; } = null!;
        public DateTime? Dttm { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? Dayofmonth { get; set; }
        public string? Idrecunit { get; set; }
        public string? Idrecunittk { get; set; }
        public string? Idreccomp { get; set; }
        public string? Idreccomptk { get; set; }
        public string? Idreccompzone { get; set; }
        public string? Idreccompzonetk { get; set; }
        public string? Idrecdispunitnode { get; set; }
        public string? Idrecdispunitnodetk { get; set; }
        public string? Idrecdispunit { get; set; }
        public string? Idrecdispunittk { get; set; }
        public double? Volhcliq { get; set; }
        public double? Volhcliqgaseq { get; set; }
        public double? Volgas { get; set; }
        public double? Volwater { get; set; }
        public double? Volsand { get; set; }
        public double? Volc1liq { get; set; }
        public double? Volc1gaseq { get; set; }
        public double? Volc1gas { get; set; }
        public double? Volc2liq { get; set; }
        public double? Volc2gaseq { get; set; }
        public double? Volc2gas { get; set; }
        public double? Volc3liq { get; set; }
        public double? Volc3gaseq { get; set; }
        public double? Volc3gas { get; set; }
        public double? Volic4liq { get; set; }
        public double? Volic4gaseq { get; set; }
        public double? Volic4gas { get; set; }
        public double? Volnc4liq { get; set; }
        public double? Volnc4gaseq { get; set; }
        public double? Volnc4gas { get; set; }
        public double? Volic5liq { get; set; }
        public double? Volic5gaseq { get; set; }
        public double? Volic5gas { get; set; }
        public double? Volnc5liq { get; set; }
        public double? Volnc5gaseq { get; set; }
        public double? Volnc5gas { get; set; }
        public double? Volc6liq { get; set; }
        public double? Volc6gaseq { get; set; }
        public double? Volc6gas { get; set; }
        public double? Volc7liq { get; set; }
        public double? Volc7gaseq { get; set; }
        public double? Volc7gas { get; set; }
        public double? Voln2liq { get; set; }
        public double? Voln2gaseq { get; set; }
        public double? Voln2gas { get; set; }
        public double? Volco2liq { get; set; }
        public double? Volco2gaseq { get; set; }
        public double? Volco2gas { get; set; }
        public double? Volh2sliq { get; set; }
        public double? Volh2sgaseq { get; set; }
        public double? Volh2sgas { get; set; }
        public double? Volothercompliq { get; set; }
        public double? Volothercompgaseq { get; set; }
        public double? Volothercompgas { get; set; }
        public double? Heat { get; set; }
        public string? Idreccalcset { get; set; }
        public string? Idreccalcsettk { get; set; }
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
