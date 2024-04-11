using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class ApiContext(DbContextOptions<ApiContext> options) : DbContext(options)
    {
        public DbSet<SubscribeEntity> SubscribeEntities { get; set; }
        public DbSet<CourseEntity> Courses { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
    }
}
