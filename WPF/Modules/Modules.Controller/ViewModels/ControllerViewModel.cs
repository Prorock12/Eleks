using Infrastructure.Events;
using Models.Interfaces.Models;
using Models.Models;
using Modules.Controller.Interfaces;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Services.FilseSelector;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace Modules.Controller.ViewModels
{
    public class ControllerViewModel : BindableBase
    {
        #region Fields

        private readonly IFileSelector _fileSelector;

        private IQue _selectedQue;

        private readonly IEventAggregator _eventAggregator;

        private ISlide _selectedSlide;

        private bool _isStackView;

        #endregion Fields

        #region Properties

        public ICommand AddSlideCommand { get; }
        public ICommand AddTextCommand { get; }
        public ICommand AddImageCommand { get; }
        public ICommand AddVideoCommand { get; }

        public ObservableCollection<ISlideViewModel> Slides { get; }
        public ObservableCollection<IElement> Elements { get;  }

        public bool IsStackView
        {
            get => _isStackView;
            set => SetProperty(ref _isStackView, value);
        }

        public ISlide SelectedSlide
        {
            get => _selectedSlide;
            set => SetProperty(ref _selectedSlide, value, OnSelectedSlideChanged);
        }

        public IQue SelectedQue
        {
            get => _selectedQue;
            set => SetProperty(ref _selectedQue, value, OnSelectedQueChanged);
        }

        public ISlide Slide { get; set; }

        #endregion Properties

        #region Constructor

        public ControllerViewModel(IEventAggregator eventAggregator, IFileSelector fileSelector)
        {
            _eventAggregator = eventAggregator;
            _fileSelector = fileSelector;

            Slides = new ObservableCollection<ISlideViewModel>();

            eventAggregator.GetEvent<SelectedQueEvent>().Subscribe(OnSelectedQue);
            eventAggregator.GetEvent<SelectedSlideEvent>().Subscribe(OnSelectedSlide);

            eventAggregator.GetEvent<AddSlideEvent>().Subscribe(OnAddSlide);
            eventAggregator.GetEvent<RemoveSlideEvent>().Subscribe(OnRemoveSlide);

            AddSlideCommand =
                new DelegateCommand(AddSlide, CanChangeSlide).ObservesProperty(() => SelectedQue);

            AddTextCommand = new DelegateCommand(AddText, CanChangeElement).ObservesProperty(() => SelectedSlide);
            AddImageCommand = new DelegateCommand(AddImage, CanChangeElement).ObservesProperty(() => SelectedSlide);
            AddVideoCommand = new DelegateCommand(AddVideo, CanChangeSlide).ObservesProperty(() => SelectedSlide);
        }

        #endregion Constructor

        #region Methods

        private bool CanChangeSlide()
        {
            return SelectedQue != null;
        }

        private bool CanChangeElement()
        {
            return SelectedSlide != null;
        }

        private void OnLoadSlides()
        {
            if (SelectedQue == null)
            {
                return;
            }

            if (SelectedQue.Slides != null)
            {
                foreach (var slide in SelectedQue.Slides)
                {
                    Slides.Add(new SlideViewModel(slide));
                }
            }
        }

        private void OnSelectedQue(IQue que)
        {
            SelectedQue = que;
        }

        private void OnSelectedSlide(ISlide slide)
        {
            SelectedSlide = slide;
        }

        private void OnSelectedQueChanged()
        {
            Slides.Clear();
            OnLoadSlides();
        }

        private void OnSelectedSlideChanged()
        {
            _eventAggregator.GetEvent<SelectedSlideEvent>().Publish(SelectedSlide);
        }
        private void AddSlide()
        {
            var slide = new Slide("NewSlide");

            _eventAggregator.GetEvent<AddSlideEvent>().Publish(slide);
            SelectedQue.Slides?.Add(slide);
        }

        private void OnAddSlide(ISlide slide)
        {
            var slideViewModel = new SlideViewModel(slide);
            Slides.Add(slideViewModel);
            SelectedSlide = slide;
        }
        private void AddText()
        {
            var text = new TextElement("newText");
            SelectedSlide?.Elements.Add(text);

            _eventAggregator.GetEvent<AddTextElementEvent>().Publish(text);
        }
        private void AddImage()
        {
            var image = _fileSelector.ChooseImage();
            SelectedSlide?.Elements.Add(image);

            _eventAggregator.GetEvent<AddImageElementEvent>().Publish(image);
        }
        private void AddVideo()
        {
            var video = _fileSelector.ChooseVideo();
            SelectedSlide?.Elements.Add(video);

            _eventAggregator.GetEvent<AddVideoElementEvent>().Publish(video);
        }

        private void OnRemoveSlide(ISlide slide)
        {
            var removeSlide = Slides.First(x => x.Slide == slide);
            Slides.Remove(removeSlide);
        }

        #endregion Methods
    }
}