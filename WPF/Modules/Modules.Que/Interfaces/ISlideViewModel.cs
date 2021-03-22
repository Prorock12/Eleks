using Models.Interfaces.Models;

namespace Modules.Que.Interfaces
{
    public interface ISlideViewModel
    {
        #region Properties

        ISlide Slide { get; set; }

        #endregion Properties
    }
}