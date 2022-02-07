#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Model;

namespace MyWebApp.Data
{
    public class MyWebAppContext : DbContext
    {
        public MyWebAppContext (DbContextOptions<MyWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyWebApp.Model.User> User { get; set; }
    }
}
