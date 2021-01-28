using Infrastructure.Events;
using Models.Interfaces.Models;
using Models.Interfaces.ViewModels;
using Models.Models;
using Prism.Commands;
using Prism.Events;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using BindableBase = Prism.Mvvm.BindableBase;

namespace Modules.Slides.ViewModels
{
    public class SlideContainerViewModel : BindableBase
    {
        #region Fields

        private IPresentation _selectedPresentation;

        private bool _isSelectedPresentation;

        private readonly IEventAggregator _eventAggregator;

        private SlideViewModel _selectedSlide;

        #endregion Fields

        #region Properties

        public bool IsSelectedPresentation
        {
            get => _isSelectedPresentation;
            set => SetProperty(ref _isSelectedPresentation, value);
        }

        public ICommand AddSlideCommand { get; }
        public ICommand RemoveSlideCommand { get; }

        public ObservableCollection<ISlideViewModel> Slides { get; }

        public SlideViewModel SelectedSlide
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

        public SlideContainerViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            Slides = new ObservableCollection<ISlideViewModel>();

            eventAggregator.GetEvent<SelectedPresentationEvent>().Subscribe(OnSelectedPresentation);

            eventAggregator.GetEvent<AddSlideEvent>().Subscribe(OnAddSlide);

            eventAggregator.GetEvent<AddTextElementEvent>().Subscribe(AddTextElementChanged);
            eventAggregator.GetEvent<AddImageElementEvent>().Subscribe(AddImageElementChanged);
            eventAggregator.GetEvent<AddVideoElementEvent>().Subscribe(AddVideoElementChanged);
            eventAggregator.GetEvent<RemoveElementEvent>().Subscribe(RemoveElementChanged);

            AddSlideCommand = new DelegateCommand(AddSlide, CanChangeSlide).ObservesProperty(() => SelectedPresentation);
            RemoveSlideCommand = new DelegateCommand(RemoveSlide, CanChangeSlide).ObservesProperty(() => SelectedPresentation);
        }

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
        }

        private void OnSelectedSlideChanged()
        {
            _eventAggregator.GetEvent<SelectedSlideEvent>().Publish(SelectedSlide?.Slide);
        }

        private void AddSlide()
        {
            var slide = new Slide("NewSlide");

            _eventAggregator.GetEvent<AddSlideEvent>().Publish(slide);
        }

        private void OnAddSlide(ISlide slide)
        {
            var slideViewModel = new SlideViewModel(slide);
            Slides.Add(slideViewModel);
            SelectedSlide = slideViewModel;
        }

        private void RemoveSlide()
        {
            _eventAggregator.GetEvent<RemoveSlideEvent>().Publish(SelectedSlide.Slide);

            Slides.Remove(SelectedSlide);
        }

        private void AddTextElementChanged(IElement element)
        {
            var addText = Slides.First(x => x.Slide == SelectedSlide.Slide);

            addText.Slide.Elements.Add(element);
        }

        private void AddImageElementChanged(IElement element)
        {
            var addImage = Slides.First(x => x.Slide == SelectedSlide.Slide);

            addImage.Slide.Elements.Add(element);
        }

        private void AddVideoElementChanged(IElement element)
        {
            var addVideo = Slides.First(x => x.Slide == SelectedSlide.Slide);

            addVideo.Slide.Elements.Add(element);
        }

        private void RemoveElementChanged(IElement element)
        {
            var removeElement = Slides.First(x => x.Slide == SelectedSlide.Slide);

            removeElement.Slide.Elements.Remove(element);
        }
        #endregion Methods
    }
}