using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Infrastructure.Events;
using Models.Models;
using Modules.Que.Interfaces;
using Modules.Que.ViewModels;
using Moq;
using Prism.Events;

namespace MyFirstProjectTests.QueTests
{
    [TestClass]
    public class QueContainerViewModelTest
    {
        private QueContainerViewModel _queContainer;
        //private IEventAggregator _eventAggregator;
        private Mock<IEventAggregator> _mockEventAggregator;
        //private Mock<SelectedPresentationEvent> _mockSelectedPresentation;
        //private Mock<SelectedQueEvent> _mockSelectedQue;
        //private Mock<AddQueEvent> _mockAddQue;
        //private Mock<RemoveQueEvent> _mockRemoveQue;
        //private Mock<SelectedSlideEvent> _mockSelectedSlide;

        [TestInitialize]
        public void Initialize()
        {
            _mockEventAggregator = new Mock<IEventAggregator>();

            //_mockSelectedPresentation = new Mock<SelectedPresentationEvent>();
            //_mockAddQue = new Mock<AddQueEvent>();
            //_mockRemoveQue = new Mock<RemoveQueEvent>();
            //_mockSelectedQue = new Mock<SelectedQueEvent>();
            //_mockSelectedSlide = new Mock<SelectedSlideEvent>();

            _mockEventAggregator.Setup(x => x.GetEvent<SelectedPresentationEvent>())
                .Returns(new SelectedPresentationEvent());
            _mockEventAggregator.Setup(x => x.GetEvent<AddQueEvent>())
                .Returns(new AddQueEvent());
            _mockEventAggregator.Setup(x => x.GetEvent<RemoveQueEvent>())
                .Returns(new RemoveQueEvent());
            _mockEventAggregator.Setup(x => x.GetEvent<SelectedQueEvent>())
                .Returns(new SelectedQueEvent());
            _mockEventAggregator.Setup(x => x.GetEvent<SelectedSlideEvent>())
                .Returns(new SelectedSlideEvent());

            _queContainer = new QueContainerViewModel(_mockEventAggregator.Object)
            {
                SelectedPresentation = new Presentation("some")
            };
        }
        [TestMethod]
        public void GetQuesCollection_WhenPresentationIsSelected_CountIsZero()
        {
            //Arrange
            var expected = 0;

            //Act
            int actual = _queContainer.Ques.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SetQuesCollection_WhenPresentationIsSelected_CountIsOne()
        {
            //Arrange
            int expected = 1;

            //Act
            _queContainer.Ques.Clear();
            _queContainer.Ques.Add(new QueViewModel(new Que("Some"), _mockEventAggregator.Object));
            var actual = _queContainer.Ques.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddQue_WhenPresentationIsSelectedAndQuesCollectionIsNotNull_CountIsOne()
        {
            //Arrange
            var expected = 1;

            //Act
            _queContainer.Ques = new ObservableCollection<IQueViewModel>();
            _queContainer.AddQue();
            var actual = _queContainer.Ques.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddSlide_WhenPresentationIsSelectedAndQuesCollectionIsNotNullAndSlidesCollectionIsNotNull_CountIsOne()
        {
            //Arrange
            var expected = 1;

            //Act
            _queContainer.SelectedQue = new QueViewModel(new Que("some"), _mockEventAggregator.Object);
            _queContainer.AddSlideCommand.Execute(null);
            var actual = _queContainer.SelectedQue.Que.Slides.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveSlide_WhenPresentationIsSelectedAndQuesCollectionIsNotNullAndSlidesCollectionIsNotNull_CountIsZero()
        {
            //Arrange
            var expected = 0;

            //Act
            _queContainer.SelectedQue = new QueViewModel(new Que("some"),_mockEventAggregator.Object);
            _queContainer.SelectedQue.Que.Slides.Add(new Slide("some"));
            _queContainer.SelectedQue.SelectedSlide = _queContainer.SelectedQue.Que.Slides[0];
            _queContainer.RemoveSlideCommand.Execute(null);
            var actual = _queContainer.SelectedQue.Que.Slides.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveQue_WhenPresentationIsSelectedAndQuesCollectionIsNotNull_CountIsZero()
        {
            //Arrange
            var expected = 0;

            //Act
            _queContainer.Ques.Add(new QueViewModel(new Que("some"), _mockEventAggregator.Object));
            _queContainer.SelectedQue = _queContainer.Ques[0];
            _queContainer.RemoveQueCommand.Execute(null);
            var actual = _queContainer.Ques.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
