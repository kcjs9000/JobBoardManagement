namespace JobBoardManagement.Shared.Domain
{
    public class User :BaseDomainModel
    {
        public string Username { get; set; }
        public int Applicationid { get; set; }
        public virtual Application UserAppication { get; set; }
    }
}