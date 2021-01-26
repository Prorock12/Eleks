using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstProject.Interfaces.Models;
using MyFirstProject.Interfaces.ViewModels;
using MyFirstProject.Models;

namespace MyFirstProject.ViewModels
{
    public class TextElementViewModel : VisualElementViewModel,ITextElementViewModel
    {
        public ITextElement TextElement { get; set; }
        public TextElementViewModel(ITextElement element):base(element)
        {
            TextElement = element;
        }

    }
}
