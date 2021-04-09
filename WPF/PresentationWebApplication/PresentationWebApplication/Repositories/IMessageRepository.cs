using PresentationWebApplication.Entities;
using System.Threading.Tasks;

namespace PresentationWebApplication.Repositories
{
    public interface IMessageRepository : IRepository<Message>
    {
        Task UpdateTextAsync(Message message);
    }
}