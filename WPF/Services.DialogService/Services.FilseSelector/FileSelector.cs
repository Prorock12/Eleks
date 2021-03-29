using Models.Models;
using System.Windows.Forms;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;

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
            if (string.IsNullOrEmpty(path)) return null;
            var image = new ImageElement("newImage") { Path = path };
            return image;
        }

        public VideoElement ChooseVideo()
        {
            var path = GetVideoPath();
            if (string.IsNullOrEmpty(path)) return null;
            var video = new VideoElement("newVideo") { Path = path };
            return video;
        }

        public FolderBrowserDialog GetFolder()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result != DialogResult.OK || string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    return null;

                return fbd;

                //string[] files = Directory.GetFiles(fbd.SelectedPath);

                //return files;
            }
        }
    }
}