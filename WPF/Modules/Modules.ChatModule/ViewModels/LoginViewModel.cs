using Prism.Commands;
using Prism.Mvvm;
using System.Windows.Input;
using Modules.ChatModule.Views;
using Services.NavigationServices;

namespace Modules.ChatModule.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        private string _login;
        private string _password;
        private readonly INavigationService _navigationService;

        public string Login
        {
            get =>_login;
            set => SetProperty(ref _login, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public ICommand NavigateToRegistrationCommand { get; set; }
        public ICommand NavigateToChatCommand { get; set; }
        public LoginViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NavigateToChatCommand = new DelegateCommand(NavigateToChat);
            NavigateToRegistrationCommand = new DelegateCommand(NavigateToRegistration);
        }

        public void NavigateToRegistration()
        {
            _navigationService.NavigateChatToAnotherView(typeof(RegistrationView));
        }
        public void NavigateToChat()
        { 
            _navigationService.NavigateChatToAnotherView(typeof(ChatView));
        }
    }
}
