using Microsoft.AspNetCore.Mvc;
using PresentationWebApplication.Entities;
using PresentationWebApplication.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PresentationWebApplication.Controllers
{
    [Route("api/messages")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageRepository _repository;

        public MessageController(IMessageRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Message>> GetMessagesAsync()
        {
            return await _repository.GetElementsListAsync();
        }

        public async Task<Message> GetMessageAsync(int id)
        {
            return await _repository.GetElementAsync(id);
        }

        [HttpPost]
        public async Task CreateMessageAsync([FromBody] Message message)
        {
            if (message.SenderId != null && message.ReceiverId != null)
                await _repository.CreateAsync(message);
        }

        [HttpPut]
        public void EditMessage([FromBody] Message message)
        {
            _repository.Update(message);
        }

        [HttpPut("updateMessageText")]
        public void EditMessageText([FromBody] Message message)
        {
            _repository.UpdateTextAsync(message);
        }

        [HttpDelete]
        public async Task DeleteMessageAsync(int id)
        {
            var user = await _repository.GetElementAsync(id);
            if (user != null)
            {
                await _repository.DeleteAsync(user, id);
            }
        }
    }
}