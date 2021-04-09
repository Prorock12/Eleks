using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Models;
using Modules.Controller.ViewModels;
using Moq;

namespace MyFirstProjectTests.ControllerTests
{
    [TestClass]
    public class SlideViewModelTest
    {
        private readonly SlideViewModel _slideView = new SlideViewModel();

        [TestMethod]
        public void GetSlide_SlideViewModelIsCreatedWithoutElement_IsNull()
        {
            //Act
            var actual = _slideView.Slide;

            //Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void SetSlide_WhenNewSlideIsNotNull_IsNotNull()
        {
            //Act
            _slideView.Slide = new Slide(It.IsAny<string>());
            var actual = _slideView.Slide;

            //Assert
            Assert.IsNotNull(actual);
        }
    }
}