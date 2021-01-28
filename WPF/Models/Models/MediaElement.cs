using Models.Interfaces.Models;

namespace Models.Models
{
    public class MediaElement : VisualElement, IMediaElement
    {
        #region Fields

        private string _path;

        #endregion Fields

        #region Properties

        public string Path
        {
            get => _path;
            set => SetProperty(ref _path, value);
        }

        #endregion Properties

        public MediaElement(string name) : base(name)
        {

        }
    }
}