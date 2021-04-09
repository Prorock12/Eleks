using Models.Interfaces.Models;
using Modules.Redactor.Interfaces;

namespace Modules.Redactor.ViewModels
{
    public class ImageElementViewModel : MediaElementViewModel, IImageElementViewModel
    {
        #region Properties

        public IImageElement ImageElement { get; set; }

        #endregion Properties

        #region Constructors

        public ImageElementViewModel(IImageElement element) : base(element)
        {
            ImageElement = element;
        }

        public ImageElementViewModel()
        {
        }

        #endregion Constructors
    }
}