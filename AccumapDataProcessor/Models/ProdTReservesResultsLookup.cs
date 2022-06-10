using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class ProdTReservesResultsLookup
    {
        public string EntityId { get; set; } = null!;
        public string ScenarioId { get; set; } = null!;
        public int ReserveCategoryId { get; set; }
        public string PlanDefinitionId { get; set; } = null!;
        public string ResultId { get; set; } = null!;
        public int ResultType { get; set; }
    }
}
