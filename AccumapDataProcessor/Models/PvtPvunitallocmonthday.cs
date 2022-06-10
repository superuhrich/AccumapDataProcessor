﻿using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class PvtPvunitallocmonthday
    {
        public string Idflownet { get; set; } = null!;
        public string? Idrecparent { get; set; }
        public string Idrec { get; set; } = null!;
        public string? Idrecunit { get; set; }
        public string? Idrecunittk { get; set; }
        public string? Idreccomp { get; set; }
        public string? Idreccomptk { get; set; }
        public string? Idreccompzone { get; set; }
        public string? Idreccompzonetk { get; set; }
        public DateTime? Dttm { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? Dayofmonth { get; set; }
        public double? Durdown { get; set; }
        public double? Durop { get; set; }
        public double? Volprodgathhcliq { get; set; }
        public double? Volprodgathgas { get; set; }
        public double? Volprodgathwater { get; set; }
        public double? Volprodgathsand { get; set; }
        public double? Volprodallochcliq { get; set; }
        public double? Volprodallocoil { get; set; }
        public double? Volprodalloccond { get; set; }
        public double? Volprodallocngl { get; set; }
        public double? Volprodallochcliqgaseq { get; set; }
        public double? Volprodallocgas { get; set; }
        public double? Volprodallocwater { get; set; }
        public double? Volprodallocsand { get; set; }
        public double? Allocfacthcliq { get; set; }
        public double? Allocfactgas { get; set; }
        public double? Allocfactwater { get; set; }
        public double? Allocfactsand { get; set; }
        public double? Volnewprodallochcliq { get; set; }
        public double? Volnewprodallocoil { get; set; }
        public double? Volnewprodalloccond { get; set; }
        public double? Volnewprodallocngl { get; set; }
        public double? Volnewprodallochcliqgaseq { get; set; }
        public double? Volnewprodallocgas { get; set; }
        public double? Volnewprodallocwater { get; set; }
        public double? Volnewprodallocsand { get; set; }
        public double? Wihcliq { get; set; }
        public double? Wigas { get; set; }
        public double? Wiwater { get; set; }
        public double? Wisand { get; set; }
        public double? Nrihcliq { get; set; }
        public double? Nrigas { get; set; }
        public double? Nriwater { get; set; }
        public double? Nrisand { get; set; }
        public double? Vollosthcliq { get; set; }
        public double? Vollostgas { get; set; }
        public double? Vollostwater { get; set; }
        public double? Vollostsand { get; set; }
        public double? Voldifftargethcliq { get; set; }
        public double? Voldifftargetoil { get; set; }
        public double? Voldifftargetcond { get; set; }
        public double? Voldifftargetngl { get; set; }
        public double? Voldifftargetgas { get; set; }
        public double? Voldifftargetwater { get; set; }
        public double? Voldifftargetsand { get; set; }
        public double? Volstartremainrecovhcliq { get; set; }
        public double? Volstartremainrecovgas { get; set; }
        public double? Volstartremainrecovwater { get; set; }
        public double? Volstartremainrecovsand { get; set; }
        public double? Volrecovhcliq { get; set; }
        public double? Volrecovgas { get; set; }
        public double? Volrecovwater { get; set; }
        public double? Volrecovsand { get; set; }
        public double? Volinjectrecovgas { get; set; }
        public double? Volinjectrecovhcliq { get; set; }
        public double? Volinjectrecovwater { get; set; }
        public double? Volinjectrecovsand { get; set; }
        public double? Volremainrecovhcliq { get; set; }
        public double? Volremainrecovgas { get; set; }
        public double? Volremainrecovwater { get; set; }
        public double? Volremainrecovsand { get; set; }
        public double? Volstartinvhcliq { get; set; }
        public double? Volstartinvhcliqgaseq { get; set; }
        public double? Volstartinvwater { get; set; }
        public double? Volstartinvsand { get; set; }
        public double? Volendinvhcliq { get; set; }
        public double? Volendinvhcliqgaseq { get; set; }
        public double? Volendinvwater { get; set; }
        public double? Volendinvsand { get; set; }
        public double? Volchginvhcliq { get; set; }
        public double? Volchginvhcliqgaseq { get; set; }
        public double? Volchginvwater { get; set; }
        public double? Volchginvsand { get; set; }
        public double? Voldispsalehcliq { get; set; }
        public double? Voldispsaleoil { get; set; }
        public double? Voldispsalecond { get; set; }
        public double? Voldispsalengl { get; set; }
        public double? Voldispsalegas { get; set; }
        public double? Voldispfuelgas { get; set; }
        public double? Voldispflaregas { get; set; }
        public double? Voldispincinerategas { get; set; }
        public double? Voldispventgas { get; set; }
        public double? Voldispinjectgas { get; set; }
        public double? Voldispinjectwater { get; set; }
        public double? Volinjecthcliq { get; set; }
        public double? Volinjectgas { get; set; }
        public double? Volinjectwater { get; set; }
        public double? Volinjectsand { get; set; }
        public double? Volprodcumhcliq { get; set; }
        public double? Volprodcumoil { get; set; }
        public double? Volprodcumcond { get; set; }
        public double? Volprodcumngl { get; set; }
        public double? Volprodcumgas { get; set; }
        public double? Volprodcumwater { get; set; }
        public double? Volprodcumsand { get; set; }
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
        public string? Idrecpumpentry { get; set; }
        public string? Idrecpumpentrytk { get; set; }
        public string? Idrecfacility { get; set; }
        public string? Idrecfacilitytk { get; set; }
        public double? Pumpeff { get; set; }
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
