using jap_task1_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace jap_task1_backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "ACTION"},
                new Category { Id = 2, Name = "COMEDY" },
                new Category { Id = 3, Name = "THRILLER" }
            );
        }
    }
}
