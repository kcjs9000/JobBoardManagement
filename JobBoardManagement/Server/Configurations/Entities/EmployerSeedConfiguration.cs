using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobBoardManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobBoardManagement.Server.Configurations.Entities
{
    public class EmployerSeedConfiguration : IEntityTypeConfiguration<Employer>
    {
        public void Configure(EntityTypeBuilder<Employer> builder)
        {
            builder.HasData(
          new Employer
          {
              Id = 1,
              CompanyName = "Riot",
              CompanyEmail = "Riot@Riot.com",
              CompanyNumber = "63324333",
              DateCreated = DateTime.Now,
              DateUpdate = DateTime.Now,
              CreatedBy = "System",
              UpdateBy = "System"
          },
          new Employer
          {
              Id = 2,
              CompanyName = "Valve",
              CompanyEmail = "Valve@Valve.com",
              CompanyNumber = "63324333",
              DateCreated = DateTime.Now,
              DateUpdate = DateTime.Now,
              CreatedBy = "System",
              UpdateBy = "System"
          }
          );
        }
    }
    }

