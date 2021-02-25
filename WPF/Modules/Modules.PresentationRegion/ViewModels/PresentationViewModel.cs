using Models.Interfaces.Models;
using Modules.PresentationRegion.Interfaces;

namespace Modules.PresentationRegion.ViewModels
{
    public class PresentationViewModel : IPresentationViewModel
    {
        #region Properties

        public IPresentation Presentation { get; set; }

        #endregion Properties

        #region Constructor

        public PresentationViewModel(IPresentation presentation)
        {
            Presentation = presentation;
        }

        #endregion Constructor
    }
}