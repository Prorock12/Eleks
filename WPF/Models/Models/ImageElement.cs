using Models.Interfaces.Models;

namespace Models.Models
{
    public class ImageElement : MediaElement, IImageElement
    {
        public ImageElement(string name):base(name)
        {

        }
    }
}