using Microsoft.AspNetCore.Mvc;

namespace Service.Service
{
    /// <summary>
    /// Interface for Shortner service
    /// </summary>
    public interface IShortnerService
    {
        /// <summary>
        /// method to generate shortened URL
        /// </summary>
        /// <param name="originalUrl"></param>
        /// <returns>unique key</returns>
        Task<IActionResult> ShortenUrlKeyGenerator(string originalUrl);
        /// <summary>
        /// Method that redirects to Main URL
        /// </summary>
        /// <param name="key"></param>
        /// <returns>redirects to the main URL</returns>
        Task<IActionResult> RedirectToMainURL(string key);
    }
}