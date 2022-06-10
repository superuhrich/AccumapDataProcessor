using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TStgCorporateModelBudgetConversionFactor
    {
        public DateTime? BudgetDate { get; set; }
        public string? BudgetName { get; set; }
        public DateTime? DeliveryMonth { get; set; }
        public double? BnpTotalCfBtuScf { get; set; }
    }
}
