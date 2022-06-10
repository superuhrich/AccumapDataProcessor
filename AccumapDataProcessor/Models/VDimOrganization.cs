using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimOrganization
    {
        public int? OrganizationId { get; set; }
        public string OrganizationName { get; set; } = null!;
        public string? OrganizationTypeCode { get; set; }
        public int? SortKey { get; set; }
    }
}
