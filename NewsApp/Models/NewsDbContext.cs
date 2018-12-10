using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsApp.Models
{
    public class NewsDbContext: DbContext
    {
        public DbSet<News> News { get; set; }

        public NewsDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>()
                .Property(n => n.Title)
                .IsRequired(true);

            modelBuilder.Entity<News>()
                .Property(n => n.Content)
                .IsRequired(true);

            modelBuilder.Entity<News>()
                .Property(n => n.ImageURL)
                .IsRequired(true);

            modelBuilder.Entity<News>()
                .Property(n => n.PublishedDate)
                .IsRequired(true);

        }
    }
}
