using Models.Interfaces.Models;
using Models.Interfaces.ViewModels;

namespace Modules.Redactor.ViewModels
{
    public abstract class MediaElementViewModel : VisualElementViewModel, IMediaElementViewModel
    {
        #region Properties

        public IMediaElement MediaElement { get; set; }

        #endregion Properties

        protected MediaElementViewModel(IMediaElement element) : base(element)
        {
            MediaElement = element;
        }
    }
}