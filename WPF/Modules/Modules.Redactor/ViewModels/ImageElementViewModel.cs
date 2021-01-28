using Models.Interfaces.Models;
using Models.Interfaces.ViewModels;

namespace Modules.Redactor.ViewModels
{
    public class ImageElementViewModel : MediaElementViewModel, IImageElementViewModel
    {
        #region Properties

        public IImageElement ImageElement { get; set; }

        #endregion Properties

        public ImageElementViewModel(IImageElement element) : base(element)
        {
            ImageElement = element;
        }
    }
}