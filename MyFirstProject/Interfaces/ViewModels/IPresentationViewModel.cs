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
        string Name { get; set; }
        string Path { get; set; }
        ObservableCollection<ISlideViewModel> Slides { get; set; }

        #endregion
    }
}
