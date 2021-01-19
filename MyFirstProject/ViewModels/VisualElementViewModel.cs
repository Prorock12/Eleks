using MyFirstProject.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstProject.Interfaces.ViewModels;

namespace MyFirstProject.ViewModels
{
    public abstract class VisualElementViewModel : ElementViewModel, IVisualElementViewModel
    {
        public IVisualElement VisualElement { get; set; }

        protected VisualElementViewModel(IVisualElement element) : base(element)
        {
            VisualElement = element;
        }
    }
}
