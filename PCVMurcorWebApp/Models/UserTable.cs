using System;
using System.Collections.Generic;

namespace PCVMurcorWebApp.Models
{
    public partial class UserTable
    {
        public int UserId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Department { get; set; }
        public string Office { get; set; }
        public string ManagerName { get; set; }
        public bool? IsManager { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }

        public virtual Applicationaccess Applicationaccess { get; set; }
        public virtual Requestinfo Requestinfo { get; set; }
        public virtual User User { get; set; }
        public virtual UserRequirements UserRequirements { get; set; }
    }
}
