using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBudgetCompany
    {
        public string ObjectId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public byte? Enabled { get; set; }
        public byte? UseInNewCaseInterests { get; set; }
        public double DefaultWorkingInterest { get; set; }
    }
}
