
using Infrastructure.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Models;
using Modules.Que.ViewModels;
using Moq;
using Prism.Events;

namespace MyFirstProjectTests.QueTests
{
    [TestClass]
    public class QueViewModelTest
    {
        private QueViewModel _que;
        //private IEventAggregator _eventAggregator;
        private Mock<IEventAggregator> _mockEventAggregator;

        [TestInitialize]
        public void Initialize()
        {
            _mockEventAggregator = new Mock<IEventAggregator>();
            _mockEventAggregator.Setup(x => x.GetEvent<SelectedSlideEvent>()).Returns(new SelectedSlideEvent());
            //_eventAggregator = new EventAggregator();
            _que = new QueViewModel(_mockEventAggregator.Object);
            //_que.SelectedSlide = new Slide("slide");
        }
        [TestMethod]
        public void GetQue_WhenInitialized_IsNull()
        {
            //Act
            var actual = _que.Que;

            //Assert
            Assert.IsNull(actual);
        }
        [TestMethod]
        public void SetQue_WhenInitialized_IsNotNull()
        {
            //Act
            _que.Que = new Que("some"); ;
            var actual = _que.Que;

            //Assert
            Assert.IsNotNull(actual);
        }
        [TestMethod]
        public void GetSelectedSlide_WhenInitialized_IsNull()
        {
            //Act
            var actual = _que.SelectedSlide;

            //Assert
            Assert.IsNull(actual);
        }
        [TestMethod]
        public void SetSelectedSlide_WhenInitialized_IsNotNull()
        {
            //Act
            _que.SelectedSlide = new Slide("some"); ;
            var actual = _que.SelectedSlide;

            //Assert
            Assert.IsNotNull(actual);
        }
        [TestMethod]
        public void GetIsSelectedSlide_WhenInitialized_False()
        {
            //Act
            var actual = _que.IsSelected;

            //Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void SetIsSelectedSlide_WhenInitialized_True()
        {
            //Act
            _que.IsSelected = true;
            var actual = _que.IsSelected;

            //Assert
            Assert.IsTrue(actual);
        }
    }
}
