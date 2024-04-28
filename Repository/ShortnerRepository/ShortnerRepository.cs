using Data.QuickDb;
using Interface.ShortnerInterface.Repository;
using Microsoft.EntityFrameworkCore;
using Model.URLShortner;

namespace Repository.ShortnerRepository
{
    /// <summary>
    /// Repository
    /// </summary>
    public class ShortnerRepository : IShortnerRepository
    {
        private readonly QuickDbContext _context;

        /// <summary>
        /// Repository Constructor
        /// </summary>
        /// <param name="context"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ShortnerRepository(QuickDbContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// Method to create token
        /// </summary>
        /// <param name="shortner"></param>
        /// <returns></returns>
        public async Task CreateShortendToken(Shortner shortner)
        {
            await this._context.Shortner.AddAsync(shortner);
            await _context.SaveChangesAsync();
        }
        /// <summary>
        /// method to get corresponding URL from DB
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<string> GetURLAsync(string key)
        {
            var URL = await _context.Shortner
                .Where(u => u.GeneratedKey == key)
                .Select(u => u.URL)
                .FirstOrDefaultAsync();
            if (URL == null)
            {
                return "NoURL Found";
            }
            return URL;
        }  
    }
}
