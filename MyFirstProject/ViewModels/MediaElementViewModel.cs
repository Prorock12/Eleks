using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstProject.Interfaces.Models;
using MyFirstProject.Interfaces.ViewModels;

namespace MyFirstProject.ViewModels
{
    public abstract class MediaElementViewModel : VisualElementViewModel,IMediaElementViewModel
    {
        public IMediaElement MediaElement { get; set; }

        protected MediaElementViewModel(IMediaElement element): base(element)
        {
            MediaElement = element;
        }
    }
}
