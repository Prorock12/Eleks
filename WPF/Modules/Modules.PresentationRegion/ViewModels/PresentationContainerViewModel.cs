using Infrastructure.Events;
using Models.Models;
using Modules.PresentationRegion.Interfaces;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Modules.PresentationRegion.ViewModels
{
    public class PresentationContainerViewModel : BindableBase
    {
        #region Fields

        private readonly IEventAggregator _eventAggregator;

        private IPresentationViewModel _selectedPresentation;

        #endregion Fields

        #region Properties

        public ObservableCollection<IPresentationViewModel> Presentations { get; set; }
        public ICommand AddPresentationCommand { get; }
        public ICommand RemovePresentationCommand { get; }
        public ICommand ChangeSizeCommand { get; }

        public IPresentationViewModel SelectedPresentation
        {
            get => _selectedPresentation;
            set => SetProperty(ref _selectedPresentation, value, OnSelectedPresentationChanged);
        }

        #endregion Properties

        #region Constructor

        public PresentationContainerViewModel(IEventAggregator eventAggregator) : this()
        {
            _eventAggregator = eventAggregator;

            AddPresentationCommand = new DelegateCommand(AddPresentation);
            RemovePresentationCommand = new DelegateCommand(RemovePresentation);
            ChangeSizeCommand = new DelegateCommand(ChangeSizeSendRequest);
        }

        public PresentationContainerViewModel()
        {
            Presentations = new ObservableCollection<IPresentationViewModel>();
        }

        #endregion Constructor

        #region Methods

        private void ChangeSizeSendRequest()
        {
            _eventAggregator?.GetEvent<SendRequestChangeSizeEvent>().Publish();
        }

        private void OnSelectedPresentationChanged()
        {
            _eventAggregator?.GetEvent<SelectedPresentationEvent>().Publish(SelectedPresentation?.Presentation);
        }
        private void AddPresentation()
        {
            var presentation = new PresentationViewModel(new Presentation("newSlide"));
            Presentations?.Add(presentation);
            //if (SelectedPresentation != null)
                SelectedPresentation = presentation;
        }
        private void RemovePresentation()
        {
            if (SelectedPresentation != null)
                Presentations.Remove(SelectedPresentation);
        }

        #endregion Methods
    }
}