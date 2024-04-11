namespace Infrastructure.Models;

public class CourseRegistrationForm
{
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
    public string OrginalPrice { get; set; } = null!;
    public int Hours { get; set; }
    public bool Isdigital { get; set; }
    public string? ImageUrl { get; set; }
    public string? BigImageUrl { get; set; }
    public string Category { get; set; } = null!;
}
