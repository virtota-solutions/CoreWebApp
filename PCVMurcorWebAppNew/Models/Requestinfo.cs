using System;
using System.Collections.Generic;

namespace PCVMurcorWebAppNew.Models
{
    public partial class Requestinfo
    {
        public DateTime? TodayDate { get; set; }
        public string RequestType { get; set; }
        public string RequestByName { get; set; }
        public DateTime? EffectiveStart { get; set; }
        public DateTime? EffectiveEnd { get; set; }
        public int UserId { get; set; }

        public UserTable User { get; set; }
    }
}
