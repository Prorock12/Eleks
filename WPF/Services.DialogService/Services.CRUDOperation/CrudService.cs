using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Models.Models.ChatModel;
using Services.NavigationServices;

namespace Services.CRUDOperation
{
    public class CrudService : ICrudService
    {
        private readonly HttpClient _httpClient;
        private readonly INavigationService _navigationService;

        public CrudService(INavigationService navigationService)
        {
            _navigationService = navigationService;

            _httpClient = new HttpClient {BaseAddress = new Uri("http://localhost:5000/")};

            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<bool> CheckIfUserExist(string login, string password)
        {
            var response =
                await _httpClient.GetAsync(@"api/users");

            if (response.IsSuccessStatusCode)
            {
                var users = await response.Content.ReadAsAsync<IEnumerable<User>>();

                var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(password));
                password = string.Concat(hash.Select(b => b.ToString("X2")));

                var currentUser = users.FirstOrDefault(x => x.Email == login && x.Password == password);
                if (currentUser != null)
                    return true;
            }

            return false;
        }

        public async Task<bool> CreateNewUser(string login, string password)
        {

            var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(password));
            password = string.Concat(hash.Select(b => b.ToString("X2")));

            User user = new User()
            {
                Email = login,
                Password = password
            };

            var responsePost = await _httpClient.PostAsJsonAsync(@"api/users", user);

            return responsePost.IsSuccessStatusCode;
        }
    }
}
