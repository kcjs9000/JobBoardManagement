using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobBoardManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobBoardManagement.Server.Configurations.Entities
{
    public class LocationSeedConfiguration : IEntityTypeConfiguration<JLocation>
    {
        public void Configure(EntityTypeBuilder<JLocation> builder)
        {
            builder.HasData(
            new JLocation
            {
                Id = 1,
                JobLocation = "Tampinies",
                PostalCode = "752333",
                DateCreated = DateTime.Now,
                DateUpdate = DateTime.Now,
                CreatedBy = "System",
                UpdateBy = "System"
                
            },
            new JLocation
            {
                Id = 2,
                JobLocation = "AMK",
                PostalCode = "568884",
                DateCreated = DateTime.Now,
                DateUpdate = DateTime.Now,
                CreatedBy = "System",
                UpdateBy = "System"
            }
            );
        }
    }
}
