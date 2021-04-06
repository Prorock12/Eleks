using ModelStandard.Interfaces.Models;

namespace ModelStandard.Models
{
    public class ImageElement : MediaElement, IImageElement
    {
        #region Constructor

        public ImageElement(string name) : base(name)
        {
            Width = 100;
            Height = 100;
            Path = "../Files/Images/image1.jpg";
        }

        #endregion Constructor
    }
}