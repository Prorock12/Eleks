using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MyFirstProject.Interfaces.ViewModels;

namespace MyFirstProject.Interfaces.Models
{
    public interface IPresentation
    {
        #region Properties

        string Name { get; set; }
        string Path { get; set; }
        ObservableCollection<ISlide> Slides { get; set; }

        #endregion
    }
}
