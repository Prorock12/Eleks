using Models.Interfaces.Models;
using Modules.Redactor.Interfaces;

namespace Modules.Redactor.ViewModels
{
    public class VideoElementViewModel : MediaElementViewModel, IVideoElementViewModel
    {
        #region Properties

        public IVideoElement VideoElement { get; set; }

        #endregion Properties

        #region Constructors

        public VideoElementViewModel(IVideoElement element) : base(element)
        {
            VideoElement = element;
        }

        public VideoElementViewModel()
        {
        }

        #endregion Constructors
    }
}