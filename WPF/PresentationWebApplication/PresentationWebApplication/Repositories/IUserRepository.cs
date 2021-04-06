using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationWebApplication.Entities;

namespace PresentationWebApplication.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task UpdateEmailAsync(User user);
        Task UpdatePasswordAsync(User user);
    }
}
