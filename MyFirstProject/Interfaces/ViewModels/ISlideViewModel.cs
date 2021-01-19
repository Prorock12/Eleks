using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstProject.Interfaces.Models;

namespace MyFirstProject.Interfaces.ViewModels
{
    public interface ISlideViewModel
    {
        #region Properties

        string Name { get; set; }
        ObservableCollection<IElementViewModel> Elements { get;}

        #endregion
    }
}
