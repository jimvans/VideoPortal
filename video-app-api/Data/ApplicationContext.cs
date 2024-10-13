using Microsoft.EntityFrameworkCore;
using video_app_api.Models;

namespace video_app_api.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Video> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
