using MyFirstProject.Views;
using Prism.Commands;
using Prism.Mvvm;
using System.Windows.Input;
using Infrastructure.Events;
using Prism.Events;
using Unity;
using IDialogService = Services.DialogService.Service.IDialogService;

namespace MyFirstProject.ViewModels
{
    public class ShellViewModel : BindableBase
    {
        private readonly IDialogService _dialogService;

        private readonly IUnityContainer _unityContainer;
        public ICommand ChangeSizeCommand { get; set; }

        #region Constructor

        public ShellViewModel(IDialogService dialogService, IUnityContainer unityContainer,IEventAggregator eventAggregator)
        {
            _dialogService = dialogService;
            _unityContainer = unityContainer;

            ChangeSizeCommand = new DelegateCommand(ChangeSize);

            eventAggregator.GetEvent<SendRequestChangeSizeEvent>().Subscribe(ChangeSize);
        }

        private void ChangeSize()
        {
            var control = _unityContainer.Resolve<ChangeSizeDialogView>();
            var result = _dialogService.ShowDialog(control);
            //var size = result as Size;
        }

        #endregion Constructor
    }
}