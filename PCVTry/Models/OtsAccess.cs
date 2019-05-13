using System;
using System.Collections.Generic;

namespace PCVTry.Models
{
    public partial class OtsAccess
    {
        public OtsAccess()
        {
            Applicationaccess = new HashSet<Applicationaccess>();
        }

        public int OtsAccessId { get; set; }
        public bool? Return { get; set; }
        public bool? MultiAssign { get; set; }
        public bool? DeleteOrder { get; set; }
        public bool? ToReassign { get; set; }
        public bool? RecreateOrder { get; set; }
        public bool? AppraisalTagShip { get; set; }
        public bool? MaintainTagReasons { get; set; }
        public bool? MaintainClariReasons { get; set; }
        public bool? AuditAdmin { get; set; }
        public bool? DisputeQueueAccess { get; set; }

        public ICollection<Applicationaccess> Applicationaccess { get; set; }
    }
}
