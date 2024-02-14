using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Serialization;
using System;
using Data.QuickDb;
using Model.URLShortner;
using Microsoft.EntityFrameworkCore;

namespace Service.Controllers
{
    [Route("api")]
    [ApiController]
    public class ShortnerController : ControllerBase
    {
        private readonly QuickDbContext _context;

        public ShortnerController(QuickDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> ShortenUrl([FromBody] string originalUrl)
        {
            // Check if the URL is valid (you may want to enhance this validation)
            if (Uri.TryCreate(originalUrl, UriKind.Absolute, out _))
            {
                var key = Guid.NewGuid().ToString().Substring(0, 8);
                var mapping = new Shortner
                { 
                    CreatedAt = DateTime.UtcNow, 
                    LastUpdatedAt = DateTime.UtcNow,
                    GeneratedKey = key,
                    URL = originalUrl
                };

                // Generate a unique key for the shortened URL (you may use a library for this)
                _context.Shortner.Add(mapping);
                await _context.SaveChangesAsync();

                return Ok(new { Key = key });
            }

            return BadRequest("Invalid URL");
        }

        [HttpGet("{key}")]
        public async Task<IActionResult> RedirectUrl(string key)
        {
            var mapping = await _context.Shortner
                .Where(u => u.GeneratedKey == key)
                .Select(u => u.URL)
                .FirstOrDefaultAsync();

            if (mapping != null)
            {
                return Redirect(mapping);
            }

            return NotFound();
        }
    }
}
