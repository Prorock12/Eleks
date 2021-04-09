using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Models;
using Modules.Que.ViewModels;

namespace MyFirstProjectTests.QueTests
{
    [TestClass]
    public class SlideViewModelTest
    {
        private SlideViewModel _que;

        [TestInitialize]
        public void Initialize()
        {
            _que = new SlideViewModel();
        }

        [TestMethod]
        public void GetSlide_WhenInitialized_IsNull()
        {
            //Act
            var actual = _que.Slide;

            //Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void SetSlide_WhenInitialized_IsNotNull()
        {
            //Act
            _que.Slide = new Slide("some");
            var actual = _que.Slide;

            //Assert
            Assert.IsNotNull(actual);
        }
    }
}