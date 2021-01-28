using Infrastructure.Events;
using Models.Interfaces.ViewModels;
using Models.Models;
using Prism.Commands;
using Prism.Events;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Models.Interfaces.Models;
using BindableBase = Prism.Mvvm.BindableBase;

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

            eventAggregator.GetEvent<AddSlideEvent>().Subscribe(OnAddSlide);
            eventAggregator.GetEvent<RemoveSlideEvent>().Subscribe(OnRemoveSlide);


            AddPresentationCommand = new DelegateCommand(AddPresentation);
            RemovePresentationCommand = new DelegateCommand(RemovePresentation);

            Presentations = new ObservableCollection<IPresentationViewModel>
            {
                new PresentationViewModel(new Presentation{Name = "FirstPresentation" }),
                new PresentationViewModel(new Presentation{Name = "Second" })
            };
        }

        #endregion Constructor

        #region Methods

        private void OnAddSlide(ISlide slide)
        {
            var addSlide = Presentations.First(x => x.Presentation == SelectedPresentation.Presentation);

            addSlide.Presentation.Slides.Add(slide);
        }

        private void OnRemoveSlide(ISlide slide)
        {
            var removeSlide = Presentations.First(x => x.Presentation == SelectedPresentation.Presentation);

            removeSlide.Presentation.Slides.Remove(slide);
        }

        private void OnSelectedPresentationChanged()
        {
            _eventAggregator.GetEvent<SelectedPresentationEvent>().Publish(SelectedPresentation?.Presentation);
        }

        private void AddPresentation()
        {
            var presentation = new PresentationViewModel(new Presentation { Name = "newSlide" });
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