using System;
using System.Collections.Generic;

namespace PCVMurcorWebAppNew.Models
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

        public AddiAccess AddAccessNavigation { get; set; }
        public BpoRolegroup BporoleGroupNavigation { get; set; }
        public LrvRolegroup LrvroleGroupNavigation { get; set; }
        public OtsAccess OtsaccessNavigation { get; set; }
        public UserTable User { get; set; }
        public VmsRolegroup VmsroleGroupNavigation { get; set; }
    }
}
