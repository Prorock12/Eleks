using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Models;
using Modules.PresentationRegion.ViewModels;
using Moq;

namespace MyFirstProjectTests.PresentationTests
{
    [TestClass]
    public class PresentationViewModelTest
    {
        private PresentationViewModel _presentation;

        [TestInitialize]
        public void Initialize()
        {
            _presentation = new PresentationViewModel();
        }

        [TestMethod]
        public void GetPresentation_WhenPresentationViewModelIsNotNull_IsNotNull()
        {
            //Act
            var actual = _presentation.Presentation;

            //Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void SetNewPresentationCorrect_WhenPresentationViewModelIsNotNull_IsNotNull()
        {
            //Act
            _presentation.Presentation = new Presentation(It.IsAny<string>());
            var actual = _presentation.Presentation;

            //Assert
            Assert.IsNotNull(actual);
        }
    }
}