using System;
using System.Collections.Generic;

namespace PCVMurcorWebApp.Models
{
    public partial class LrvRolegroup
    {
        public LrvRolegroup()
        {
            Applicationaccess = new HashSet<Applicationaccess>();
        }

        public int LrvId { get; set; }
        public bool? LrvAdmin { get; set; }
        public bool? FannieQc { get; set; }
        public bool? RegularQc { get; set; }
        public bool? AllQueues { get; set; }

        public virtual ICollection<Applicationaccess> Applicationaccess { get; set; }
    }
}
