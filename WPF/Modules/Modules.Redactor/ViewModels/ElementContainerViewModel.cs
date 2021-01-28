using Infrastructure.Events;
using Models.Interfaces.Models;
using Models.Interfaces.ViewModels;
using Models.Models;
using Prism.Commands;
using Prism.Events;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using BindableBase = Prism.Mvvm.BindableBase;

namespace Modules.Redactor.ViewModels
{
    public class ElementContainerViewModel : BindableBase
    {
        #region Fields

        private bool _isStackView;

        private bool _isSelectedSlide;
        private ISlide _selectedSlide;

        private IElementViewModel _selectedElement;

        private readonly IEventAggregator _eventAggregator;

        #endregion Fields

        #region Properties

        public ICommand AddTextElementCommand { get; }

        public ICommand AddImageElementCommand { get; }

        public ICommand AddVideoElementCommand { get; }

        public ICommand RemoveElementCommand { get; }

        public IElementViewModel SelectedElement
        {
            get => _selectedElement;
            set => SetProperty(ref _selectedElement, value);
        }

        public bool IsStackView
        {
            get => _isStackView;
            set => SetProperty(ref _isStackView, value);
        }

        public ObservableCollection<IElementViewModel> Elements { get; }

        public bool IsSelectedSlide
        {
            get => _isSelectedSlide;
            set => SetProperty(ref _isSelectedSlide, value);
        }

        public ISlide SelectedSlide
        {
            get => _selectedSlide;
            set => SetProperty(ref _selectedSlide, value, OnSelectedSlideChanged);
        }

        #endregion Properties

        #region Constructor

        public ElementContainerViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            eventAggregator.GetEvent<SelectedSlideEvent>().Subscribe(OnSelectedSlide);

            eventAggregator.GetEvent<AddTextElementEvent>().Subscribe(OnAddText);
            eventAggregator.GetEvent<AddImageElementEvent>().Subscribe(OnAddImage);
            eventAggregator.GetEvent<AddVideoElementEvent>().Subscribe(OnAddVideo);

            Elements = new ObservableCollection<IElementViewModel>();

            AddTextElementCommand = new DelegateCommand(AddText, CanChangeElement).ObservesProperty(() => SelectedSlide);
            AddImageElementCommand = new DelegateCommand(AddImage, CanChangeElement).ObservesProperty(() => SelectedSlide);
            AddVideoElementCommand = new DelegateCommand(AddVideo, CanChangeElement).ObservesProperty(() => SelectedSlide);
            RemoveElementCommand = new DelegateCommand(RemoveElement, CanChangeElement).ObservesProperty(() => SelectedSlide);
        }

        #endregion Constructor

        #region Methods


        private bool CanChangeElement()
        {
            return SelectedSlide != null;

        }


        private void OnSelectedSlideChanged()
        {
            Elements.Clear();

            LoadElements();

            //Add something here later
        }

        private void LoadElements()
        {

            if (SelectedSlide == null)
            {
                return;
            }

            foreach (var element in SelectedSlide.Elements)
            {
                if(element is TextElement)
                    Elements.Add(new TextElementViewModel(element as TextElement));
                else if (element is ImageElement)
                    Elements.Add(new ImageElementViewModel(element as ImageElement));
                else
                    Elements.Add(new VideoElementViewModel(element as VideoElement));
            }

        }

        private void OnSelectedSlide(ISlide slide)
        {
            SelectedSlide = slide;

        }

        private void AddText()
        {
            var text = new TextElement("newText");

            _eventAggregator.GetEvent<AddTextElementEvent>().Publish(text);

        }
        private void OnAddText(IElement element)
        {
            var text = new TextElementViewModel(element as TextElement);
            Elements.Add(text);
            SelectedElement = text;
        }

        private void AddImage()
        {
            var image = new ImageElement("newImage");

            _eventAggregator.GetEvent<AddImageElementEvent>().Publish(image);
        }

        private void OnAddImage(IElement element)
        {
            var image = new ImageElementViewModel(element as ImageElement);
            Elements.Add(image);
            SelectedElement = image;
        }

        private void AddVideo()
        {
            var video = new VideoElement("newVideo");

            _eventAggregator.GetEvent<AddVideoElementEvent>().Publish(video);
        }

        private void OnAddVideo(IElement element)
        {
            var video = new VideoElementViewModel(element as VideoElement);
            Elements.Add(video);
            SelectedElement = video;
        }

        private void RemoveElement()
        {
            _eventAggregator.GetEvent<RemoveElementEvent>().Publish(SelectedElement?.Element);

            Elements.Remove(SelectedElement);
        }

        #endregion Methods
    }
}