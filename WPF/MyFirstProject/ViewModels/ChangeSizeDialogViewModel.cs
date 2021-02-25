using Infrastructure.Events;
using Models.Interfaces.Models;
using Models.Models;
using Prism.Commands;
using Prism.Events;
using Services.DialogService.Service;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace MyFirstProject.ViewModels
{
    public class ChangeSizeDialogViewModel : DialogViewModelBase<DialogResults>
    {
        private int _height;

        private int _width;

        private readonly string _regex = new Regex(@"\d").ToString();

        private IPresentation _selectedPresentation;

        private readonly IEventAggregator _eventAggregator;
        public ICommand CloseCommand { get; set; }
        public ICommand ChangeSizeCommand { get; set; }

        public int Height
        {
            get => _height;
            set => SetProperty(ref _height, value);
        }

        public int Width
        {
            get => _width;
            set
            {
                if (Regex.IsMatch(value.ToString(), _regex))
                    SetProperty(ref _width, value);
            }
        }

        public IPresentation SelectedPresentation
        {
            get => _selectedPresentation;
            set => SetProperty(ref _selectedPresentation, value);
        }

        public ChangeSizeDialogViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            eventAggregator.GetEvent<SelectedPresentationEvent>().Subscribe(OnSetSelectedPresentation);

            ChangeSizeCommand = new DelegateCommand(Change);
            CloseCommand = new DelegateCommand<IDialogWindow>(Close);
        }

        private void OnSetSelectedPresentation(IPresentation presentation)
        {
            SelectedPresentation = presentation;
        }

        private void Close(IDialogWindow window)
        {
            CloseDialogWithResult(window, DialogResults.Undefined);
        }

        private void Change()
        {
            if (Width != 0 && Height != 0)
            {
                var result = new Resolution
                {
                    Height = Height,
                    Width = Width
                };

                _eventAggregator.GetEvent<ChangeResolutionSizeEvent>().Publish(result);
            }
        }
    }
}