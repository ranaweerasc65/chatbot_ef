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
    public class AppoinmentController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public AppoinmentController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddAppoinment(Appoinment appoinment)
        {
            _dataContext.Appointments.Add(appoinment);
            await _dataContext.SaveChangesAsync();
            return Ok(appoinment);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAppoinments()
        {
            var appoinments = await _dataContext.Appointments.ToListAsync();
            return Ok(appoinments);
        }
    }
}

