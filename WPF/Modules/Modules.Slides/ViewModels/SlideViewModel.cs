using Models.Interfaces.Models;
using Modules.Slides.Interfaces;

namespace Modules.Slides.ViewModels
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