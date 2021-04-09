using Microsoft.AspNetCore.Mvc;
using PresentationWebApplication.Entities;
using PresentationWebApplication.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PresentationWebApplication.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _repository;
        private static readonly Regex EmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        private static readonly Regex PasswordRegex = new Regex(@"[A-Z]+\w+[0-9]+");

        public UsersController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _repository.GetElementsListAsync();
        }

        public async Task<User> GetUserAsync(int id)
        {
            return await _repository.GetElementAsync(id);
        }
        [HttpGet("default")]
        public async Task<User> GetUserDefaultAsync()
        {
            var users = await _repository.GetElementsListAsync();
            return users.FirstOrDefault();
        }

        [HttpPost("empty")]
        public async Task CreateAsync()
        {
            User user = new User() { Email = "admin@gmail.com", Password = "Uijasd2" };
            var matchEmail = EmailRegex.Match(user.Email);
            var matchPassword = PasswordRegex.Match(user.Password);
            if (matchEmail.Success && matchPassword.Success)
            {
                var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(user.Password));
                user.Password = string.Concat(hash.Select(b => b.ToString("X2")));
                await _repository.CreateAsync(user);
            }
        }

        [HttpPost]
        public async Task CreateUserAsync([FromBody] User user)
        {
            //var matchEmail = EmailRegex.Match(user.Email);
            //var matchPassword = PasswordRegex.Match(user.Password);
            //if (matchEmail.Success && matchPassword.Success)
            //{
                //var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(user.Password));
                //user.Password = string.Concat(hash.Select(b => b.ToString("X2")));
                await _repository.CreateAsync(user);
            //}
        }

        [HttpPut]
        public void EditUser([FromBody] User user)
        {
            var matchEmail = EmailRegex.Match(user.Email);
            var matchPassword = PasswordRegex.Match(user.Password);
            if (matchEmail.Success && matchPassword.Success)
            {
                var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(user.Password));
                user.Password = string.Concat(hash.Select(b => b.ToString("X2")));
                _repository.Update(user);
            }
        }

        [HttpPut("updateEmail")]
        public void EditUserEmail([FromBody] User user)
        {
            var matchEmail = EmailRegex.Match(user.Email);
            if (matchEmail.Success)
            {
                _repository.UpdateEmailAsync(user);
            }
        }

        [HttpPut("updatePassword")]
        public void EditUserPassword([FromBody] User user)
        {
            var matchPassword = PasswordRegex.Match(user.Password);
            if (matchPassword.Success)
            {
                var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(user.Password));
                user.Password = string.Concat(hash.Select(b => b.ToString("X2")));
                _repository.UpdatePasswordAsync(user);
            }
        }

        [HttpDelete]
        public async Task DeleteUserAsync(int id)
        {
            var user = await _repository.GetElementAsync(id);
            if (user != null)
            {
                await _repository.DeleteAsync(user, id);
            }
        }
    }
}