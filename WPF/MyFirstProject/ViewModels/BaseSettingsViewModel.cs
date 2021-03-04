using System.Globalization;
using System.Threading;
using System.Windows;
using Prism.Commands;
using System.Windows.Input;
using Infrastructure;
using Services.ApplicationSettingsBase;
using Services.DialogService.Service;
using MyFirstProject.Properties;
using MyFirstProject.Views;
using IDialogWindow = Services.DialogService.Service.IDialogWindow;

namespace MyFirstProject.ViewModels
{
    public class BaseSettingsViewModel : DialogViewModelBase<DialogResults>
    {
        //ApplicationSettingsBase
        private readonly ISettingsServices _settingsServices;

        private Language _selectedLanguage;
        public Language SelectedLanguage
        {
            get => _selectedLanguage;
            set => SetProperty(ref _selectedLanguage, value, OnChangedLanguage);
        }

        public ICommand CloseCommand { get; set; }

        public BaseSettingsViewModel(ISettingsServices settingsServices)
        {
            _settingsServices = settingsServices;
            ////Set intitial value selected language
            CloseCommand = new DelegateCommand<IDialogWindow>(Close);
        }
        private void Close(IDialogWindow window)
        {
            CloseDialogWithResult(window, DialogResults.Undefined);
        }
        private void OnChangedLanguage()
        {
            _settingsServices.CurrentLanguage = SelectedLanguage.Culture;
            var result = MessageBox.Show(Resources.MessageBoxLanguage,"You broke something",MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                var oldWindow = Application.Current.MainWindow;

                Application.Current.MainWindow = new ShellView(_settingsServices);
                Application.Current.MainWindow.Show();

                oldWindow?.Close();
            }
            else
            {
      
            }
            //If yes = save value in settings, close window, 
            //if no don`t change property
        }
    }
}
