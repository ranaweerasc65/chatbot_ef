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
    public class ShopOwnerController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public ShopOwnerController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddShopOwner(ShopOwner shopOwner)
        {
            _dataContext.ShopOwners.Add(shopOwner);
            await _dataContext.SaveChangesAsync();
            return Ok(shopOwner);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllShopOwners()
        {
            var shopOwners = await _dataContext.ShopOwners.ToListAsync();
            return Ok(shopOwners);
        }
    }
}
