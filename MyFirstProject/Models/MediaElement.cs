using MyFirstProject.Interfaces.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Models
{
    public class MediaElement : VisualElement, IMediaElement
    {
        #region Fields

        string _path;

        #endregion

        #region Properties

        public string Path
        {
            get => _path;
            set => SetProperty(ref _path, value);
        }

        #endregion
    }
}
