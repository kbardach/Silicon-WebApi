using Infrastructure.Entities;
using Infrastructure.Models;

namespace Infrastructure.Factories;

public class CourseFactory
{
    public static CourseEntity Create(CourseRegistrationForm form)
    {
        try
        {
            var datetime = DateTime.Now;

            return new CourseEntity
            {
                Id = Guid.NewGuid().ToString(),
                Title = form.Title,
                Author = form.Author,
                OrginalPrice = form.OrginalPrice,
                Hours = form.Hours,
                Isdigital = form.Isdigital,
                Created = datetime,
                LastUpdated = datetime,
                ImageUrl = form.ImageUrl,
                BigImageUrl = form.BigImageUrl,
            };
        }
        catch { }
        return null!;
    }

    public static Course Create(CourseEntity entity)
    {
        try
        {
            return new Course
            {
              Id = entity.Id,
              Title = entity.Title,
              Author = entity.Author,
              OriginalPrice = entity.OrginalPrice,
              DiscountPrice = entity.DiscountPrice,
              Hours = entity.Hours,
              IsDigital = entity.Isdigital,
              IsBestseller = entity.IsBestSeller,
              NumberOfLikes = entity.NumbersOfLikes,
              LikesInProcent = entity.LikeInProcent,
              ImageUrl = entity.ImageUrl,
              BigImageUrl= entity.BigImageUrl,
              Category = entity.Category!.CategoryName

            };
        }
        catch { }
        return null!;
    }

    public static CourseEntity Create(CourseRegistrationForm form, int CategoryId )
    {
        try
        {
            var datetime = DateTime.Now;

            return new CourseEntity
            {
                Id = Guid.NewGuid().ToString(),
                Title = form.Title,
                Author = form.Author,
                OrginalPrice = form.OrginalPrice,
                Hours = form.Hours,
                Isdigital = form.Isdigital,
                Created = datetime,
                LastUpdated = datetime,
                ImageUrl = form.ImageUrl,
                BigImageUrl = form.BigImageUrl,
                CategoryId = CategoryId
            };
        }
        catch { }
        return null!;
    }

    public static IEnumerable<Course> Create(List<CourseEntity> entities)
    {
        var courses = new List<Course>();

        try
        {
            foreach (var entity in entities)
                courses.Add(Create(entity));

        }
        catch { }
        return courses;
    }
}
