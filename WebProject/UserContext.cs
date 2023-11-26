using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebProject.Models;

namespace WebProject
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}