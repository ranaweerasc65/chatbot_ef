using chatbot_ef.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using chatbot_ef.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace chatbot_ef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public PlatformController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddPlatform(Platform platform)
        {
            _dataContext.Platforms.Add(platform);
            await _dataContext.SaveChangesAsync();
            return Ok(platform);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPlatforms()
        {
            var platforms = await _dataContext.Platforms.ToListAsync();
            return Ok(platforms);
        }
    }
}

