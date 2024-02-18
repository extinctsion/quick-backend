using Microsoft.AspNetCore.Mvc;

namespace Service.Service
{
    public interface IShortnerService
    {
        Task<IActionResult> ShortenUrlKeyGenerator(string originalUrl);
        Task<IActionResult> RedirectToMainURL(string key);
    }
}