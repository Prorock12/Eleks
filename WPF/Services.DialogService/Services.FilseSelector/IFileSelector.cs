using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
