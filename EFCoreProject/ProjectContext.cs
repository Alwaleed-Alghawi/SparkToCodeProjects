using EFCoreProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject
{
    public class ProjectContext : DbContext //OOP Inhertance
    {
        //1- register models
        public DbSet<Employee> employees { get; set; } //initiating a table in the database, like a list 
        public DbSet<Department> departments { get; set; }

        //2- connect to database
        //This "OnConfiguring" is already available in the "DbContext", 
        //but it's used here again to be used in a new way,
        //that's why the "override" is there, so it overrides the old things

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
            "Server=DESKTOP-HSJB4SJ\\SQLEXPRESS;Database=CompanyProjectDB;Trusted_Connection=True;TrustServerCertificate=True;"

            //This will work like you're saying to the server take the tables above
            //and add them to the named database

            //In the Package Manager Console, type: "add-migration initailCreate" to add the migration
            //and add the specified tables mentioned in the Models, and a file will be created called "20260723144116_initialCreate.cs"

            //After that, still the file and the tables are not add to the database, 
            //so type : "update-database" and the tables will be added to the database

            );
        }
    }
}
