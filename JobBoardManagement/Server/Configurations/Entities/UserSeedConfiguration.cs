using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobBoardManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobBoardManagement.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
           new User
           {
               Id = 1,
               Username = "Cheesemaker",
               DateCreated = DateTime.Now,
               DateUpdate = DateTime.Now,
               CreatedBy = "System",
               UpdateBy = "System"
           },
           new User
           {
               Id = 2,
               Username = "CookieMaster123",
               DateCreated = DateTime.Now,
               DateUpdate = DateTime.Now,
               CreatedBy = "System",
               UpdateBy = "System"
           }
           );
        }
    }
}
