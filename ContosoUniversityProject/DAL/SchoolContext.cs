using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContosoUniversityProject.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUniversityProject.DAL
{
    public class SchoolContext : DbContext
    {

        // This is the connection string.
        public SchoolContext() : base("SchoolContext")
        {
        }

        // An entity set corresponds to a database table.
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // modelBuilder.Conventions.Remove prevents table names from being pluralized.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}