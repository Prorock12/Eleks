using Microsoft.Win32;
using Models.Models;

namespace Services.FilseSelector
{
    public class FileSelector : IFileSelector
    {
        private static string GetFilePath(string filter, string defaultExt)
        {
            var openFileDialog = new OpenFileDialog
            {
                DefaultExt = defaultExt,
                Filter = filter
            };

            bool? result = openFileDialog.ShowDialog();
            if (result == null) return null;

            string filename = openFileDialog.FileName;
            return filename;
        }

        public string GetImagePath()
        {
            const string defaultExt = ".png";
            const string filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            return GetFilePath(filter, defaultExt);
        }
        public string GetVideoPath()
        {
            const string defaultExt = ".mp4";
            const string filter = "MP4 Video |*.mp4";
            return GetFilePath(filter, defaultExt);
        }

        public ImageElement ChooseImage()
        {
            var path = GetImagePath();
            var image = new ImageElement("newImage") {Path = path};
            return image;
        }
        public VideoElement ChooseVideo()
        {
            var path = GetVideoPath();
            var video = new VideoElement("newVideo") {Path = path};
            return video;
        }
    }
}
