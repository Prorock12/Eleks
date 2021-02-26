using Infrastructure.Events;
using Models.Models;
using Modules.PresentationRegion.Interfaces;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;

namespace Modules.PresentationRegion.ViewModels
{
    public class PresentationContainerViewModel : BindableBase
    {
        #region Fields

        private readonly IEventAggregator _eventAggregator;

        private PresentationViewModel _selectedPresentation;

        #endregion Fields

        #region Properties

        public ObservableCollection<IPresentationViewModel> Presentations { get; set; }
        public ICommand AddPresentationCommand { get; }
        public ICommand RemovePresentationCommand { get; }
        public ICommand ChangeSizeCommand { get; }

        public PresentationViewModel SelectedPresentation
        {
            get => _selectedPresentation;
            set => SetProperty(ref _selectedPresentation, value, OnSelectedPresentationChanged);
        }

        #endregion Properties

        #region Constructor

        public PresentationContainerViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            AddPresentationCommand = new DelegateCommand(AddPresentation);
            RemovePresentationCommand = new DelegateCommand(RemovePresentation);
            ChangeSizeCommand = new DelegateCommand(ChangeSizeSendRequest);

            Presentations = new ObservableCollection<IPresentationViewModel>
            {
                new PresentationViewModel(new Presentation("FirstPresentation" )),
                new PresentationViewModel(new Presentation("Second" ))
            };
        }

        #endregion Constructor

        #region Methods

        private void ChangeSizeSendRequest()
        {
            _eventAggregator.GetEvent<SendRequestChangeSizeEvent>().Publish();
        }

        private void OnSelectedPresentationChanged()
        {
            _eventAggregator.GetEvent<SelectedPresentationEvent>().Publish(SelectedPresentation?.Presentation);
        }

        private void AddPresentation()
        {
            var presentation = new PresentationViewModel(new Presentation("newSlide"));
            Presentations.Insert(Presentations.Count, presentation);
            SelectedPresentation = presentation;
        }

        private void RemovePresentation()
        {
            Presentations.Remove(SelectedPresentation);
        }

        #endregion Methods
    }
}