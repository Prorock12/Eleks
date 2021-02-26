using Models.Models;

namespace Services.FilseSelector
{
    public interface IFileSelector
    {
        string GetImagePath();

        string GetVideoPath();

        ImageElement ChooseImage();

        VideoElement ChooseVideo();
    }
}