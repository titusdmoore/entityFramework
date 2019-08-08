using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Models {
    public class AppDbContext : DbContext {
        // Old Way
        //public AppDbContext(DbContextOptions<AppDbContext> options)
        //    : base(options) {
        //}


        // New way
        public AppDbContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            var connStr =
                @"server=localhost\sqlexpress;database=AppEfDB;trusted_connection=true;";
            builder.UseLazyLoadingProxies().UseSqlServer(connStr);
        }

        // Create Property of a collection of students from the student class

            //Will be needed for every class which represents the table you want to access
        public DbSet<Student> Students { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
