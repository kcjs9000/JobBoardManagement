namespace JobBoardManagement.Shared.Domain
{
    public class JobDetail :BaseDomainModel
    {
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public string JobRequirements { get; set; }
        public string Positions { get; set; }
        public string Benefit { get; set; }
        public int SalaryId { get; set; }
        public virtual Salary Salary { get; set; }
        public int JoblocationId { get; set; }
        public virtual JLocation JobLocation { get; set; }
        public int Jobcategoryid { get; set; }
        public virtual Category JobCategory { get; set; }
        public int Jobtypeid { get; set; }
        public virtual JobType JobType { get; set; }
    }
}