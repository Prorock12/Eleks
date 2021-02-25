using Models.Interfaces.Models;

namespace Modules.Controller.Interfaces
{
    public interface ISlideViewModel
    {
        #region Properties

        ISlide Slide { get; set; }

        #endregion Properties
    }
}