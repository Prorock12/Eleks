using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Models;
using Modules.Redactor.ViewModels;

namespace MyFirstProjectTests.RedactorContainerTests
{
    [TestClass]
    public class ElementViewModelTest
    {
        private ElementViewModel _element;

        [TestInitialize]
        public void Initialize()
        {
            _element = new ImageElementViewModel();
        }

        [TestMethod]
        public void GetElement_WhenInitialized_IsNull()
        {
            //Act
            var actual = _element.Element;

            //Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void SetElement_WhenInitialized_IsNotNull()
        {
            //Act
            _element.Element = new ImageElement("some");
            var actual = _element.Element;

            //Assert
            Assert.IsNotNull(actual);
        }
    }
}