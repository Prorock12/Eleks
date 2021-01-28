using Models.Interfaces.Models;

namespace Models.Models
{
    public class VideoElement : MediaElement, IVideoElement
    {
        public VideoElement(string name) : base(name)
        {

        }
    }
}