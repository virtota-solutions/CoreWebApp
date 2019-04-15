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
        public int NewFloorNum { get; set; }
        public int NewCubeNum { get; set; }
        public string DidNum { get; set; }
        public string DualMon { get; set; }
        public string RemoAcc { get; set; }
        public string RemoLap { get; set; }
        public string Mobile { get; set; }
        public string CopyProfile { get; set; }
        public string UserStatusChange { get; set; }
        public string UserNameChange { get; set; }
        public string LOA { get; set; }
    }
}
