using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.EntityFramework.Options;
using JobBoardManagement.Server.Configurations.Entities;
using JobBoardManagement.Shared.Domain;
using JobBoardManagement.Server.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace JobBoardManagement.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<JLocation> JLocations { get; set; }
        public DbSet<JobDetail> Jobs { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Salary> Salarys { get; set; }
        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CategorySeedConfiguration());
            builder.ApplyConfiguration(new LocationSeedConfiguration());
            builder.ApplyConfiguration(new SalarySeedConfiguration());



        }
    }
}
