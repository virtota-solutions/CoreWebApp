using System;
using System.Collections.Generic;

namespace PCVTry.Models
{
    public partial class UserRequirements
    {
        public int UserReqId { get; set; }
        public int? FloorNum { get; set; }
        public int? CubeNum { get; set; }
        public bool? DidNum { get; set; }
        public bool? DualMon { get; set; }
        public bool? RemoAcc { get; set; }
        public bool? RemoLap { get; set; }
        public bool? Mobile { get; set; }
        public string UserStatus { get; set; }
        public string UserName { get; set; }
    }
}
