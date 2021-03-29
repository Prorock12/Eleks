using Infrastructure;
using Prism.Commands;
using Services.DialogService.Service;
using System.Windows.Input;

namespace MyFirstProject.ViewModels
{
    public class ShowValueExtensionViewModel : DialogViewModelBase<DialogResults>
    {
        private int _value;

        public int Value
        {
            get => _value;
            set => SetProperty(ref _value, value);
        }

        public ICommand SolveCommand { get; }

        public ShowValueExtensionViewModel()
        {
            SolveCommand = new DelegateCommand(Solve);
        }

        private void Solve()
        {
            Value = Value.Clamp(10, 100);
        }
    }
}