using IQApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace IQApp.DataAccess.Concrete
{
    public class AppDbContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source=app1.db");


    }
}
