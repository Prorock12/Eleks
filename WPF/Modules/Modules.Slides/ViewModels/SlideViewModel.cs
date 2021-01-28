using Models.Interfaces.Models;
using Models.Interfaces.ViewModels;

namespace Modules.Slides.ViewModels
{
    public class SlideViewModel : ISlideViewModel
    {
        #region Properties

        public ISlide Slide { get; set; }

        #endregion Properties

        public SlideViewModel(ISlide slide)
        {
            Slide = slide;
        }
    }
}