using Infrastructure.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Models;
using Modules.PresentationRegion.Interfaces;
using Modules.PresentationRegion.ViewModels;
using Moq;
using Prism.Events;
using System.Collections.ObjectModel;

namespace MyFirstProjectTests.PresentationTests
{
    [TestClass]
    public class PresentationContainerViewModelTest
    {
        private PresentationContainerViewModel _presentation;

        //private IEventAggregator _eventAggregator;
        private Mock<IEventAggregator> _mockEventAggregator;

        //private Mock<SelectedPresentationEvent> _mockEventSelectedPresentation;

        [TestInitialize]
        public void Initialize()
        {
            _mockEventAggregator = new Mock<IEventAggregator>();
            //_eventAggregator = new EventAggregator();
            //_mockEventSelectedPresentation = new Mock<SelectedPresentationEvent>();

            _mockEventAggregator.Setup(x => x.GetEvent<SelectedPresentationEvent>())
                .Returns(new SelectedPresentationEvent());
            _presentation = new PresentationContainerViewModel(_mockEventAggregator.Object);
        }

        //[TestMethod]
        //public void GetPresentationsCollection_WhenProjectStart_IsNotNull()
        //{
        //    //Act
        //    var actual = _presentation.Presentations;

        //    //Assert
        //    Assert.IsNotNull(actual);
        //}
        //[TestMethod]
        //public void SetPresentationsCollection_WhenPresentationAdded_CountIsOne()
        //{
        //    //Arrange
        //    var expected = 1;

        //    //Act
        //    _presentation.Presentations = new ObservableCollection<IPresentationViewModel>();
        //    _presentation.Presentations.Add(new PresentationViewModel(new Presentation(It.IsAny<string>())));
        //    var actual = _presentation.Presentations.Count;

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
        [TestMethod]
        public void GetSelectedPresentation_WhenPresentationCollectionNotNull_IsNull()
        {
            //Act
            _presentation.Presentations = new ObservableCollection<IPresentationViewModel>();
            _presentation.Presentations.Add(new PresentationViewModel(new Presentation(It.IsAny<string>())));
            var actual = _presentation.SelectedPresentation;

            //Assert
            Assert.IsNull(actual);
        }

        //[TestMethod]
        //public void SetSelectedPresentation_WhenPresentationCollectionNotNull_NotNull()
        //{
        //    //Act
        //    _presentation.Presentations = new ObservableCollection<IPresentationViewModel>();
        //    _presentation.Presentations.Add(new PresentationViewModel(new Presentation(It.IsAny<string>())));
        //    _presentation.SelectedPresentation = _presentation.Presentations[0];
        //    var actual = _presentation.SelectedPresentation;

        //    //Assert
        //    Assert.IsNotNull(actual);
        //}
        [TestMethod]
        public void AddPresentation_WhenPresentationCollectionNotNull_CountIsOne()
        {
            //Arrange
            var expected = 1;

            //Act
            _presentation.Presentations = new ObservableCollection<IPresentationViewModel>();
            _presentation.AddPresentationCommand.Execute(null);
            var actual = _presentation.Presentations.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemovePresentation_WhenPresentationCollectionNotNull_CountIsNull()
        {
            //Arrange
            var expected = 0;

            //Act
            _presentation.Presentations = new ObservableCollection<IPresentationViewModel>();
            _presentation.Presentations.Add(new PresentationViewModel(new Presentation(It.IsAny<string>())));
            _presentation.SelectedPresentation = _presentation.Presentations[0];
            _presentation.RemovePresentationCommand.Execute(null);
            var actual = _presentation.Presentations.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}