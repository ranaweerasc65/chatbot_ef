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
    public class ChatSessionController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public ChatSessionController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddChatSession(ChatSession chatSession)
        {
            _dataContext.ChatSessions.Add(chatSession);
            await _dataContext.SaveChangesAsync();
            return Ok(chatSession);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllChatSessions()
        {
            var chatSessions = await _dataContext.ChatSessions.ToListAsync();
            return Ok(chatSessions);
        }
    }
}

