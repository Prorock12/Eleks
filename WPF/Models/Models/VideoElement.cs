using Models.Interfaces.Models;

namespace Models.Models
{
    public class VideoElement : MediaElement, IVideoElement
    {
        #region Constructor

        public VideoElement(string name) : base(name)
        {
            Width = 1000;
            Height = 500;
            Path = @"C:\Users\bohdan.hlyva\WPF\Modules\Modules.Redactor\Files\Videos\video1.mp4";
        }

        #endregion Constructor
    }
}