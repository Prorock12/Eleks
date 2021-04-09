using System.Threading.Tasks;

namespace Services.CRUDOperation
{
    public interface ICrudService
    {
        Task<bool> CheckIfUserExist(string login, string password);
        Task<bool> CreateNewUser(string login, string password);
    }
}
