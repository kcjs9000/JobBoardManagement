using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoardManagement.Client.Static
{
    public static class Endpoint
    {
        private static readonly string Prefix = "api";
        public static readonly string ApplicationsEndPoint = $"{Prefix}/applications";
        public static readonly string CategorysEndPoint = $"{Prefix}/categorys";
        public static readonly string EmployersEndPoint = $"{Prefix}/employers";
        public static readonly string JLocationsEndPoint = $"{Prefix}/JLocations";
        public static readonly string JobsEndPoint = $"{Prefix}/jobs";
        public static readonly string JobTypesEndPoint = $"{Prefix}/JobTypes";
        public static readonly string SalarysEndPoint = $"{Prefix}/salarys";
        public static readonly string UsersEndPoint = $"{Prefix}/users";
        public static readonly string ResumeEndPoint = $"{Prefix}/resumes";
    }
}
