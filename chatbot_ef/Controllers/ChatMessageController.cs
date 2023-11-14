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
    public class ChatMessageController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public ChatMessageController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddChatMessage(ChatMessage chatMessage)
        {
            _dataContext.ChatMessages.Add(chatMessage);
            await _dataContext.SaveChangesAsync();
            return Ok(chatMessage);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllChatMessages()
        {
            var chatMessages = await _dataContext.ChatMessages.ToListAsync();
            return Ok(chatMessages);
        }
    }
}

