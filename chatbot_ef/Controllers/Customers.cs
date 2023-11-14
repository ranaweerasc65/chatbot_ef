using Microsoft.AspNetCore.Http;
using chatbot_ef.Models;
using Microsoft.AspNetCore.Mvc;
using chatbot_ef.Data;
using Microsoft.EntityFrameworkCore;

namespace chatbot_ef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Customers : ControllerBase
    {
        private readonly DataContext _dataContext;
        public Customers(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer(Customer customer)
        {
            _dataContext.Customers.Add(customer);
            await _dataContext.SaveChangesAsync();
            return Ok(customer);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _dataContext.Customers.ToListAsync();
            return Ok(customers);
        }



    }
}
