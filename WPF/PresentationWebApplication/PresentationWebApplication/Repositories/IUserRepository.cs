using PresentationWebApplication.Entities;
using System.Threading.Tasks;

namespace PresentationWebApplication.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task UpdateEmailAsync(User user);

        Task UpdatePasswordAsync(User user);
    }
}