using Models.Interfaces.Models;
using Modules.Redactor.Interfaces;

namespace Modules.Redactor.ViewModels
{
    public class TextElementViewModel : VisualElementViewModel, ITextElementViewModel
    {
        #region Properties

        public ITextElement TextElement { get; set; }

        #endregion Properties

        #region Constructors

        public TextElementViewModel(ITextElement element) : base(element)
        {
            TextElement = element;
        }

        public TextElementViewModel()
        {

        }
        #endregion Constructors
    }
}