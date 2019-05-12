using System;
using System.Collections.Generic;

namespace PCVMurcorWebApp.Models
{
    public partial class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }

        public virtual UserTable UserNavigation { get; set; }
    }
}
