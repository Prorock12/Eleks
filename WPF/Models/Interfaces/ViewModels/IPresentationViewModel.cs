using Models.Interfaces.Models;
using System.Collections.ObjectModel;

namespace Models.Interfaces.ViewModels
{
    public interface IPresentationViewModel
    {
        #region Properties

        IPresentation Presentation { get; set; }

        #endregion Properties
    }
}