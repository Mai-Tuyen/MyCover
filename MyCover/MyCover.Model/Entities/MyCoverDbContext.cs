using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCover.Model.Entities
{
    public class MyCoverDbContext : DbContext
    {
        public MyCoverDbContext(DbContextOptions<MyCoverDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .EnableSensitiveDataLogging(true)
                .UseSqlServer(@"Server=AH;Database=MyCover;User Id=maituyen;Password=123456;");
        }
    }
}
