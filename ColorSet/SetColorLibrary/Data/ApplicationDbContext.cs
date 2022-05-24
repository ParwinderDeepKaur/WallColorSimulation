using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SetColorLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace SetColorLibrary.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<wallColor> WallColors { get; set; }
   

        public string DbPath { get; private set; }

        public ApplicationDbContext()
        {
            var path = Environment.CurrentDirectory;
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}ColorSetDB.db";
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
