using PresentationWebApplication.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationWebApplication.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly DatabaseContext _db;

        public UserRepository(DatabaseContext context) : base(context)
        {
            _db = context;
        }

        public async Task UpdateEmailAsync(User item)
        {
            var currentUser = _db.Users.FirstOrDefault(x => x.Id == item.Id);
            if (currentUser == null) return;
            _db.Entry(currentUser).Entity.Email = item.Email;
            await _db.SaveChangesAsync();
        }

        public async Task UpdatePasswordAsync(User item)
        {
            var currentUser = _db.Users.FirstOrDefault(x => x.Id == item.Id);
            if (currentUser == null) return;
            _db.Entry(currentUser).Entity.Password = item.Password;
            await _db.SaveChangesAsync();
        }
    }
}