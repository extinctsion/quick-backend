using Model.URLShortner;

namespace Interface.ShortnerInterface.Repository
{
    /// <summary>
    /// IShortnerRepository Interface
    /// </summary>
    public interface IShortnerRepository
    {
        /// <summary>
        /// Method to generate unique token
        /// </summary>
        /// <param name="shortner"></param>
        /// <returns>unique tokens</returns>
        Task CreateShortendToken(Shortner shortner);
        /// <summary>
        /// Method to get the URL from data
        /// </summary>
        /// <param name="key"></param>
        /// <returns>URL as string</returns>
        Task<string> GetURLAsync(string key);
    }
}