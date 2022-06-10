using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class Package
    {
        public long PackageId { get; set; }
        public long ProjectVersionLsn { get; set; }
        public string Name { get; set; } = null!;
        public Guid PackageGuid { get; set; }
        public string? Description { get; set; }
        public int PackageFormatVersion { get; set; }
        public int VersionMajor { get; set; }
        public int VersionMinor { get; set; }
        public int VersionBuild { get; set; }
        public string? VersionComments { get; set; }
        public Guid VersionGuid { get; set; }
        public long ProjectId { get; set; }
        public bool EntryPoint { get; set; }
        public string ValidationStatus { get; set; } = null!;
        public DateTimeOffset? LastValidationTime { get; set; }
    }
}
