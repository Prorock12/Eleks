using Models.Models;
using System.Windows.Forms;

namespace Services.FilseSelector
{
    public interface IFileSelector
    {
        string GetImagePath();

        string GetVideoPath();

        ImageElement ChooseImage();

        VideoElement ChooseVideo();

        FolderBrowserDialog GetFolder();
    }
}