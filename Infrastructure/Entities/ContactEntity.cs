namespace Infrastructure.Entities;

public class ContactEntity
{

    public int Id { get; set; }
    public string FullName { get; set; } = null!;
    public string EmailAddress { get; set; } = null!;
    public string? Service { get; set; }
    public string Message { get; set; } = null!;
    public DateTime Created { get; set; } = DateTime.Now;

}
