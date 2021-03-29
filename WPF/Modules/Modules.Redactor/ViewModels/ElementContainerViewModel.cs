﻿using Infrastructure.Events;
using Models.Interfaces.Models;
using Models.Models;
using Modules.Library.ViewModels;
using Modules.Redactor.Interfaces;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Services.FilseSelector;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Models.Models.ShapeModels;
using Modules.Redactor.ViewModels.Shapes;

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
        public ICommand AddCircleCommand { get; }
        public ICommand AddEllipseCommand { get; }
        public ICommand AddLineCommand { get;  }
        public ICommand AddRectangleCommand { get; }
        public ICommand AddTriangleCommand { get;  }
        public ICommand AddQuadrateCommand { get; set; }

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

        public ObservableCollection<IElementViewModel> Elements { get; set; }

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

        public ICommand DropCommand { get; }

        #endregion Properties

        #region Constructor

        public ElementContainerViewModel(IEventAggregator eventAggregator, IFileSelector fileSelector) : this()
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

            eventAggregator.GetEvent<AddCircleEvent>().Subscribe(OnAddCircle);
            eventAggregator.GetEvent<AddEllipseEvent>().Subscribe(OnAddEllipse);
            eventAggregator.GetEvent<AddLineEvent>().Subscribe(OnAddLine);
            eventAggregator.GetEvent<AddRectangleEvent>().Subscribe(OnAddRectangle);
            eventAggregator.GetEvent<AddQuadrateEvent>().Subscribe(OnAddQuadrate);
            eventAggregator.GetEvent<AddTriangleEvent>().Subscribe(OnAddTriangle);

            AddTextElementCommand = new DelegateCommand(AddText, CanChangeElement).ObservesProperty(() => SelectedSlide);
            AddImageElementCommand = new DelegateCommand(AddImage, CanChangeElement).ObservesProperty(() => SelectedSlide);
            AddVideoElementCommand = new DelegateCommand(AddVideo, CanChangeElement).ObservesProperty(() => SelectedSlide);
            RemoveElementCommand = new DelegateCommand(RemoveElement, CanChangeElement).ObservesProperty(() => SelectedSlide);

            AddCircleCommand = new DelegateCommand(AddCircle, CanChangeElement).ObservesProperty((() => SelectedSlide));
            AddEllipseCommand = new DelegateCommand(AddEllipse, CanChangeElement).ObservesProperty((() => SelectedSlide));
            AddLineCommand = new DelegateCommand(AddLine, CanChangeElement).ObservesProperty((() => SelectedSlide));
            AddRectangleCommand = new DelegateCommand(AddRectangle, CanChangeElement).ObservesProperty((() => SelectedSlide));
            AddQuadrateCommand = new DelegateCommand(AddQuadrate, CanChangeElement).ObservesProperty((() => SelectedSlide));
            AddTriangleCommand = new DelegateCommand(AddTriangle, CanChangeElement).ObservesProperty((() => SelectedSlide));

            DropCommand = new DelegateCommand<DragEventArgs>(Drop);
        }

        public ElementContainerViewModel()
        {
            Elements = new ObservableCollection<IElementViewModel>();
        }
        #endregion Constructor

        #region Methods

        private void Drop(DragEventArgs e)
        {
            List<object> data = (List<object>)e.Data.GetData(typeof(List<object>));
            if (data == null) return;
            foreach (var item in data)
            {
                var newImageElement = new ImageElement("new Image") { Path = ((LibraryItemViwModel)item)?.Path };
                SelectedSlide.Elements.Add(newImageElement);
                Elements.Add(new ImageElementViewModel(newImageElement));
            }
        }

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
                        break;
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

            SelectedSlide?.Elements.Add(text);
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
            if (image == null) return;
            _eventAggregator.GetEvent<AddImageElementEvent>().Publish(image);
            SelectedSlide?.Elements.Add(image);
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
            SelectedSlide?.Elements.Add(video);
        }

        private void OnAddVideo(IElement element)
        {
            var video = new VideoElementViewModel(element as VideoElement);
            Elements.Add(video);
            SelectedElement = video;
        }
        private void RemoveElement()
        {
            SelectedSlide.Elements.Remove(SelectedElement?.Element);

            _eventAggregator.GetEvent<RemoveElementEvent>().Publish(SelectedElement?.Element);
        }

        private void OnRemoveElement(IElement element)
        {
            if (element == null) return;
            var removeElement = Elements.First(x => x.Element == element);
            Elements.Remove(removeElement);
        }

        #region shapes
        private void AddCircle()
        {
            var circle = new Circle("NewCircle");

            _eventAggregator.GetEvent<AddCircleEvent>().Publish(circle);

            SelectedSlide?.Elements.Add(circle);
        }
        private void OnAddCircle(IElement element)
        {
            var circle = new CircleViewModel(element as Circle);
            Elements.Add(circle);
            SelectedElement = circle;
        }
        private void AddEllipse()
        {
            var ellipse = new Ellipse("NewEllipse");

            _eventAggregator.GetEvent<AddEllipseEvent>().Publish(ellipse);

            SelectedSlide?.Elements.Add(ellipse);
        }
        private void OnAddEllipse(IElement element)
        {
            var ellipse = new EllipseViewModel(element as Ellipse);
            Elements.Add(ellipse);
            SelectedElement = ellipse;
        }
        private void AddRectangle()
        {
            var rectangle = new Rectangle("NewRectangle");

            _eventAggregator.GetEvent<AddRectangleEvent>().Publish(rectangle);

            SelectedSlide?.Elements.Add(rectangle);
        }
        private void OnAddRectangle(IElement element)
        {
            var rectangle = new RectangleViewModel(element as Rectangle);
            Elements.Add(rectangle);
            SelectedElement = rectangle;
        }
        private void AddQuadrate()
        {
            var quadrate = new Quadrate("NewQuadrate");

            _eventAggregator.GetEvent<AddQuadrateEvent>().Publish(quadrate);

            SelectedSlide?.Elements.Add(quadrate);
        }
        private void OnAddQuadrate(IElement element)
        {
            var quadrate = new QuadrateViewModel(element as Quadrate);
            Elements.Add(quadrate);
            SelectedElement = quadrate;
        }
        private void AddTriangle()
        {
            var triangle = new Triangle("NewTriangle");

            _eventAggregator.GetEvent<AddTriangleEvent>().Publish(triangle);

            SelectedSlide?.Elements.Add(triangle);
        }
        private void OnAddTriangle(IElement element)
        {
            var triangle = new TriangleViewModel(element as Triangle);
            Elements.Add(triangle);
            SelectedElement = triangle;
        }
        private void AddLine()
        {
            var line = new Line("NewLine");

            _eventAggregator.GetEvent<AddLineEvent>().Publish(line);

            SelectedSlide?.Elements.Add(line);
        }
        private void OnAddLine(IElement element)
        {
            var line = new LineViewModel(element as Line);
            Elements.Add(line);
            SelectedElement = line;
        }

        #endregion

        #endregion Methods
    }
}