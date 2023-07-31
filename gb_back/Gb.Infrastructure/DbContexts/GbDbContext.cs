using Gb.Domain.DbEntities;
using Gb.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Gb.Infrastructure.DbContexts
{
    public class GbDbContext : DbContext
    {
        public DbSet<CommentDb> Comments { get; set; }

        public GbDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CommentTypeConfiguration());
        }
    }
}