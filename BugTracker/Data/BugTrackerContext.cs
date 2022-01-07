using BugTracker.Areas.Data;
using BugTracker.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Data
{
    public class BugTrackerContext : IdentityDbContext<ApplicationUser>
    {
        public BugTrackerContext(DbContextOptions<BugTrackerContext> options) : base(options)
        {
        }

        public DbSet<Bugs> Bugs { get; set; }
        public DbSet<ProjectBugs> ProjectBugs { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<ProjectsAcces> ProjectsAcces { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<TeamProject> TeamProjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("BugTracker");
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>().ToTable("ApplicationUser");
            modelBuilder.Entity<Bugs>().ToTable("Bugs");
            modelBuilder.Entity<Projects>().ToTable("Projects");
            modelBuilder.Entity<ProjectBugs>().ToTable("ProjectBugs");
            modelBuilder.Entity<ProjectsAcces>().ToTable("ProjectsAcces");
            modelBuilder.Entity<Team>().ToTable("Team");
            modelBuilder.Entity<TeamProject>().ToTable("TeamProject");
        }
    }
}