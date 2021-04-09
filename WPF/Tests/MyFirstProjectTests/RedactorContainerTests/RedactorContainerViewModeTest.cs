using Infrastructure.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Models;
using Modules.Redactor.Interfaces;
using Modules.Redactor.ViewModels;
using Moq;
using Prism.Events;
using Services.FilseSelector;
using System.Collections.ObjectModel;

namespace MyFirstProjectTests.RedactorContainerTests
{
    [TestClass]
    public class RedactorContainerViewModeTest
    {
        private IEventAggregator _eventAggregator;
        private IFileSelector _fileSelector;
        private ElementContainerViewModel _element;
        private Mock<IEventAggregator> _mockEventAggregator;
        private Mock<IFileSelector> _mockFileSelector;
        //private Mock<SelectedPresentationEvent> _mockSelectedPresenation;
        //private Mock<SelectedSlideEvent> _mockSelectedSlide;
        //private Mock<SelectedElementEvent> _mockSelectedElement;
        //private Mock<ChangeResolutionSizeEvent> _mockChangeResolution;
        //private Mock<AddTextElementEvent> _mockAddText;
        //private Mock<AddImageElementEvent> _mockAddImage;
        //private Mock<AddVideoElementEvent> _mockAddVideo;
        //private Mock<RemoveElementEvent> _mockRemoveElement;
        //private Mock<AddCircleEvent> _mockAddCircle;
        //private Mock<AddEllipseEvent> _mockAddEllipse;
        //private Mock<AddLineEvent> _mockAddLine;
        //private Mock<AddRectangleEvent> _mockAddRectangle;
        //private Mock<AddQuadrateEvent> _mockAddQuadrate;
        //private Mock<AddTriangleEvent> _mockAddTriangle;

        [TestInitialize]
        public void Initialize()
        {
            //_mockSelectedPresenation = new Mock<SelectedPresentationEvent>();
            //_mockSelectedSlide = new Mock<SelectedSlideEvent>();
            //_mockSelectedElement = new Mock<SelectedElementEvent>();
            //_mockChangeResolution = new Mock<ChangeResolutionSizeEvent>();
            //_mockAddText = new Mock<AddTextElementEvent>();
            //_mockAddImage = new Mock<AddImageElementEvent>();
            //_mockAddVideo = new Mock<AddVideoElementEvent>();
            //_mockRemoveElement = new Mock<RemoveElementEvent>();
            //_mockAddCircle = new Mock<AddCircleEvent>();
            //_mockAddEllipse = new Mock<AddEllipseEvent>();
            //_mockAddLine = new Mock<AddLineEvent>();
            //_mockAddRectangle = new Mock<AddRectangleEvent>();
            //_mockAddQuadrate = new Mock<AddQuadrateEvent>();
            //_mockAddTriangle = new Mock<AddTriangleEvent>();

            _mockEventAggregator = new Mock<IEventAggregator>();
            _mockFileSelector = new Mock<IFileSelector>();

            _mockEventAggregator.Setup(x => x.GetEvent<SelectedPresentationEvent>()).Returns(new SelectedPresentationEvent());
            _mockEventAggregator.Setup(x => x.GetEvent<SelectedSlideEvent>()).Returns(new SelectedSlideEvent());
            _mockEventAggregator.Setup(x => x.GetEvent<SelectedElementEvent>()).Returns(new SelectedElementEvent());
            _mockEventAggregator.Setup(x => x.GetEvent<ChangeResolutionSizeEvent>()).Returns(new ChangeResolutionSizeEvent());
            _mockEventAggregator.Setup(x => x.GetEvent<AddElementEvent>()).Returns(new AddElementEvent());
            _mockEventAggregator.Setup(x => x.GetEvent<AddQuadrateEvent>()).Returns(new AddQuadrateEvent());
            _mockEventAggregator.Setup(x => x.GetEvent<RemoveElementEvent>()).Returns(new RemoveElementEvent());
            //_eventAggregator = _mockEventAggregator.Object;
            //_fileSelector = _mockFileSelector.Object;
            _fileSelector = new FileSelector();
            //_eventAggregator = new EventAggregator();
            _element = new ElementContainerViewModel(_mockEventAggregator.Object, _fileSelector);
        }

        //[TestMethod]
        //public void GetElementsCollection_WhenElementContainerViewModelIsCreated_IsNotNull()
        //{
        //    //Act
        //    var actual = _element.Elements;

        //    //Assert
        //    Assert.IsNotNull(actual);
        //}
        //[TestMethod]
        //public void SetNewElements_WhenElementContainerViewModelIsCreated_CountIsOneAfterAdded()
        //{
        //    //Arrange
        //    var expected = 1;

