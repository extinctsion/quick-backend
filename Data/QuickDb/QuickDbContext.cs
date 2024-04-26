using Microsoft.EntityFrameworkCore;
using Model.URLShortner;

namespace Data.QuickDb
{
    /// <summary>
    /// QuickURL DB
    /// </summary>
    public class QuickDbContext : DbContext
    {
        public QuickDbContext(DbContextOptions<QuickDbContext> options) : base(options)
        {
            
        }
        public DbSet<Shortner> Shortner { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shortner>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
