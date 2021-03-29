using Models.Interfaces.Models;
using Modules.Controller.Interfaces;

namespace Modules.Controller.ViewModels
{
    public class SlideViewModel : ISlideViewModel
    {
        #region Properties

        public ISlide Slide { get; set; }

        #endregion Properties

        public SlideViewModel(ISlide slide) : this()
        {
            Slide = slide;
        }

        public SlideViewModel()
        {

        }
    }
}