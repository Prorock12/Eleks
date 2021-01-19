using MyFirstProject.Interfaces.Models;
using MyFirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Models
{
    public class TextElement : VisualElement, ITextElement
    {
        #region Fields

        string _text;

        #endregion

        #region Properties

        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }
    }

    #endregion
}
