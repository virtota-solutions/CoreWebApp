using System;
using System.Collections.Generic;

namespace PCVTry.Models
{
    public partial class BpoRolegroup
    {
        public BpoRolegroup()
        {
            Applicationaccess = new HashSet<Applicationaccess>();
        }

        public int Bpoid { get; set; }
        public bool? Bpoadmin { get; set; }
        public bool? ContractQc { get; set; }
        public bool? FdicQc { get; set; }
        public bool? HoldOrders { get; set; }
        public bool? MarkOrdersShipped { get; set; }
        public bool? QcBasic { get; set; }
        public bool? QcPlus { get; set; }
        public bool? QcSupervisor { get; set; }
        public bool? ViewRules { get; set; }

        public ICollection<Applicationaccess> Applicationaccess { get; set; }
    }
}
