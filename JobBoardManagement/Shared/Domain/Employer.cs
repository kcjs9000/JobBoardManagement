using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoardManagement.Shared.Domain
{
    public class Employer :BaseDomainModel
    {
        public string CompanyName { get; set; }

        public string CompanyEmail { get; set; }

        public string CompanyNumber { get; set; }
        public int JobId { get; set; }
        public virtual JobDetail JobDetail { get; set; }
    }
}
