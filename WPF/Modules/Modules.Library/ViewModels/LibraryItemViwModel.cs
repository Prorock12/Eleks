using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using Prism.Mvvm;

namespace Modules.Library.ViewModels
{
    public class LibraryItemViwModel : BindableBase
    {
        #region Fields

        private string _name;
        private string _path;
        private BitmapImage _bitmapImage;

        #endregion

        #region Properties

        public BitmapImage BitmapImage
        {
            get
            {
                if (_bitmapImage == null)
                    Task.Run(LoadBitmapImage);
                return _bitmapImage;
            }
            set => SetProperty(ref _bitmapImage, value);
        }
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        public string Path
        {
            get => _path;
            set => SetProperty(ref _path, value);
        }
        #endregion

        private void LoadBitmapImage()
        { 
            //FileStream fileStream =
            //    new FileStream(Path, FileMode.Open, FileAccess.Read);

            var img = new BitmapImage();
            var uri = new Uri(Path);
            img.BeginInit();
            img.UriSource = uri;
            img.EndInit();
            img.Freeze();

            Application.Current.Dispatcher.InvokeAsync(() => BitmapImage = img);
        }
    }
}
