using Models.Interfaces.Models;
using Modules.Redactor.Interfaces;
using Prism.Commands;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace Modules.Redactor.ViewModels
{
    public class VideoElementViewModel : MediaElementViewModel, IVideoElementViewModel
    {
        #region Properties

        public IVideoElement VideoElement { get; set; }

        #endregion Properties

        #region Constructors

        public VideoElementViewModel(IVideoElement element) : base(element)
        {
            VideoElement = element;
        }

        #endregion Constructors
    }
}