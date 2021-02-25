using Infrastructure.Events;
using Models.Interfaces.Models;
using Models.Models;
using Modules.Slides.Interfaces;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace Modules.Slides.ViewModels
{
    public class SlideContainerViewModel : BindableBase
    {
        #region Fields

        private IPresentation _selectedPresentation;

        private readonly IEventAggregator _eventAggregator;

        private ISlideViewModel _selectedSlide;

        #endregion Fields

        #region Properties

        public ICommand AddSlideCommand { get; }
        public ICommand RemoveSlideCommand { get; }

        public ObservableCollection<ISlideViewModel> Slides { get; }

        public ISlideViewModel SelectedSlide
        {
            get => _selectedSlide;
            set => SetProperty(ref _selectedSlide, value, OnSelectedSlideChanged);
        }

        public IPresentation SelectedPresentation
        {
            get => _selectedPresentation;
            set => SetProperty(ref _selectedPresentation, value, OnSelectedPresentationChanged);
        }

        #endregion Properties

        #region Constructor

        public SlideContainerViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            Slides = new ObservableCollection<ISlideViewModel>();

            eventAggregator.GetEvent<SelectedPresentationEvent>().Subscribe(OnSelectedPresentation);

            eventAggregator.GetEvent<AddSlideEvent>().Subscribe(OnAddSlide);
            eventAggregator.GetEvent<RemoveSlideEvent>().Subscribe(OnRemoveSlide);

            AddSlideCommand = new DelegateCommand(AddSlide, CanChangeSlide).ObservesProperty(() => SelectedPresentation);
            RemoveSlideCommand = new DelegateCommand(RemoveSlide, CanChangeSlide).ObservesProperty(() => SelectedPresentation);
        }

        #endregion Constructor

        #region Methods

        private bool CanChangeSlide()
        {
            return SelectedPresentation != null;
        }

        private void OnLoadSlides()
        {
            if (SelectedPresentation == null)
            {
                return;
            }

            foreach (var slide in SelectedPresentation.Slides)
            {
                Slides.Add(new SlideViewModel(slide));
            }
        }

        private void OnSelectedPresentation(IPresentation presentation)
        {
            SelectedPresentation = presentation;
        }

        private void OnSelectedPresentationChanged()
        {
            Slides.Clear();
            OnLoadSlides();
            //SelectedSlide = Slides.FirstOrDefault();
        }

        private void OnSelectedSlideChanged()
        {
            _eventAggregator.GetEvent<SelectedSlideEvent>().Publish(SelectedSlide?.Slide);
        }

        private void AddSlide()
        {
            var slide = new Slide("NewSlide");

            _eventAggregator.GetEvent<AddSlideEvent>().Publish(slide);

            SelectedPresentation.Slides.Add(slide);
        }

        private void OnAddSlide(ISlide slide)
        {
            var slideViewModel = new SlideViewModel(slide);
            Slides.Add(slideViewModel);
            SelectedSlide = slideViewModel;
        }

        private void RemoveSlide()
        {
            SelectedPresentation.Slides.Remove(SelectedSlide.Slide);

            _eventAggregator.GetEvent<RemoveSlideEvent>().Publish(SelectedSlide.Slide);
        }

        private void OnRemoveSlide(ISlide slide)
        {
            var removeSlide = Slides.First(x => x.Slide == slide);
            Slides.Remove(removeSlide);

            //select s;lide
        }

        #endregion Methods
    }
}