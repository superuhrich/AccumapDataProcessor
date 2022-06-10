using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBudgetEntImportId
    {
        public string ParentId { get; set; } = null!;
        public string VendorId { get; set; } = null!;
        public string UniqueId { get; set; } = null!;
    }
}
