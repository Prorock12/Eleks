using Models.Interfaces.Models;
using Models.Interfaces.ViewModels;
using System.Collections.ObjectModel;

namespace Modules.PresentationRegion.ViewModels
{
    public class PresentationViewModel : IPresentationViewModel
    {
        #region Properties

        public IPresentation Presentation { get; set; }

        #endregion Properties

        public PresentationViewModel(IPresentation presentation)
        {
            Presentation = presentation;
        }
    }
}