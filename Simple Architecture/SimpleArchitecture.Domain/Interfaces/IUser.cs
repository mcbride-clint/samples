namespace SimpleArchitecture.Domain.Interfaces
{
    public interface IUser
    {
        long UserIdSeqNum { get; set; }
        string UserId { get; set; }
        string FullName { get; set; }
        string Activity { get; set; }
        string Subactivity { get; set; }
        string Owner { get; set; }
        string PhoneNumber { get; set; }
    }
}
