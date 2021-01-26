using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstProject.Interfaces.Models;

namespace MyFirstProject.Interfaces.ViewModels
{
    public interface IPresentationViewModel
    {
        #region Properties
        IPresentation Presentation { get; set; }
        ObservableCollection<ISlideViewModel> Slides { get; set; }

        #endregion
    }
}
