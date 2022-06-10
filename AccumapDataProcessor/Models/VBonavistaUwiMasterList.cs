using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VBonavistaUwiMasterList
    {
        public string? Uwi { get; set; }
        public string? FormattedUwi { get; set; }
        public string? DataSource { get; set; }
        public string ValidFlag { get; set; } = null!;
    }
}
