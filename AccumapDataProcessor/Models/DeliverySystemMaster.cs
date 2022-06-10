using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class DeliverySystemMaster
    {
        public string CreateUser { get; set; } = null!;
        public string? CreateProgram { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string LastUpdateUser { get; set; } = null!;
        public string? LastUpdateProgram { get; set; }
        public DateTime LastUpdateDateTime { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
        public decimal Version { get; set; }
        public decimal SysId { get; set; }
        public decimal ProductionDate { get; set; }
        public string Name { get; set; } = null!;
        public string GovernmentCode { get; set; } = null!;
        public string? UserDefined1 { get; set; }
        public string? UserDefined2 { get; set; }
        public string? RegistryProvince { get; set; }
        public string? RegistryEntityType { get; set; }
        public string? RegistryGovernmentCode { get; set; }
        public string? PraFacility { get; set; }
        public string? OilPipelineSplit { get; set; }
        public string? GasPipelineSplit { get; set; }
        public string? EndOfStreamFacility { get; set; }
        public string? CtpRegistryProvince { get; set; }
        public string? CtpRegistryGovernmentCode { get; set; }
        public string? CtpRegistryEntityType { get; set; }
        public string FacilityOperatorId { get; set; } = null!;
        public string? OilCtpProductCode { get; set; }
        public string DeliverySystemId { get; set; } = null!;
        public string PseudoFacilityFlag { get; set; } = null!;
    }
}
