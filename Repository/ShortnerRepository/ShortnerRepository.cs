using Data.QuickDb;

namespace Repository.ShortnerRepository
{
    public class ShortnerRepository
    {
        private readonly QuickDbContext _context;

        public ShortnerRepository(QuickDbContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }

        //public async Task<>
    }
}
