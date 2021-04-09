using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Models;
using Modules.Redactor.ViewModels;

namespace MyFirstProjectTests.RedactorContainerTests
{
    [TestClass]
    public class TextElementViewModelTest
    {
        private TextElementViewModel _element;

        [TestInitialize]
        public void Initialize()
        {
            _element = new TextElementViewModel();
        }

        [TestMethod]
        public void GetVideoElement_WhenInitialized_IsNull()
        {
            //Act
            var actual = _element.TextElement;

            //Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void SetVideoElement_WhenInitialized_IsNotNull()
        {
            //Act
            _element.TextElement = new TextElement("some");
            var actual = _element.TextElement;

            //Assert
            Assert.IsNotNull(actual);
        }
    }
}