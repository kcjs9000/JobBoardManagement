using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoardManagement.Shared.Domain
{
    public class Resume :BaseDomainModel
    {
        public string HighestQualification { get; set; }
        public string WorkExperience { get; set; }
        public string Achievements { get; set; }
        public string Education { get; set; }
        public int IDuser{ get; set; }
        public virtual User UserID { get; set; }

    }
}
