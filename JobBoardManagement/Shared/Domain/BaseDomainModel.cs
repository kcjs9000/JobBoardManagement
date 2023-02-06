using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoardManagement.Shared.Domain
{
    public abstract class BaseDomainModel
    {
     public int Id { get; set; }
     public DateTime DateCreated { get; set; }

     public DateTime DateUpdate { get; set; }

     public string CreatedBy { get; set; }

     public string UpdateBy { get; set; }
    }
}
