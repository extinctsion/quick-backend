using Model.URLShortner;

namespace Interface.ShortnerInterface.Repository
{
    public interface IShortnerRepository
    {
        Task CreateShortendToken(Shortner shortner);
        Task<string> GetURLAsync(string key);
    }
}