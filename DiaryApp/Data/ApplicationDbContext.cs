
using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;
namespace DiaryApp.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "Went hiking",
                    Content = "went hiking with Guru",
                    CreatedAt = DateTime.Now
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "Went Clubing",
                    Content = "went cluping with Guru",
                    CreatedAt = DateTime.Now
                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "Went Shopping",
                    Content = "went shopping with Guru",
                    CreatedAt = DateTime.Now
                }

                );


        }
    }
}
