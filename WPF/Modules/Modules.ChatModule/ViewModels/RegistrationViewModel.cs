using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Modules.ChatModule.Views;
using Prism.Commands;
using Prism.Mvvm;
using Services.NavigationServices;
using System.Windows.Input;
using Models.Models.ChatModel;
using Services.CRUDOperation;

namespace Modules.ChatModule.ViewModels
{
    public class RegistrationViewModel : BindableBase
    {
        private string _login;
        private string _password;
        private string _confirmPassword;
        private readonly INavigationService _navigationService;
        private readonly ICrudService _crudService;
        private static readonly Regex EmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        private static readonly Regex PasswordRegex = new Regex(@"[A-Z]+\w+[0-9]+");

        public string Login
        {
            get => _login;
            set => SetProperty(ref _login, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public string ConfirmPassword
        {
            get => _confirmPassword;
            set => SetProperty(ref _confirmPassword, value);
        }

        public ICommand GoToLoginCommand { get; set; }
        public ICommand GoToChatCommand { get; set; }

        public RegistrationViewModel(INavigationService navigationService, ICrudService crudService)
        {
            _navigationService = navigationService;
            _crudService = crudService;

            GoToLoginCommand = new DelegateCommand(GoToLogin);
            GoToChatCommand = new DelegateCommand(GoToChat);
        }

        private void GoToLogin()
        {
            _navigationService.NavigateChatToAnotherView(typeof(LoginView));
        }

        public async Task CheckUser()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:5000/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));



                var response =
                    await httpClient.GetAsync(@"api/users");

                if (response.IsSuccessStatusCode)
                {
                    var users = await response.Content.ReadAsAsync<IEnumerable<User>>();

                    var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(Password));
                    Password = string.Concat(hash.Select(b => b.ToString("X2")));

                    var currentUser = users.FirstOrDefault(x => x.Email == Login && x.Password == Password);
                    if (currentUser == null)
                       await CreateNewUser();
                }
            }
        }

        public async Task CreateNewUser()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:5000/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(Password));
                Password = string.Concat(hash.Select(b => b.ToString("X2")));

                User user = new User()
                {
                    Email = Login,
                    Password = Password
                };

                var responsePost = await httpClient.PostAsJsonAsync(@"api/users", user);

                if (responsePost.IsSuccessStatusCode)
                    _navigationService.NavigateChatToAnotherView(typeof(ChatView));
            }
        }

        private async void GoToChat()
        {
            var matchEmail = EmailRegex.Match(Login);
            var matchPassword = PasswordRegex.Match(Password);
            if (!matchEmail.Success || !matchPassword.Success) return;
            if (Password != ConfirmPassword) return;
            var isExist = await _crudService.CheckIfUserExist(Login, Password);

            if (!isExist)
            {
                var isCreated = await _crudService.CreateNewUser(Login, Password);
                if(isCreated)
                    _navigationService.NavigateChatToAnotherView(typeof(ChatView));
            }

            

            //await CheckUser();
        }
    }
}