        //    //Act
        //    _element.Elements = new ObservableCollection<IElementViewModel>(){new ImageElementViewModel(new ImageElement("some"))};
        //    var actual = _element.Elements.Count;

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
        [TestMethod]
        public void GetSelectedElement_WhenSlideIsSelected_Null()
        {
            //Act
            _element.SelectedSlide = new Slide("slide");
            var actual = _element.SelectedElement;

            //Assert
            Assert.IsNull(actual);
        }

        //[TestMethod]
        //public void SetSelectedElement_WhenSlideIsSelected_IsNotNull()
        //{
        //    //Act
        //    _element.SelectedSlide = new Slide("some");
        //    _element.SelectedElement = new ImageElementViewModel(new ImageElement("some"));
        //    var actual = _element.SelectedElement;

        //    //Assert
        //    Assert.IsNotNull(actual);
        //}
        [TestMethod]
        public void GetSelectedSlide_WhenInitialized_Null()
        {
            //Act
            var actual = _element.SelectedSlide;

            //Assert
            Assert.IsNull(actual);
        }

        //[TestMethod]
        //public void SetSelectedSlide_WhenElementContainerViewModelIsCreated_IsNotNull()
        //{
        //    //Act
        //    _element.SelectedSlide = new Slide("some");
        //    var actual = _element.SelectedSlide;

        //    //Assert
        //    Assert.IsNotNull(actual);
        //}
        [TestMethod]
        public void GetSelectedPresentation_WhenInitialized_Null()
        {
            //Act
            var actual = _element.SelectedPresentation;

            //Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void SetSelectedPresentation_WhenInitialized_NotNull()
        {
            //Act
            _element.SelectedPresentation = new Presentation("some");
            var actual = _element.SelectedPresentation;

            //Assert
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void AddText_WhenSelectedSlideIsNotNull_AddedTextCountOne()
        {
            //Arrange
            var expected = 1;

            //Act
            _element.Elements = new ObservableCollection<IElementViewModel>();
            _element.AddTextElementCommand.Execute(null);
            var actual = _element.Elements.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddImage_WhenSelectedSlideIsNotNull_AddedImageCountOne()
        {
            //Arrange
            var expected = 1;

            //Act
            _element.Elements = new ObservableCollection<IElementViewModel>();
            _element.AddImageElementCommand.Execute(null);
            var actual = _element.Elements.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddVideo_WhenSelectedSlideIsNotNull_AddedVideoCountOne()
        {
            //Arrange
            var expected = 1;

            //Act
            _element.Elements = new ObservableCollection<IElementViewModel>();
            _element.AddVideoElementCommand.Execute(null);
            var actual = _element.Elements.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveElement_WhenElementsCollectionInitializedAndNotNull_CountZero()
        {
            //Arrange
            var expected = 0;

            //Act
            _element.SelectedSlide = new Slide("some");
            _element.Elements.Add(new ImageElementViewModel(new ImageElement("some")));
            _element.SelectedElement = _element.Elements[0];
            _element.RemoveElementCommand.Execute(null);
            var actual = _element.Elements.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddCircle_WhenSelectedSlideNotNull_AddedCircleCountOne()
        {
            //Arrange
            var expected = 1;

            //Act
            _element.Elements = new ObservableCollection<IElementViewModel>();
            _element.AddCircleCommand.Execute(null);
            var actual = _element.Elements.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddEllipse_WhenSelectedSlideNotNull_AddedEllipseCountOne()
        {
            //Arrange
            var expected = 1;

            //Act
            _element.Elements = new ObservableCollection<IElementViewModel>();
            _element.AddEllipseCommand.Execute(null);
            var actual = _element.Elements.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddRectangle_WhenSelectedSlideNotNull_AddedRectangleCountOne()
        {
            //Arrange
            var expected = 1;

            //Act
            _element.Elements = new ObservableCollection<IElementViewModel>();
            _element.AddRectangleCommand.Execute(null);
            var actual = _element.Elements.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddQuadrate_WhenSelectedSlideNotNull_AddedQuadrateCountOne()
        {
            //Arrange
            var expected = 1;

            //Act
            _element.Elements = new ObservableCollection<IElementViewModel>();
            _element.AddQuadrateCommand.Execute(null);
            var actual = _element.Elements.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTriangle_WhenSelectedSlideNotNull_AddedTriangleCountOne()
        {
            //Arrange
            var expected = 1;

            //Act
            _element.Elements = new ObservableCollection<IElementViewModel>();
            _element.AddTriangleCommand.Execute(null);
            var actual = _element.Elements.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddLine_WhenSelectedSlideIsNotNull_AddedLineCountOne()
        {
            //Arrange
            var expected = 1;

            //Act
            _element.Elements = new ObservableCollection<IElementViewModel>();
            _element.AddLineCommand.Execute(null);
            var actual = _element.Elements.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}