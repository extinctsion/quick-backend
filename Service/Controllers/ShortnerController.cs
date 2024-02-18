using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Serialization;
using System;
using Data.QuickDb;
using Model.URLShortner;
using Microsoft.EntityFrameworkCore;
using Service.Service;

namespace Service.Controllers
{
    [Route("api")]
    [ApiController]
    public class ShortnerController
    {
        private readonly IShortnerService _shortnerService;

        public ShortnerController(IShortnerService shortnerService)
        {
            _shortnerService = shortnerService;
        }

        [HttpGet("{key}")]
        public async Task<IActionResult> RedirectUrl(string key)
        {
            return await this._shortnerService.RedirectToMainURL(key);
        }

        [HttpPost]
        public async Task<IActionResult> ShortenUrl([FromBody] string originalUrl)
        {
            return await this._shortnerService.ShortenUrlKeyGenerator(originalUrl);
        }
    }
}
