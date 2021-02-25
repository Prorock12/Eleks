using Models.Interfaces.Models;
using Prism.Mvvm;

namespace Models.Models
{
    public class Resolution : BindableBase, IResolution
    {
        #region Fields

        private int _width;

        private int _height;

        #endregion Fields

        public int Width
        {
            get => _width;
            set => SetProperty(ref _width, value);
        }

        public int Height
        {
            get => _height;
            set => SetProperty(ref _height, value);
        }
    }
}