using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobBoardManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobBoardManagement.Server.Configurations.Entities
{
    public class SalarySeedConfiguration : IEntityTypeConfiguration<Salary>
    {
        public void Configure(EntityTypeBuilder<Salary> builder)
        {
            builder.HasData(
          new Salary
          {
              Id = 1,
              MinSalary = "2000",
              HighestSalary = "4000",
              DateCreated = DateTime.Now,
              DateUpdate = DateTime.Now,
              CreatedBy = "System",
              UpdateBy = "System"
          },
           new Salary
           {
               Id = 2,
               MinSalary = "3000",
               HighestSalary = "5000",
               DateCreated = DateTime.Now,
               DateUpdate = DateTime.Now,
               CreatedBy = "System",
               UpdateBy = "System"
           }
           );
        }
    }
}
