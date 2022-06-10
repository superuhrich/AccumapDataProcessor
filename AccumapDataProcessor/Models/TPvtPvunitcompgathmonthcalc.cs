using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TPvtPvunitcompgathmonthcalc
    {
        public string Idflownet { get; set; } = null!;
        public string? Idrecparent { get; set; }
        public string Idrec { get; set; } = null!;
        public DateTime? Dttmstart { get; set; }
        public DateTime? Dttmend { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public double? Durop { get; set; }
        public double? Durdown { get; set; }
        public double? Voltotalliq { get; set; }
        public double? Volhcliq { get; set; }
        public double? Volgas { get; set; }
        public double? Volwater { get; set; }
        public double? Volsand { get; set; }
        public double? Volcasinggas { get; set; }
        public double? Volnewprodgathhcliq { get; set; }
        public double? Volnewprodgathgas { get; set; }
        public double? Volnewprodgathwater { get; set; }
        public double? Volnewprodgathsand { get; set; }
        public double? Volgathstartremainrecovhcliq { get; set; }
        public double? Volgathstartremainrecovgas { get; set; }
        public double? Volgathstartremainrecovwater { get; set; }
        public double? Volgathstartremainrecovsand { get; set; }
        public double? Volgathrecovhcliq { get; set; }
        public double? Volgathrecovgas { get; set; }
        public double? Volgathrecovwater { get; set; }
        public double? Volgathrecovsand { get; set; }
        public double? Volgathinjectrecovgas { get; set; }
        public double? Volgathinjectrecovhcliq { get; set; }
        public double? Volgathinjectrecovwater { get; set; }
        public double? Volgathinjectrecovsand { get; set; }
        public double? Volgathremainrecovhcliq { get; set; }
        public double? Volgathremainrecovgas { get; set; }
        public double? Volgathremainrecovwater { get; set; }
        public double? Volgathremainrecovsand { get; set; }
        public double? Gor { get; set; }
        public string? Idrecmeasmeth { get; set; }
        public string? Idrecmeasmethtk { get; set; }
        public string? Idrecfluidlevel { get; set; }
        public string? Idrecfluidleveltk { get; set; }
        public string? Idrectest { get; set; }
        public string? Idrectesttk { get; set; }
        public string? Idrecparam { get; set; }
        public string? Idrecparamtk { get; set; }
        public string? Idrecdowntime { get; set; }
        public string? Idrecdowntimetk { get; set; }
        public string? Idrecgasanalysis { get; set; }
        public string? Idrecgasanalysistk { get; set; }
        public string? Idrechcliqanalysis { get; set; }
        public string? Idrechcliqanalysistk { get; set; }
        public string? Idrecoilanalysis { get; set; }
        public string? Idrecoilanalysistk { get; set; }
        public string? Idrecwateranalysis { get; set; }
        public string? Idrecwateranalysistk { get; set; }
        public string? Idrecstatus { get; set; }
        public string? Idrecstatustk { get; set; }
        public string? Idrecfacility { get; set; }
        public string? Idrecfacilitytk { get; set; }
        public string? Idrecpumpentry { get; set; }
        public string? Idrecpumpentrytk { get; set; }
        public double? Pumpeff { get; set; }
        public double? Ratetotalliq { get; set; }
        public double? Ratehcliq { get; set; }
        public double? Rategas { get; set; }
        public double? Ratewater { get; set; }
        public double? Ratesand { get; set; }
        public double? Ratechgtotalliq { get; set; }
        public double? Ratechghcliq { get; set; }
        public double? Ratechggas { get; set; }
        public double? Ratechgwater { get; set; }
        public double? Ratechgsand { get; set; }
        public double? Pctchgtotliq { get; set; }
        public double? Pctchghcliq { get; set; }
        public double? Pctchggas { get; set; }
        public double? Pctchgwater { get; set; }
        public double? Pctchgsand { get; set; }
        public short? Rateintol { get; set; }
        public short? Ratehcliqintol { get; set; }
        public short? Rategasintol { get; set; }
        public short? Ratewaterintol { get; set; }
        public short? Ratesandintol { get; set; }
        public double? Vollosthcliq { get; set; }
        public double? Vollostgas { get; set; }
        public double? Vollostwater { get; set; }
        public double? Vollostsand { get; set; }
        public double? Voldifftargethcliq { get; set; }
        public double? Voldifftargetgas { get; set; }
        public double? Voldifftargetwater { get; set; }
        public double? Voldifftargetsand { get; set; }
        public double? Volinjecthcliq { get; set; }
        public double? Volinjectgas { get; set; }
        public double? Volinjectwater { get; set; }
        public double? Volinjectsand { get; set; }
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
