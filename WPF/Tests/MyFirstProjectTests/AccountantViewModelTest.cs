﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using Models.Interfaces.Models;
using Models.Models;
using Modules.Accountant.ViewModels;
using Modules.PresentationRegion.ViewModels;
using Moq;
using Service.DispatcherAction;

namespace MyFirstProjectTests
{
    [TestClass]
    public class AccountantViewModelTest
    {
        private AccountantViewModel _accountant;
        private IDispatcherAction _dispatcherAction;

        [TestInitialize]
        public void Initialize()
        {
            _dispatcherAction = new DispatcherAction();
            _accountant = new AccountantViewModel(_dispatcherAction);
        }
        //[TestMethod]
        //public void GetElementsCollection_WhenAccountantViewModelInitialized_CountIsZero()
        //{
        //    //Arrange
        //    int expected = 0;

        //    //Act
        //    int actual = _accountant.Elements.Count;

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void SetElementsCollection_SetNewElementsCollection_CountIsOne()
        //{
        //    //Arrange
        //    int expected = 1;

        //    //Act
        //    var elements = new ObservableCollection<IVisualElement> {new ImageElement("some")};
        //    _accountant.Elements = elements;
        //    var actual = _accountant.Elements.Count;

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void SetSelectedElement_WhenAccountantViewModelInitialized_IsNotNull()
        //{
        //    //Act
        //    _accountant.SelectedElement = new VideoElement("video");
        //    var actual = _accountant.SelectedElement;

        //    //Assert
        //    Assert.IsNotNull(actual);
        //}
        [TestMethod]
        public void GetSelectedElement_WhenAccountantViewModelInitialized_IsNull()
        {
            //Act
            var actual = _accountant.SelectedElement;

            //Assert
            Assert.IsNull(actual);
        }
        [TestMethod]
        public void CreateElement_WhenAccountantViewModelInitialized_IsNotNull()
        { 
            //Act
            var actual = _accountant.CreateElement();

            //Assert
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void AddRowCorrect_WhenElementsCollectionIsNotNull_CountIsOne()
        {
            //Arrange
            var expected = 1;

            //Act
            _accountant.Elements = new ObservableCollection<IVisualElement>();
            _accountant.AddRow();
            var actual = _accountant.Elements.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveRowCorrect_WhenElementsCollectionIsNotNullAndHasOneElement_CountIsZero()
        {
            //Arrange
            var expected = 0;

            //Act
            _accountant.Elements = new ObservableCollection<IVisualElement>(){new ImageElement("some")};
            _accountant.SelectedElement = _accountant.Elements[0];
            _accountant.RemoveRow();
            var actual = _accountant.Elements.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}