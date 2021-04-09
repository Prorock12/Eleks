using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Models;
using Modules.Redactor.ViewModels;

namespace MyFirstProjectTests.RedactorContainerTests
{
    [TestClass]
    public class VideoElementViewModelTest
    {
        private VideoElementViewModel _element;

        [TestInitialize]
        public void Initialize()
        {
            _element = new VideoElementViewModel();
        }

        [TestMethod]
        public void GetVideoElement_WhenInitialized_IsNull()
        {
            //Act
            var actual = _element.VideoElement;

            //Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void SetVideoElement_WhenInitialized_IsNotNull()
        {
            //Act
            _element.VideoElement = new VideoElement("some");
            var actual = _element.VideoElement;

            //Assert
            Assert.IsNotNull(actual);
        }
    }
}