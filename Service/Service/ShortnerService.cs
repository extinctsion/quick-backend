using Interface.ShortnerInterface.Repository;
using Microsoft.AspNetCore.Mvc;
using Model.URLShortner;

namespace Service.Service
{
    public class ShortnerService : ControllerBase, IShortnerService
    {
        private readonly IShortnerRepository _shortnerRepository;
        public ShortnerService(IShortnerRepository shortnerRepository)
        {
            this._shortnerRepository = shortnerRepository;
        }

        public async Task<IActionResult> ShortenUrlKeyGenerator(string originalUrl, string domain)
        {
            if (Uri.TryCreate(originalUrl, UriKind.Absolute, out _))
            {
                
                var key = Guid.NewGuid().ToString()[..8];
                Shortner mapping = new()
                {
                    CreatedAt = DateTime.UtcNow,
                    LastUpdatedAt = DateTime.UtcNow,
                    GeneratedKey = key,
                    URL = originalUrl
                };

                // Generate a unique key for the shortened URL (you may use a library for this)
                await this._shortnerRepository.CreateShortendToken(mapping);

                return Ok(new { QuickURl = domain +key });
            }
            return BadRequest("Invalid URL");
        }

        public async Task<IActionResult> RedirectToMainURL(string key)
        {
            var mapping = await this._shortnerRepository.GetURLAsync(key);

            if (mapping != null)
            {
                return Redirect(mapping);
            }

            return NotFound("Key not found");
        }
    }
}
