using System;
using System.Collections.Generic;

namespace PCVMurcorWebApp.Models
{
    public partial class Applicationaccess
    {
        public int UserId { get; set; }
        public int? VmsroleGroup { get; set; }
        public int? AddAccess { get; set; }
        public int? Otsaccess { get; set; }
        public int? BporoleGroup { get; set; }
        public int? LrvroleGroup { get; set; }
        public string Mas500Access { get; set; }

        public virtual AddiAccess AddAccessNavigation { get; set; }
        public virtual BpoRolegroup BporoleGroupNavigation { get; set; }
        public virtual LrvRolegroup LrvroleGroupNavigation { get; set; }
        public virtual OtsAccess OtsaccessNavigation { get; set; }
        public virtual UserTable User { get; set; }
        public virtual VmsRolegroup VmsroleGroupNavigation { get; set; }
    }
}
