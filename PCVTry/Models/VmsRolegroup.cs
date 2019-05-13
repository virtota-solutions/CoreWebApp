using System;
using System.Collections.Generic;

namespace PCVTry.Models
{
    public partial class VmsRolegroup
    {
        public VmsRolegroup()
        {
            Applicationaccess = new HashSet<Applicationaccess>();
        }

        public int VmsroleGroupId { get; set; }
        public bool? AccountGroup { get; set; }
        public bool? AdminSupport { get; set; }
        public bool? Assignor { get; set; }
        public bool? Auditor { get; set; }
        public bool? CliServiDeptMgr { get; set; }
        public bool? CliServiGroup { get; set; }
        public bool? CommercialGroup { get; set; }
        public bool? ContractorQc { get; set; }
        public bool? Itgroup { get; set; }
        public bool? ProcessingShippingGroup { get; set; }
        public bool? QcsupervisorLead { get; set; }
        public bool? Qc { get; set; }
        public bool? SalesGroup { get; set; }
        public bool? StatusGroup { get; set; }
        public bool? VendorRelationsGroup { get; set; }

        public ICollection<Applicationaccess> Applicationaccess { get; set; }
    }
}
