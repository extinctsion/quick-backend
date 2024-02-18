using Data.QuickDb;
using Interface.ShortnerInterface.Repository;
using Microsoft.EntityFrameworkCore;
using Model.URLShortner;

namespace Repository.ShortnerRepository
{
    public class ShortnerRepository : IShortnerRepository
    {
        private readonly QuickDbContext _context;

        public ShortnerRepository(QuickDbContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public async Task CreateShortendToken(Shortner shortner)
        {
            await this._context.Shortner.AddAsync(shortner);
            await _context.SaveChangesAsync();
        }

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
