using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobBoardManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobBoardManagement.Server.Configurations.Entities
{
    public class CategorySeedConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
           new Category
           {
               Id = 1,
               JobCategory = "Engineering",
               DateCreated = DateTime.Now,
               DateUpdate = DateTime.Now,
               CreatedBy = "System",
               UpdateBy = "System"
           },
           new Category
           {
               Id = 2,
               JobCategory = "logtistic",
               DateCreated = DateTime.Now,
               DateUpdate = DateTime.Now,
               CreatedBy = "System",
               UpdateBy = "System"
           }
           );
        }
    }
}
