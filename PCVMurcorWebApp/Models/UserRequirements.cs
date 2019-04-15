using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCVMurcorWebApp.Models
{
    public class UserRequirements
    {

        public int FloorNum { get; set; }
        public int CubeNum { get; set; }
        public bool DidNum { get; set; }
        public bool DualMon { get; set; }
        public bool RemoAcc { get; set; }
        public bool RemoLap { get; set; }
        public bool Mobile { get; set; }
        public string UserStatusChange { get; set; }
        public string UserNameChange { get; set; }
    }
}
