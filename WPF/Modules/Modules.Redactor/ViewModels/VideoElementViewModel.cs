using Models.Interfaces.Models;
using Models.Interfaces.ViewModels;

namespace Modules.Redactor.ViewModels
{
    public class VideoElementViewModel : MediaElementViewModel, IVideoElementViewModel
    {
        #region Properties

        public IVideoElement VideoElement { get; set; }

        #endregion Properties

        public VideoElementViewModel(IVideoElement element) : base(element)
        {
            VideoElement = element;
        }
    }
}