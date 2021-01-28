using Models.Interfaces.Models;
using Models.Interfaces.ViewModels;

namespace Modules.Redactor.ViewModels
{
    public class TextElementViewModel : VisualElementViewModel, ITextElementViewModel
    {
        #region Properties

        public ITextElement TextElement { get; set; }

        #endregion Properties

        public TextElementViewModel(ITextElement element) : base(element)
        {
            TextElement = element;
        }
    }
}