using Infrastructure.Events;
using Models.Interfaces.Models;
using Models.Models;
using Modules.Redactor.Interfaces;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Services.FilseSelector;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using System.Windows.Media;

namespace Modules.Redactor.ViewModels
{
    public class ElementContainerViewModel : BindableBase
    {
        #region Fields

        public TranslateTransform X { get; set; }

        private bool _isStackView;

        private ISlide _selectedSlide;

        private IPresentation _selectedPresentation;

        private IElementViewModel _selectedElement;

        private readonly IEventAggregator _eventAggregator;

        private readonly IFileSelector _fileSelector;

        #endregion Fields

        #region Properties

        public ICommand AddTextElementCommand { get; }

        public ICommand AddImageElementCommand { get; }

        public ICommand AddVideoElementCommand { get; }

        public ICommand RemoveElementCommand { get; }

        public IElementViewModel SelectedElement
        {
            get => _selectedElement;
            set => SetProperty(ref _selectedElement, value, OnSelectedElementChanged);
        }

        public bool IsStackView
        {
            get => _isStackView;
            set => SetProperty(ref _isStackView, value);
        }

        public ObservableCollection<IElementViewModel> Elements { get; }

        public ISlide SelectedSlide
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

        public ElementContainerViewModel(IEventAggregator eventAggregator, IFileSelector fileSelector)
        {
            _eventAggregator = eventAggregator;
            _fileSelector = fileSelector;

            eventAggregator.GetEvent<SelectedPresentationEvent>().Subscribe(OnSelectedPresentation);
            eventAggregator.GetEvent<SelectedSlideEvent>().Subscribe(OnSelectedSlide);

            eventAggregator.GetEvent<ChangeResolutionSizeEvent>().Subscribe(ChangeResolutionSize);

            eventAggregator.GetEvent<AddTextElementEvent>().Subscribe(OnAddText);
            eventAggregator.GetEvent<AddImageElementEvent>().Subscribe(OnAddImage);
            eventAggregator.GetEvent<AddVideoElementEvent>().Subscribe(OnAddVideo);
            eventAggregator.GetEvent<RemoveElementEvent>().Subscribe(OnRemoveElement);

            Elements = new ObservableCollection<IElementViewModel>();

            AddTextElementCommand = new DelegateCommand(AddText, CanChangeElement).ObservesProperty(() => SelectedSlide);
            AddImageElementCommand = new DelegateCommand(AddImage, CanChangeElement).ObservesProperty(() => SelectedSlide);
            AddVideoElementCommand = new DelegateCommand(AddVideo, CanChangeElement).ObservesProperty(() => SelectedSlide);
            RemoveElementCommand = new DelegateCommand(RemoveElement, CanChangeElement).ObservesProperty(() => SelectedSlide);
        }

        #endregion Constructor

        #region Methods

        private void ChangeResolutionSize(IResolution result)
        {
            if (SelectedPresentation != null)
            {
                SelectedPresentation.Resolution = result;
            }
        }

        private bool CanChangeElement()
        {
            return SelectedSlide != null;
        }

        private void OnSelectedSlideChanged()
        {
            Elements.Clear();

            LoadElements();
        }

        private void OnSelectedPresentationChanged()
        {
            Elements.Clear();
        }

        private void OnSelectedElementChanged()
        {
            _eventAggregator.GetEvent<SelectedElementEvent>().Publish(SelectedElement?.Element);
        }

        private void LoadElements()
        {
            if (SelectedSlide == null)
            {
                return;
            }

            foreach (var element in SelectedSlide.Elements)
            {
                switch (element)
                {
                    case ITextElement textElement:
                        Elements.Add(new TextElementViewModel(textElement));
                        break;

                    case IImageElement imageElement:
                        Elements.Add(new ImageElementViewModel(imageElement));
                        break;

                    case IVideoElement videoElement:
                        Elements.Add(new VideoElementViewModel(videoElement));
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(nameof(element));
                }
            }
        }

        private void OnSelectedSlide(ISlide slide)
        {
            SelectedSlide = slide;
        }

        private void OnSelectedPresentation(IPresentation presentation)
        {
            SelectedPresentation = presentation;
        }

        private void AddText()
        {
            var text = new TextElement("newText");

            _eventAggregator.GetEvent<AddTextElementEvent>().Publish(text);

            SelectedSlide.Elements.Add(text);
        }

        private void OnAddText(IElement element)
        {
            var text = new TextElementViewModel(element as TextElement);
            Elements.Add(text);
            SelectedElement = text;
        }

        private void AddImage()
        {
            var image = _fileSelector.ChooseImage();
            if(image==null) return;
            _eventAggregator.GetEvent<AddImageElementEvent>().Publish(image);
            SelectedSlide.Elements.Add(image);
        }

        private void OnAddImage(IElement element)
        {
            var image = new ImageElementViewModel(element as ImageElement);
            Elements.Add(image);
            SelectedElement = image;
        }

        private void AddVideo()
        {
            var video = _fileSelector.ChooseVideo();
            if (video == null) return;
            _eventAggregator.GetEvent<AddVideoElementEvent>().Publish(video);
            SelectedSlide.Elements.Add(video);
        }

        private void OnAddVideo(IElement element)
        {
            var video = new VideoElementViewModel(element as VideoElement);
            Elements.Add(video);
            SelectedElement = video;
        }

        private void RemoveElement()
        {
            SelectedSlide.Elements.Remove(SelectedElement.Element);

            _eventAggregator.GetEvent<RemoveElementEvent>().Publish(SelectedElement?.Element);
        }

        private void OnRemoveElement(IElement element)
        {
            var removeElement = Elements.First(x => x.Element == element);
            Elements.Remove(removeElement);
        }

        #endregion Methods
    }
}