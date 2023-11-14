using chatbot_ef.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using chatbot_ef.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace chatbot_ef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public CategoryController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(Category category)
        {
            _dataContext.Categories.Add(category);
            await _dataContext.SaveChangesAsync();
            return Ok(category);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _dataContext.Categories.ToListAsync();
            return Ok(categories);
        }
    }
}
