using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobBoardManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobBoardManagement.Server.Configurations.Entities
{
    public class JobDetailSeedConfiguration : IEntityTypeConfiguration<JobDetail>
    {
        public void Configure(EntityTypeBuilder<JobDetail> builder)
        {
            builder.HasData(
         new JobDetail
         {
             Id = 1,
             JobName = "Software Engineer",
             JobDescription = "Develop software",
             JobRequirements = "Dipolma",
             Positions = "Developer",
             Benefit = "break",
             DateCreated = DateTime.Now,
             DateUpdate = DateTime.Now,
             CreatedBy = "System",
             UpdateBy = "System"
         },
         new JobDetail
         {
             Id = 2,
             JobName = "Designer",
             JobDescription = "Design",
             JobRequirements = "Dipolma",
             Positions = "Senior Designer",
             Benefit = "break",
             DateCreated = DateTime.Now,
             DateUpdate = DateTime.Now,
             CreatedBy = "System",
             UpdateBy = "System"
         }
         );
        }
    }
}
