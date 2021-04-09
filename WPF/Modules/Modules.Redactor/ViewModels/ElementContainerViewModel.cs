using Infrastructure.Events;
using Models.Interfaces.Models;
using Models.Interfaces.ShapeModels;
using Models.Models;
using Models.Models.ShapeModels;
using Modules.Library.ViewModels;
using Modules.Redactor.Interfaces;
using Modules.Redactor.ViewModels.Shapes;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Services.FilseSelector;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
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
        public ICommand AddCircleCommand { get; }
        public ICommand AddEllipseCommand { get; }
        public ICommand AddLineCommand { get; }
        public ICommand AddRectangleCommand { get; }
        public ICommand AddTriangleCommand { get; }
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

            eventAggregator.GetEvent<AddElementEvent>().Subscribe(OnAddElement);
            eventAggregator.GetEvent<AddQuadrateEvent>().Subscribe(OnAddQuadrate);
            eventAggregator.GetEvent<RemoveElementEvent>().Subscribe(OnRemoveElement);

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

                    case ICircle circle:
                        Elements.Add(new CircleViewModel(circle));
                        break;

                    case IEllipse ellipse:
                        Elements.Add(new EllipseViewModel(ellipse));
                        break;

                    case IRectangle rectangle:
                        Elements.Add(new RectangleViewModel(rectangle));
                        break;
                    //case IQuadrate quadrate:
                    //    Elements.Add(new VideoElementViewModel(quadrate));
                    //    break;
                    case ILine line:
                        Elements.Add(new LineViewModel(line));
                        break;

                    case ITriangle triangle:
                        Elements.Add(new TriangleViewModel(triangle));
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

            //_eventAggregator.GetEvent<AddTextElementEvent>().Publish(text);
            _eventAggregator.GetEvent<AddElementEvent>().Publish(text);

            SelectedSlide?.Elements.Add(text);
        }

        public void OnAddElement(IElement element)
        {
            IElementViewModel elementViewModel;
            switch (element)
            {
                case ITextElement textElement:
                    elementViewModel = new TextElementViewModel(textElement);
                    break;

                case IImageElement imageElement:
                    elementViewModel = new ImageElementViewModel(imageElement);
                    break;

                case IVideoElement videoElement:
                    elementViewModel = new VideoElementViewModel(videoElement);
                    break;

                case ICircle circle:
                    elementViewModel = new CircleViewModel(circle);
                    break;

                case IEllipse ellipse:
                    elementViewModel = new EllipseViewModel(ellipse);
                    break;

                case IRectangle rectangle:
                    elementViewModel = new RectangleViewModel(rectangle);
                    break;
                //case IQuadrate quadrate:
                //    elementViewModel = new QuadrateViewModel(quadrate);
                //    break;
                case ITriangle triangle:
                    elementViewModel = new TriangleViewModel(triangle);
                    break;

                case ILine line:
                    elementViewModel = new LineViewModel(line);
                    break;

                default:
                    elementViewModel = null;
                    break;
            }
            Elements.Add(elementViewModel);
            SelectedElement = elementViewModel;
        }

        private void AddImage()
        {
            var image = _fileSelector.ChooseImage();
            if (image == null) return;

            //_eventAggregator.GetEvent<AddImageElementEvent>().Publish(image);
            _eventAggregator.GetEvent<AddElementEvent>().Publish(image);

            SelectedSlide?.Elements.Add(image);
        }

        private void AddVideo()
        {
            var video = _fileSelector.ChooseVideo();
            if (video == null) return;

            _eventAggregator.GetEvent<AddElementEvent>().Publish(video);
            SelectedSlide?.Elements.Add(video);
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

            _eventAggregator.GetEvent<AddElementEvent>().Publish(circle);

            SelectedSlide?.Elements.Add(circle);
        }

        private void AddEllipse()
        {
            var ellipse = new Ellipse("NewEllipse");

            _eventAggregator.GetEvent<AddElementEvent>().Publish(ellipse);

            SelectedSlide?.Elements.Add(ellipse);
        }

        private void AddRectangle()
        {
            var rectangle = new Rectangle("NewRectangle");

            _eventAggregator.GetEvent<AddElementEvent>().Publish(rectangle);

            SelectedSlide?.Elements.Add(rectangle);
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

            _eventAggregator.GetEvent<AddElementEvent>().Publish(triangle);

            SelectedSlide?.Elements.Add(triangle);
        }

        private void AddLine()
        {
            var line = new Line("NewLine");

            _eventAggregator.GetEvent<AddElementEvent>().Publish(line);

            SelectedSlide?.Elements.Add(line);
        }

        #endregion shapes

        #endregion Methods
    }
}