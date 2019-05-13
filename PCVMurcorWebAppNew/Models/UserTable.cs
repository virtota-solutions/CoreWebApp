﻿using System;
using System.Collections.Generic;

namespace PCVMurcorWebAppNew.Models
{
    public partial class UserTable
    {
        public int UserId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Department { get; set; }
        public string Office { get; set; }
        public string ManagerName { get; set; }
        public bool? IsManager { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }

        public Applicationaccess Applicationaccess { get; set; }
        public Requestinfo Requestinfo { get; set; }
        public User User { get; set; }
        public UserRequirements UserRequirements { get; set; }
    }
}
