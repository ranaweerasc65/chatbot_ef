using chatbot_ef.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using chatbot_ef.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace chatbot_ef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public ShopController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddShop(Shop shop)
        {
            _dataContext.Shops.Add(shop);
            await _dataContext.SaveChangesAsync();
            return Ok(shop);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllShops()
        {
            var shops = await _dataContext.Shops.ToListAsync();
            return Ok(shops);
        }
    }
}
