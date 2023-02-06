namespace JobBoardManagement.Shared.Domain
{
    public class Application :BaseDomainModel
    {
        public string CoverLetter { get; set; }
        public string ApplicationEmail{ get; set; }
        public int ResumeId { get; set; }
        public virtual Resume Resume { get; set; }

    }
}