using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCVMurcorWebApp.Models
{
    public class Form
    {
        public long UserId { get; set; }

        public DateTime TodayDate { get; set; }
        public string RequestType { get; set; }
        public DateTime RequestBy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public string Name { get; set; }
        public string Department { get; set; }
        public string Office { get; set; }
        public string ManagerName { get; set; }
        public bool IsManager { get; set; }
        public string UserStatus { get; set; }

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
