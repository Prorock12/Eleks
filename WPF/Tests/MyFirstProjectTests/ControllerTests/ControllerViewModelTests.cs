﻿using System;
using System.CodeDom;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;
using Infrastructure.Events;
using Models.Interfaces.Models;
using Models.Models;
using Modules.Controller.ViewModels;
using Moq;
using Prism.Events;
using Services.FilseSelector;
using SlideViewModel = Modules.Controller.ViewModels.SlideViewModel;

namespace MyFirstProjectTests.ControllerTests
{
    [TestClass]
    public class ControllerViewModelTests
    {
        private IEventAggregator _eventAggregator;
        private IFileSelector _fileSelector;
        private ControllerViewModel _controller;
        private Mock<IEventAggregator> _mockEventAggregator;
        private Mock<IFileSelector> _mockFileSelector;
        private Mock<AddVideoElementEvent> _mockEventAddVideo;
        private Mock<AddTextElementEvent> _mockEventAddText;
        private Mock<AddImageElementEvent> _mockEventAddImage;
        private Mock<AddSlideEvent> _mockAddSlide;

        [TestInitialize]
        public void Initialize()
        {
            _mockEventAggregator = new Mock<IEventAggregator>();
            _mockFileSelector = new Mock<IFileSelector>();
            _fileSelector = new FileSelector();
            _mockFileSelector.Setup(x => x.ChooseVideo()).Returns(_fileSelector.ChooseVideo);
            _mockFileSelector.Setup(x => x.ChooseImage()).Returns(_fileSelector.ChooseImage);
            _mockEventAddText = new Mock<AddTextElementEvent>();
            _mockEventAddImage = new Mock<AddImageElementEvent>();
            //_mockAddSlide = new Mock<AddSlideEvent>();
            //_mockAddSlide.Setup(x => x.Subscribe(It.IsAny<Action<ISlide>>()));


            _mockEventAggregator.Setup(m => m.GetEvent<SelectedQueEvent>()).Returns(new SelectedQueEvent());
            _mockEventAggregator.Setup(m => m.GetEvent<SelectedSlideEvent>()).Returns(new SelectedSlideEvent());
            _mockEventAggregator.Setup(m => m.GetEvent<AddSlideEvent>()).Returns(new AddSlideEvent());
            _mockEventAggregator.Setup(m => m.GetEvent<RemoveSlideEvent>()).Returns(new RemoveSlideEvent());
            _mockEventAggregator.Setup(m => m.GetEvent<AddVideoElementEvent>()).Returns(new AddVideoElementEvent());
            _mockEventAggregator.Setup(m => m.GetEvent<AddTextElementEvent>()).Returns(new AddTextElementEvent());
            _mockEventAggregator.Setup(m => m.GetEvent<AddImageElementEvent>()).Returns(new AddImageElementEvent());

            _controller = new ControllerViewModel(_mockEventAggregator.Object, _mockFileSelector.Object);
        }


