using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationWebApplication.Entities;

namespace PresentationWebApplication.Repositories
{
    public interface IMessageRepository : IRepository<Message>
    {
        Task UpdateTextAsync(Message message);
    }
}
