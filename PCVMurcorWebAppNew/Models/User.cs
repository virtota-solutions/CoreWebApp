using System;
using System.Collections.Generic;

namespace PCVMurcorWebAppNew.Models
{
    public partial class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }

        public UserTable UserNavigation { get; set; }
    }
}
