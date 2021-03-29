using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Models.Models;
using Modules.PresentationRegion.Interfaces;
using Modules.PresentationRegion.ViewModels;
using Services.FilseSelector;

namespace MyFirstProjectTests
{
    [TestClass]
    public class FolderSelectorTest
    {
        private readonly FileSelector _fileSelector = new FileSelector();
        private readonly Modules.PresentationRegion.ViewModels.PresentationContainerViewModel _presentation = new Modules.PresentationRegion.ViewModels.PresentationContainerViewModel();

            [TestMethod]
        public void ChooseImage_WhenIsNotNullSearchingFolder_IsTrue()
        {
            // Actual
            var actual = string.IsNullOrEmpty(_fileSelector.ChooseImage().Path);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}
