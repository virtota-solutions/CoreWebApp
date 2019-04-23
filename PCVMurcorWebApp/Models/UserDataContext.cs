using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PCVMurcorWebApp.Models
{
    public class UserDataContext : DbContext
    {
        public DbSet<UserInfo> Posts { get; set; }

        
        public UserDataContext(DbContextOptions<UserDataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
