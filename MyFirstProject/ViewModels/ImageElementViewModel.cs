using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstProject.Interfaces.Models;
using MyFirstProject.Interfaces.ViewModels;

namespace MyFirstProject.ViewModels
{
    public class ImageElementViewModel : VisualElementViewModel,IImageElementViewModel
    {
        public IImageElement ImageElement { get; set; }
        public ImageElementViewModel(IImageElement element) :base(element)
        {
            ImageElement = element;
        }
    }
}
