using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstProject.Interfaces.Models;
using MyFirstProject.Interfaces.ViewModels;

namespace MyFirstProject.ViewModels
{
    public class VideoElementViewModel : MediaElementViewModel,IVideoElementViewModel
    {
        public IVideoElement VideoElement { get; set; }

        public VideoElementViewModel(IVideoElement element) : base(element)
        {
            VideoElement = element;
        }
        
    }
}
