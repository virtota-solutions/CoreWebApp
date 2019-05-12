using System;
using System.Collections.Generic;

namespace PCVMurcorWebApp.Models
{
    public partial class AddiAccess
    {
        public AddiAccess()
        {
            Applicationaccess = new HashSet<Applicationaccess>();
        }

        public int AddiAccessId { get; set; }
        public bool? Pci { get; set; }
        public bool? Fdic { get; set; }
        public bool? Crm { get; set; }
        public string CopyOf { get; set; }

        public virtual ICollection<Applicationaccess> Applicationaccess { get; set; }
    }
}
