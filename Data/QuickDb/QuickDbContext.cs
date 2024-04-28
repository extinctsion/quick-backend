using Microsoft.EntityFrameworkCore;
using Model.URLShortner;

namespace Data.QuickDb
{
    /// <summary>
    /// QuickURL DB
    /// </summary>
    public class QuickDbContext : DbContext
    {
        /// <summary>
        /// DB context constructor
        /// </summary>
        /// <param name="options"></param>
        public QuickDbContext(DbContextOptions<QuickDbContext> options) : base(options)
        {
            
        }
        /// <summary>
        /// DB set entity
        /// </summary>
        public DbSet<Shortner> Shortner { get; set; }

        /// <summary>
        /// overriding the OnModelCreating method for creating entity
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shortner>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
