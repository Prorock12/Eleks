using Models.Interfaces.Models;

namespace Modules.PresentationRegion.Interfaces
{
    public interface IPresentationViewModel
    {
        #region Properties

        IPresentation Presentation { get; set; }

        #endregion Properties
    }
}