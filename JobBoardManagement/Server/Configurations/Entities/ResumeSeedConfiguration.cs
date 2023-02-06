using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobBoardManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobBoardManagement.Server.Configurations.Entities
{
    public class ResumeSeedConfiguration : IEntityTypeConfiguration<Resume>
    {
        public void Configure(EntityTypeBuilder<Resume> builder)
        {
            builder.HasData(
            new Resume
            {
                Id = 1,
                HighestQualification = "Degree",
                WorkExperience = "3 year",
                Achievements = "3",
                Education = "Degree",
                DateCreated = DateTime.Now,
                DateUpdate = DateTime.Now,
                CreatedBy = "System",
                UpdateBy = "System"
            },
             new Resume
             {
                 Id = 2,
                 HighestQualification = "Diploma",
                 WorkExperience = "6 year",
                 Achievements = "4",
                 Education = "Degree",
                 DateCreated = DateTime.Now,
                 DateUpdate = DateTime.Now,
                 CreatedBy = "System",
                 UpdateBy = "System"
             }
             );
        }
    }
}
