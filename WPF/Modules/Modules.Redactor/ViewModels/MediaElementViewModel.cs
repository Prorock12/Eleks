using Models.Interfaces.Models;
using Modules.Redactor.Interfaces;

namespace Modules.Redactor.ViewModels
{
    public abstract class MediaElementViewModel : VisualElementViewModel, IMediaElementViewModel
    {
        #region Properties

        public IMediaElement MediaElement { get; set; }

        #endregion Properties

        #region Constructors

        protected MediaElementViewModel(IMediaElement element) : base(element)
        {
            MediaElement = element;
        }

        protected MediaElementViewModel()
        {

        }
        #endregion Constructors
    }
}