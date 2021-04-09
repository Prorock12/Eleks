using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
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
    public class LoginViewModel : BindableBase
    {
        private string _login;
        private string _password;
        private readonly INavigationService _navigationService;
        private readonly ICrudService _crudService;

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

        public ICommand NavigateToRegistrationCommand { get; set; }
        public ICommand NavigateToChatCommand { get; set; }

        public LoginViewModel(INavigationService navigationService, ICrudService crudService)
        {
            _navigationService = navigationService;
            _crudService = crudService;

            NavigateToChatCommand = new DelegateCommand(NavigateToChat);
            NavigateToRegistrationCommand = new DelegateCommand(NavigateToRegistration);
        }

        public void NavigateToRegistration()
        {
            _navigationService.NavigateChatToAnotherView(typeof(RegistrationView));
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
                    if (currentUser != null)
                        _navigationService.NavigateChatToAnotherView(typeof(ChatView));
                }
            }
        }
        public async void NavigateToChat()
        {
            //await CheckUser();
            var isExist = await _crudService.CheckIfUserExist(Login, Password);
            if(isExist)
                _navigationService.NavigateChatToAnotherView(typeof(ChatView));
        }
    }
}