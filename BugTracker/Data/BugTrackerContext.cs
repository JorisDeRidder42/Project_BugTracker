using BugTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Data
{
    public class BugTrackerContext : DbContext
    {
        public BugTrackerContext(DbContextOptions<BugTrackerContext> options) : base(options)
        {
        }

        public DbSet<Bugs> Bugs { get; set; }
        public DbSet<BugsPriority> BugsPriority { get; set; }
        public DbSet<BugStatus> BugStatus { get; set; }
        public DbSet<ProjectBugs> ProjectBugs { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<ProjectsAcces> ProjectsAcces { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Projects>().ToTable("Projects");
            modelBuilder.Entity<ProjectBugs>().ToTable("ProjectBugs");
            modelBuilder.Entity<BugStatus>().ToTable("BugStatus");
            modelBuilder.Entity<ProjectsAcces>().ToTable("ProjectsAcces");
            modelBuilder.Entity<BugStatus>().ToTable("BugStatus");
            modelBuilder.Entity<Bugs>().ToTable("Bugs");

            //builder klasse oo concept (design patern)
        }
    }
}