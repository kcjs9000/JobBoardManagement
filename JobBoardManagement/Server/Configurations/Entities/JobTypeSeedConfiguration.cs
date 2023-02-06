using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobBoardManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobBoardManagement.Server.Configurations.Entities
{
    public class JobTypeSeedConfiguration : IEntityTypeConfiguration<JobType>
    {
        public void Configure(EntityTypeBuilder<JobType> builder)
        {
            builder.HasData(
        new JobType
        {
            Id = 1,
            Jobtype = "Software",
            DateCreated = DateTime.Now,
            DateUpdate = DateTime.Now,
            CreatedBy = "System",
            UpdateBy = "System"
        },
         new JobType
         {
             Id = 2,
             Jobtype = "HardWARE",
             DateCreated = DateTime.Now,
             DateUpdate = DateTime.Now,
             CreatedBy = "System",
             UpdateBy = "System"
         }
         );
        }
    }
}