        [TestMethod]
        public void AddVideoEvent_ElementCollectionIsInitialize_ExpectedPublishEventOnce()
        {
            var mockEventAggregator = new Mock<IEventAggregator>();
            _mockEventAddVideo = new Mock<AddVideoElementEvent>();
            _fileSelector = new FileSelector();

            mockEventAggregator.Setup(m => m.GetEvent<SelectedQueEvent>()).Returns(new SelectedQueEvent());
            mockEventAggregator.Setup(m => m.GetEvent<SelectedSlideEvent>()).Returns(new SelectedSlideEvent());
            mockEventAggregator.Setup(m => m.GetEvent<AddSlideEvent>()).Returns(new AddSlideEvent());
            mockEventAggregator.Setup(m => m.GetEvent<RemoveSlideEvent>()).Returns(new RemoveSlideEvent());
            mockEventAggregator.Setup(m => m.GetEvent<AddVideoElementEvent>()).Returns(_mockEventAddVideo.Object);
            //mockEventAggregator.Setup(m => m.GetEvent<AddTextElementEvent>()).Returns(new AddTextElementEvent());
            //mockEventAggregator.Setup(m => m.GetEvent<AddImageElementEvent>()).Returns(new AddImageElementEvent());

            var controller = new ControllerViewModel(mockEventAggregator.Object,_mockFileSelector.Object);
            //Act
            controller.AddVideoCommand.Execute(null);

            //Assert
            _mockEventAddVideo.Verify(m => m.Publish(It.IsAny<IElement>()), Times.Once);
        }
        [TestMethod]
        public void AddText_ElementCollectionIsInitialize_ExpectedPublishEventOnce()
        {
            var mockEventAggregator = new Mock<IEventAggregator>();
            _mockEventAddVideo = new Mock<AddVideoElementEvent>();
            _fileSelector = new FileSelector();

            mockEventAggregator.Setup(m => m.GetEvent<SelectedQueEvent>()).Returns(new SelectedQueEvent());
            mockEventAggregator.Setup(m => m.GetEvent<SelectedSlideEvent>()).Returns(new SelectedSlideEvent());
            mockEventAggregator.Setup(m => m.GetEvent<AddSlideEvent>()).Returns(new AddSlideEvent());
            mockEventAggregator.Setup(m => m.GetEvent<RemoveSlideEvent>()).Returns(new RemoveSlideEvent());
            mockEventAggregator.Setup(m => m.GetEvent<AddTextElementEvent>()).Returns(_mockEventAddText.Object);
            //mockEventAggregator.Setup(m => m.GetEvent<AddTextElementEvent>()).Returns(new AddTextElementEvent());
            //mockEventAggregator.Setup(m => m.GetEvent<AddImageElementEvent>()).Returns(new AddImageElementEvent());

            var controller = new ControllerViewModel(mockEventAggregator.Object, _mockFileSelector.Object);
            //Act
            controller.AddTextCommand.Execute(null);

            //Assert
            _mockEventAddText.Verify(m => m.Publish(It.IsAny<IElement>()), Times.Once);
        }
        [TestMethod]
        public void AddImage_ElementCollectionIsInitialize_ExpectedPublishEventOnceAndAddedImage()
        {
            var mockEventAggregator = new Mock<IEventAggregator>();
            _mockEventAddVideo = new Mock<AddVideoElementEvent>();
            _fileSelector = new FileSelector();

            mockEventAggregator.Setup(m => m.GetEvent<SelectedQueEvent>()).Returns(new SelectedQueEvent());
            mockEventAggregator.Setup(m => m.GetEvent<SelectedSlideEvent>()).Returns(new SelectedSlideEvent());
            mockEventAggregator.Setup(m => m.GetEvent<AddSlideEvent>()).Returns(new AddSlideEvent());
            mockEventAggregator.Setup(m => m.GetEvent<RemoveSlideEvent>()).Returns(new RemoveSlideEvent());
            mockEventAggregator.Setup(m => m.GetEvent<AddImageElementEvent>()).Returns(_mockEventAddImage.Object);
            //mockEventAggregator.Setup(m => m.GetEvent<AddTextElementEvent>()).Returns(new AddTextElementEvent());
            //mockEventAggregator.Setup(m => m.GetEvent<AddImageElementEvent>()).Returns(new AddImageElementEvent());

            var controller = new ControllerViewModel(mockEventAggregator.Object, _mockFileSelector.Object);
            //Act
            controller.AddImageCommand.Execute(null);

            //Assert
            _mockEventAddImage.Verify(m => m.Publish(It.IsAny<IElement>()), Times.Once);
        }
        [TestMethod]
        public void GetSelectedQue_AfterInitialization_IsNull()
        {
            //Act
            var actual = _controller.SelectedQue;

            //Assert
            Assert.IsNull(actual);
        }
        //[TestMethod]
        //public void GetSelectedSlide_WhenQueIsSelected_IsNull()
        //{
        //    //Act
        //    var actual = _controller.SelectedSlide;

        //    //Assert
        //    Assert.IsNull(actual);
        //}
        //[TestMethod]
        //public void SetSelectedSlide_WhenChooseNewSlide_IsNotNull()
        //{
        //    //Act
        //    _controller.SelectedSlide = new Slide("some");
        //    var actual = _controller.SelectedSlide;

        //    //Assert
        //    Assert.IsNotNull(actual);
        //}
        [TestMethod]
        public void AddSlide_WhenCountSlidesCollectionZero_SlideAddedCountIsOne()
        {
            //Arrange
            var expected = 1;

            //Act
            _controller.SelectedQue = new Que(It.IsAny<string>());
            _controller.AddSlideCommand.Execute(null);
            var actual = _controller.Slides.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddText_WhenCountElementsCollectionIsZero_TextAdded()
        {
            //Arrange
            var expected = 1;

            //Act
            _controller.SelectedSlide = new Slide(It.IsAny<string>());
            _controller.SelectedSlide.Elements = new ObservableCollection<IElement>();
            _controller.AddTextCommand.Execute(null);
            var actual = _controller.SelectedSlide.Elements.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddImage_WhenCountElementsCollectionIsZero_ImageAdded()
        {
            //Arrange
            var expected = 1;

            //Act
            _controller.SelectedSlide = new Slide(It.IsAny<string>());
            _controller.SelectedSlide.Elements = new ObservableCollection<IElement>();
            _controller.AddImageCommand.Execute(null);
            var actual = _controller.SelectedSlide.Elements.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddVideo_WhenCountElementsCollectionIsZero_VideoAdded()
        {
            //Arrange
            var expected = 1;

            //Act
            _controller.SelectedSlide = new Slide(It.IsAny<string>());
            _controller.SelectedSlide.Elements = new ObservableCollection<IElement>();
            _controller.AddVideoCommand.Execute(null);
            var actual = _controller.SelectedSlide.Elements.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}