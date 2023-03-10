using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PrivateLessonsPlannerApi.Models;

namespace PrivateLessonsPlannerApi.Data
{
    public class DbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<HomeWork> HomeWork { get; set; }
        public DbSet<PrivateLesson> PrivateLessons { get; set; }
        public DbSet<Status> Statuses { get; set; }

    }
}
