using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCVMurcorWebApp.Models
{
    public class UserInfo
    {
        public long UserId { get; set; }

        public DateTime TodayDate { get; set; }
        public string RequestType { get; set; }
        public DateTime RequestBy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
