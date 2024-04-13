namespace Infrastructure.Models
{
    public class Contact
    {

        public string FullName { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public string? Service { get; set; }
        public string Message { get; set; } = null!;

    }
}
