using Prism.Commands;
using Prism.Mvvm;
using System.Windows.Input;
using Modules.ChatModule.Views;
using Services.NavigationServices;

namespace Modules.ChatModule.ViewModels
{
    public class RegistrationViewModel : BindableBase
    {
        private string _login;
        private string _password;
        private string _confirmPassword;
        private readonly INavigationService _navigationService;

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
        public RegistrationViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            GoToLoginCommand = new DelegateCommand(GoToLogin);
        }

        private void GoToLogin()
        {
             _navigationService.NavigateChatToAnotherView(typeof(LoginView));
        }
        private void GoToChat()
        {
            _navigationService.NavigateChatToAnotherView(typeof(ChatView));
        }
    }
}
