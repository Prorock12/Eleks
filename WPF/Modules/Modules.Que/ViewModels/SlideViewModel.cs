using Infrastructure.Events;
using Models.Interfaces.Models;
using Modules.Que.Interfaces;

namespace Modules.Que.ViewModels
{
    public class SlideViewModel : ISlideViewModel
    {
        #region Properties

        public ISlide Slide { get; set; }

        #endregion Properties

        #region Constructor

        public SlideViewModel(ISlide slide)
        {
            Slide = slide;
        }

        #endregion Constructor
    }
}