using System.Globalization;
using System.Windows;
using Infrastructure.Events;
using MyFirstProject.Views;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System.Windows.Input;
using Unity;
using IDialogService = Services.DialogService.Service.IDialogService;

namespace MyFirstProject.ViewModels
{
    public class ShellViewModel : BindableBase
    {
        private static IDialogService _dialogService;

        private static IUnityContainer _unityContainer;

        public ICommand ChangeSizeCommand { get; set; }

        #region Constructor

        public ShellViewModel(IDialogService dialogService, IUnityContainer unityContainer, IEventAggregator eventAggregator)
        {
            _dialogService = dialogService;
            _unityContainer = unityContainer;

            ChangeSizeCommand = new DelegateCommand(ChangeSize);

            eventAggregator.GetEvent<SendRequestChangeSizeEvent>().Subscribe(ChangeSize);
        }

        #endregion Constructor
        private void ChangeSize()
        {
            var control = _unityContainer.Resolve<ChangeSizeDialogView>();
            var result = _dialogService.ShowDialog(control);
            //var size = result as Size;
        }
        public static void SetBaseSettings()
        {
            var control = _unityContainer.Resolve<BaseSettings>();
            var result = _dialogService.ShowDialog(control);
            //var size = result as Size;
        }
    }
}