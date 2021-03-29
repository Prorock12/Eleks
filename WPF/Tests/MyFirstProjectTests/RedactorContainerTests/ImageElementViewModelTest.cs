
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Models;
using Modules.Redactor.ViewModels;

namespace MyFirstProjectTests.RedactorContainerTests
{
    [TestClass]
    public class ImageElementViewModelTest
    {
        private ImageElementViewModel _element;
        [TestInitialize]
        public void Initialize()
        {
            _element = new ImageElementViewModel();
        }
        [TestMethod]
        public void GetImageElement_WhenInitialized_IsNull()
        {
            //Act
            var actual = _element.ImageElement;

            //Assert
            Assert.IsNull(actual);
        }
        [TestMethod]
        public void SetImageElement_WhenInitialized_IsNotNull()
        {
            //Act
            _element.ImageElement = new ImageElement("some");
            var actual = _element.ImageElement;

            //Assert
            Assert.IsNotNull(actual);
        }
    }
}
