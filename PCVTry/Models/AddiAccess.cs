using System;
using System.Collections.Generic;

namespace PCVTry.Models
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

        public ICollection<Applicationaccess> Applicationaccess { get; set; }
    }
}
