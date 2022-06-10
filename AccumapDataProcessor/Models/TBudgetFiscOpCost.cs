using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBudgetFiscOpCost
    {
        public string ObjectId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int CostType { get; set; }
        public int InterestType { get; set; }
        public int CalcBehaviour { get; set; }
        public string? CountryId { get; set; }
        public byte IsInternational { get; set; }
        public string? OverridesId { get; set; }
        public byte IncludeInGcaCalc { get; set; }
        public byte IsVisible { get; set; }
        public int OpCostType { get; set; }
        public int ProductListType { get; set; }
        public byte SeparateMajorProducts { get; set; }
        public int SortIndex { get; set; }
    }
}
