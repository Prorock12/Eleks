using PresentationWebApplication.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationWebApplication.Repositories
{
    public class MessageRepository : BaseRepository<Message>, IMessageRepository
    {
        private readonly DatabaseContext _db;

        public MessageRepository(DatabaseContext context) : base(context)
        {
            _db = context;
        }

        public async Task UpdateTextAsync(Message message)
        {
            var currentUser = _db.Messages.FirstOrDefault(x => x.Id == message.Id);
            if (currentUser == null) return;
            _db.Entry(currentUser).Entity.Text = message.Text;
            await _db.SaveChangesAsync();
        }
    }
}